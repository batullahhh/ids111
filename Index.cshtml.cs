using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SOFT40081_StarterCode.Data;

namespace SOFT40081_StarterCode.Pages_Users
{
    public class IndexModel : PageModel
    {
        private readonly SOFT40081_StarterCode.Data.ApplicationDbContext _context;

        public IndexModel(SOFT40081_StarterCode.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
