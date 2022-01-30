using Food.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Services.OrderService
{
    public interface IOrderService
    {
        void CreateNewOrder(List<CartItem> cart);

        int GenerateOrderId();
        void CreateNewDetail(int _orderId, List<CartItem> cart);

    }
}
