using Food.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Services.CartService
{
    public interface ICartService
    {
        Task AddNewCart(CustomerOrder cart);
    }
}
