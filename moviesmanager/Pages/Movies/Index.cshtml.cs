﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesManager.Models;

namespace MoviesManager.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesManager.Models.MoviesManagerContext _context;

        public IndexModel(MoviesManager.Models.MoviesManagerContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
