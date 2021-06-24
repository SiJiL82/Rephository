using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rephository.Data;
using Rephository.Models;

namespace Rephository.Pages
{
    public class GalleryModel : PageModel
    {
        private RephositoryContext _context;

        public List<Photo> GalleryPhotos { get; set; }
        public GalleryModel(RephositoryContext context)
        {
            _context = context;
        }
        public async Task OnGet()
        {
            ViewData["SuccessMessage"] = TempData["SuccessMessage"];
            GalleryPhotos = await _context.Photos.ToListAsync();
        }
    }
}
