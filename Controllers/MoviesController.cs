using AjaxMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxMvc.Controllers
{
    public class MoviesController : Controller
    {
        DataService dataService;

        public MoviesController(DataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("MovieDetails/{id}")]
        public IActionResult MovieDetails(int id)
        {
            var model = dataService.GetMovieById(id);

            return PartialView(model);
        }
    }
}
