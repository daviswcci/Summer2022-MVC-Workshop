using Basketball_Workshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basketball_Workshop.Controllers
{
    public class PositionController : Controller
    {
        private List<Position> db = new List<Position>() { new Position() { Name = "Point Guard" }, new Position() { Name = "Shooting Guard" }, new Position() { Name = "Center" } };
        public IActionResult Index()
        {
            return View(db);
        }
    }
}
