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
    public class IndexModel : PageModel
    {
        private readonly Rephository.Data.RephositoryContext _context;

        public IndexModel(Rephository.Data.RephositoryContext context)
        {
            _context = context;
        }

        public IList<Photo> Photo { get;set; }

        public async Task OnGetAsync()
        {
            Photo = await _context.Photos.ToListAsync();
        }
    }
}
