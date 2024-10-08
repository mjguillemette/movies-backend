using Microsoft.AspNetCore.Mvc;
using MovieRentalBackend.Models;
using MovieRentalBackend.Repositories;

namespace MovieRentalBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        // GET: api/movies
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = MovieRepository.GetAllMovies();
            return Ok(movies);
        }

        // GET: api/movies/search
        [HttpGet("search")]
        public IActionResult SearchMovies([FromQuery] string? title, [FromQuery] string? genre, [FromQuery] string? director, [FromQuery] int? yearOfRelease)
        {
            var result = MovieRepository.SearchMovies(title, genre, director, yearOfRelease);
            return Ok(result);
        }

        // POST: api/movies/checkout
        [HttpPost("checkout")]
        public IActionResult CheckoutMovie([FromBody] CheckoutRequest request)
        {
            MovieRepository.UpdateStock(request.Title, -request.Amount);  // Checkout, reducing the stock
            return Ok("Checkout successful.");
        }

        // POST: api/movies/return
        [HttpPost("return")]
        public IActionResult ReturnMovie([FromBody] CheckoutRequest request)
        {
            MovieRepository.UpdateStock(request.Title, request.Amount);  // Returning, increasing the stock
            return Ok("Return successful.");
        }
    }
}
