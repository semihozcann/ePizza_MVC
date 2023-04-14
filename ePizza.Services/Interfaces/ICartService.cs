﻿using ePizza.Entities.Concrete;
using ePizza.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Interfaces
{
    public interface ICartService
    {
        int GetCartCount(Guid cartId);
        CartModel GetCartDetails(Guid cartId);
        Cart AddItem(int userId, Guid cartId, int productId, decimal unitPrice, int quantity);
        int DeleteItem(Guid cartId, int itemId);
        int UpdateQuantity(Guid cartId,int id, int quantity);
        int UpdateCart(Guid cartId, int userId);


    }
}
