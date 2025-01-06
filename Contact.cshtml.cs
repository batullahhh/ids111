using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SOFT40081_StarterCode.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Here, you can handle the form submission, such as sending an email with the contact information.

            // TempData can be used to display a success message after form submission.
            TempData["SuccessMessage"] = "Thank you for contacting us. We will get back to you soon!";
            return RedirectToPage("/Contact");
        }
    }
}
