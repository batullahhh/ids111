using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SOFT40081_StarterCode.Models;

namespace SOFT40081_StarterCode.Pages_Products
{
    public class CartModel : PageModel
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public void OnGet()
        {
            CartItems = HttpContext.Session.GetObjectFromJson<List<CartItem>>("cart") ?? new List<CartItem>();
        }
    }
}
