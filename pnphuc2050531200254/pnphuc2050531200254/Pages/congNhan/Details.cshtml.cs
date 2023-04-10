using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pnphuc2050531200254.Data;
using pnphuc2050531200254.Models;

namespace pnphuc2050531200254.Pages.congNhan
{
    public class DetailsModel : PageModel
    {
        private readonly pnphuc2050531200254.Data.CNContext _context;

        public DetailsModel(pnphuc2050531200254.Data.CNContext context)
        {
            _context = context;
        }

      public congNhan congNhan { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.congNhan == null)
            {
                return NotFound();
            }

            var congnhan = await _context.congNhan.FirstOrDefaultAsync(m => m.Id == id);
            if (congnhan == null)
            {
                return NotFound();
            }
            else 
            {
                congNhan = congnhan;
            }
            return Page();
        }
    }
}
