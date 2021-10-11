using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageRosteringSystem.Data;
using RazorPageRosteringSystem.Models;

namespace RazorPageRosteringSystem.Pages.Roles
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageRosteringSystem.Data.RazorPageRosteringSystemContext _context;

        public CreateModel(RazorPageRosteringSystem.Data.RazorPageRosteringSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Role Role { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Role.Add(Role);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
