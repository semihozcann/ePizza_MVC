using ePizza.Entities.Concrete;
using ePizza.Repositories.Models;
using ePizza.Services.Interfaces;
using ePizza.UI.Helpers;
using ePizza.UI.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Text.Json;

namespace ePizza.UI.Controllers
{
    [Authorize(Roles = "User")]
    public class CartController : BaseController
    {
        readonly ICartService _cartService;
        Guid cartId
        {
            get
            {
                Guid Id;
                string CId = Request.Cookies["CId"];
                if (string.IsNullOrEmpty(CId))
                {
                    Id = Guid.NewGuid();
                    string guidType = Id.ToString();
                    Response.Cookies.Append("CId", guidType);
                }
                else
                {
                    Id = Guid.Parse(CId);
                }
                return Id;
            }
        }
        public CartController(ICartService cartService, IUserAccessor userAccessor) : base(userAccessor)
        {
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            CartModel cart = _cartService.GetCartDetails(cartId);
            if (CurrentUser != null && cart != null)
            {
                TempData.Set("Cart", cart);
                _cartService.UpdateCart(cart.Id, CurrentUser.Id);
            }
            return View(cart);
        }

        [Route("Cart/AddToCart/{productId}/{unitPrice}/{quantity}")]
        public IActionResult AddToCart(int productId, decimal unitPrice, int quantity)
        {

            int userId = CurrentUser != null ? CurrentUser.Id : 0;

            if (productId > 0 && quantity > 0)
            {
              
                Cart cart = _cartService.AddItem(userId, cartId, productId, unitPrice, quantity);
                var data = JsonSerializer.Serialize(cart);
                return Json(data);
            }
            else
            {
                return Json("");
            }
        }

        public IActionResult DeleteItem(int Id)
        {
            int count = _cartService.DeleteItem(cartId, Id);
            return RedirectToAction("Index", "Cart");
        }

        [Route("Cart/UpdateQuantity/{Id}/{Quantity}")]
        public IActionResult UpdateQuantity(int Id, int Quantity)
        {
            int count = _cartService.UpdateQuantity(cartId, Id, Quantity);
            return Json(count);
        }

        public IActionResult GetCartCount()
            {
            int count = _cartService.GetCartCount(cartId);
            return Json(count);

        }

        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Address address)
        {
            TempData.Set("Address", address);
            return RedirectToAction("Index", "Payment");
        }

    }
}
