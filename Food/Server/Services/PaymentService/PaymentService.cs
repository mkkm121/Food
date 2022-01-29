using Food.Shared;
using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51KKNxEGjs732iTUgff02vUgyLbSYBWxRe22UwGvQ35vF6s6LvhrquREisxD1LuaXsK6GRZQmI0I6IVVksMWjTUFZ00qzl1dGVP";
        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {

            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            { 
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = ci.ProductTitle,
                        Images = new List<string> { ci.Image}
                    }
                },
                Quantity = ci.Quantity
            }));
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:44391/ordersuccess",
                CancelUrl = "https://localhost:44391/cart",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }
    }
}
