﻿using ePizza.Entities.Concrete;
using ePizza.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Services.Interfaces
{
    public interface IOrderService
    {
        //Satıs Detayı
        OrderModel GetOrderDetails(string orderId);
        //Siparişe göre kullanıcı
        IEnumerable<Order> GetUserOrders(int userId);
        //Verilen Sipariş
        Task<int> PlaceOrder(int userId, string orderId,string paymentId,CartModel cart,Address address);
        //Sipariş Listesi
        PagingListModel<OrderModel> GetOrderList(int page=1,int pageSize=10);


    }
}
