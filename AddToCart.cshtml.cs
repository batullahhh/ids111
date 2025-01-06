using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOFT40081_StarterCode.Data;
using SOFT40081_StarterCode.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SOFT40081_StarterCode.Pages.Products
{
    public class AddToCartModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddToCartModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CartItem CartItem { get; set; }

        public async Task<IActionResult> OnPostAsync(int productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
            {
                return NotFound();
            }

            var cartItem = new CartItem
            {
                ProductId = productId,
                ProductName = product.Name,
                Price = product.Price,
                Quantity = quantity,
                UserId = User.Identity.Name // Assumes you use Identity for User management
            };

            _context.CartItems.Add(cartItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Products/Index");
        }
    }
}
