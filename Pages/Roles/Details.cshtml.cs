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
    public class DetailsModel : PageModel
    {
        private readonly RazorPageRosteringSystem.Data.RazorPageRosteringSystemContext _context;

        public DetailsModel(RazorPageRosteringSystem.Data.RazorPageRosteringSystemContext context)
        {
            _context = context;
        }

        public Role Role { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Role = await _context.Role.FirstOrDefaultAsync(m => m.roleID == id);

            if (Role == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
