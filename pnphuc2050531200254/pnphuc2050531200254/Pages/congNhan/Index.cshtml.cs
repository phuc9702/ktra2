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
    public class IndexModel : PageModel
    {
        private readonly pnphuc2050531200254.Data.CNContext _context;

        public IndexModel(pnphuc2050531200254.Data.CNContext context)
        {
            _context = context;
        }

        public IList<congNhan> congNhan { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.congNhan != null)
            {
                congNhan = await _context.congNhan.ToListAsync();
            }
        }
    }
}
