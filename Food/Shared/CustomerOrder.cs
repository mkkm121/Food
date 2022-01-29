using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Shared
{
    public class CustomerOrder
    {
        public int Id{ get; set; }
        public int OrderId { get; set; }
        public UserRegister Customer { get; set; }

        public int CustomerId { get; set; }
        public List<OrderDetail> Products { get; set; } = new List<OrderDetail>();

        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public string PaymentMode { get; set; } = "Cart";
    }
}
