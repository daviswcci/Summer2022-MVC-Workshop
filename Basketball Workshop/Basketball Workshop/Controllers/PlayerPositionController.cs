using Basketball_Workshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Basketball_Workshop.Controllers
{
    public class PlayerPositionController : Controller
    {
        public BasketballContext db;
        public PlayerPositionController(BasketballContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.PlayerPositions.ToList());
        }

        public IActionResult Delete(int id)
        {
            PlayerPosition temp = db.PlayerPositions.ToList().Where(p => p.Id == id).FirstOrDefault();
            return View(temp);
        }

        //public IActionResult Delete()
        //{
        //    // delete all objects
        //}
    }
}
