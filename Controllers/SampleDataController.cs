using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DVDMovie.Models;

namespace DVDMovie.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private DataContext context;

        public SampleDataController(DataContext ctx)
        {
            this.context = ctx;
        }

        [HttpGet("[action]")]
        public Movie GetMovie()
        {
            return context.Movies.OrderBy(m => m.MovieId).First();
        }
    }
}
