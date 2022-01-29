using Food.Server.Data;
using Food.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;

        public OrderDetail order_list { get; set; } = new OrderDetail();
        public CartService(DataContext context)
        {
            _context = context;
        }
        public async Task AddNewCart(CustomerOrder cart)
        {
            _context.CustomerOrders.Add(cart);
            _context.SaveChanges();
        }

    }
}
