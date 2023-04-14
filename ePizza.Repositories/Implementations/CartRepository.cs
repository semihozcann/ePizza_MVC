﻿using ePizza.Data.Concrete.EntityFramework.Contexts;
using ePizza.Entities.Concrete;
using ePizza.Repositories.Interfaces;
using ePizza.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Repositories.Implementations
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {

        public ePizzaContext ePizzaContext
        {
            //context nesnesini burada kapsule(encapsulation) ederek almıs olduk...
            get
            {
                return _context as ePizzaContext;
            }
        }


        public CartRepository(DbContext context) : base(context)
        {
        }

        public int DeleteProduct(Guid cartId, int productId)
        {
            var item = ePizzaContext.CartItems.FirstOrDefault(c => c.CartId == cartId && c.Id == productId);
            if (item != null)
            {
                ePizzaContext.CartItems.Remove(item);
                return _context.SaveChanges();
            }
            else
            {
                return 0;
            }


        }

        public Cart GetCart(Guid cartId)
        {
            return ePizzaContext.Carts.Include("Products").FirstOrDefault(x => x.Id == cartId && x.IsActive == true);
        }

        public CartModel GetCartDetails(Guid cartId)
        {
            /*
             
select I.Id,P.Name,P.Description,P.ImageUrl,I.Quantity,P.Id,I.UnitPrice from Carts C inner join CartItems I on c.Id=I.CartId  inner join Products P on P.Id= I.ProductId
            */

            var model = (from cart in ePizzaContext.Carts
                         where cart.Id == cartId && cart.IsActive == true
                         select new CartModel
                         {
                             Id = cart.Id,
                             UserId = cart.UserId,
                             CreatedDate = cart.CreatedDate,
                             Products = (from cartItem in ePizzaContext.CartItems
                                         join item in ePizzaContext.Products
                                         on cartItem.ProductId equals item.Id
                                         where cartItem.CartId == cartId
                                         select new ProductModel()
                                         {
                                             Id = cartItem.Id,
                                             Name = item.Name,
                                             Description = item.Description,
                                             ImageUrl = item.ImageUrl,
                                             Quantity = cartItem.Quantity,
                                             ProductId = item.Id,
                                             UnitPrice = cartItem.UnitPrice
                                         }).ToList()


                         }).FirstOrDefault();
            return model;
        }

        public int UpdateQuantity(Guid cartId, int productId, int quantity)
        {
            bool flag = false;
            var cart = GetCart(cartId); // secilen urunu getir.
            if (cart != null) // urun var ise 
            {
                for (int i = 0; i < cart.Products.Count; i++) // sepetin icindeki nesneleri dön
                {
                    if (cart.Products[i].Id == productId) // sepet icindeki ürün gelen urunun ıd eşit ise
                    {
                        flag = true; // bayragı true yap
                        if (quantity < 0 && cart.Products[i].Quantity > 1) // miktar kucukse sıfırdan ve mevcut sepet buyukse 1 den 
                            cart.Products[i].Quantity += (quantity); // mevcut sepete gelen miktari ekle
                        else if (quantity > 0) // mevcut sepet buyuk ise 0 dan 
                            cart.Products[i].Quantity += (quantity); // gelen değeri mevcut sepete ekle
                        break; // işi bitir.
                    }
                }
                if (flag) // bayrak true ise  sql'e kayıt et
                {
                    return _context.SaveChanges();
                }
            }

            return 0; // return 0 dondur eğer urun yada sepet yoksa 
        }

        public int UpdateToCart(Guid cartId, int userId)
        {
            Cart cart = GetCart(cartId);
            cart.UserId = userId;
            return _context.SaveChanges();
        }

    }
}
