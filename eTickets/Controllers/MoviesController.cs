using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    [Authorize] // Require login
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
