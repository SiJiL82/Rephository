using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rephository;
using Rephository.Data;
using Rephository.Models;

namespace Rephository.Pages.Photos
{
    public class DetailsModel : PageModel
    {
        private readonly Rephository.Data.RephositoryContext _context;

        public DetailsModel(Rephository.Data.RephositoryContext context)
        {
            _context = context;
        }

        public Photo Photo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Photo = await _context.Photos.FirstOrDefaultAsync(m => m.ID == id);

            if (Photo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
