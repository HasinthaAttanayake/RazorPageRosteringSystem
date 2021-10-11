using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageRosteringSystem.Data;
using RazorPageRosteringSystem.Models;

namespace RazorPageRosteringSystem.Pages.Roles
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageRosteringSystem.Data.RazorPageRosteringSystemContext _context;

        public IndexModel(RazorPageRosteringSystem.Data.RazorPageRosteringSystemContext context)
        {
            _context = context;
        }

        public IList<Role> Role { get;set; }

        public async Task OnGetAsync()
        {
            Role = await _context.Role.ToListAsync();
        }
    }
}
