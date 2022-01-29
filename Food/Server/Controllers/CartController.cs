using Food.Server.Services.CartService;
using Food.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Food.Server.Controllers
{
    [Route("api/Cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerOrder>> PostCart(CustomerOrder cart)
        {
            await _cartService.AddNewCart(cart);
            return Ok();
        }

    }
}
