using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using pnphuc2050531200254.Data;
using pnphuc2050531200254.Models;

namespace pnphuc2050531200254.Pages.congNhan
{
    public class CreateModel : PageModel
    {
        private readonly pnphuc2050531200254.Data.CNContext _context;

        public CreateModel(pnphuc2050531200254.Data.CNContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public congNhan congNhan { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.congNhan == null || congNhan == null)
            {
                return Page();
            }

            _context.congNhan.Add(congNhan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
