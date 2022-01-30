using Blazored.LocalStorage;
using Food.Server.Data;
using Food.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Food.Server.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;
        public OrderService(DataContext context)
        {
            _context = context;
        }

        public void CreateNewOrder(List<CartItem> cart)
        {
            UserRegister user = _context.Users.FirstOrDefault(p => p.Email == cart[0].CustomerEmail);
            int _orderId = GenerateOrderId();
            CustomerOrder order = new CustomerOrder { CustomerId = user.Id, OrderId = _orderId, CustomerCity = cart[0].CustomerCity, CustomerPostCode = cart[0].CustomerPostCode,
                                                        CustomerStreet=cart[0].CustomerStreet, CustomerNote=cart[0].CustomerNote};
             _context.CustomerOrders.Add(order);
            _context.SaveChanges();
            CreateNewDetail(_orderId, cart);

        }
        public void CreateNewDetail(int _orderId, List<CartItem> cart)
        {
            CustomerOrder order = _context.CustomerOrders.FirstOrDefault(p => p.OrderId == _orderId);
            OrderDetail orderDetail = new OrderDetail();
            foreach (var item in cart)
            {
                orderDetail.OrderId = order.Id;
                orderDetail.ProductId = item.ProductId;
                orderDetail.EditionId = item.EditionId;
                orderDetail.Quantity = item.Quantity;
                orderDetail.Price = item.Price;
                orderDetail.SubTotal = item.Quantity * item.Price;
                _context.OrderDetails.Add(orderDetail);
                _context.SaveChanges();
            }
            

        }
        public int GenerateOrderId()
        {
            int OrderId = 0;
            Random generator = null;
            for(int i=0; i<1000;i++)
            {
                generator = new Random();
                OrderId = generator.Next(1, 1000000);
                if (!_context.CustomerOrders.Where(x => x.OrderId == OrderId).Any())
                    break;
            }
            return OrderId;
        }

    }
}
