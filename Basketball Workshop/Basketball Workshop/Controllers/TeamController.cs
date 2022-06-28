using Microsoft.AspNetCore.Mvc;
using Basketball_Workshop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Basketball_Workshop.Controllers
{
    public class TeamController : Controller
    {
        public BasketballContext db { get; set; }
        public TeamController(BasketballContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Teams.ToList());
        }

        public IActionResult Details(int id)
        {
            return View(db.Teams.ToList().Where(t => t.Id == id).FirstOrDefault());
        }

        public IActionResult Create()
        {
            List<Coach> coaches = new List<Coach>();
            foreach (Coach c in db.Coaches.ToList())
            {
                // check to see if c is located on a team
                Team temp = db.Teams.FirstOrDefault(team => team.CoachId == c.Id);
                if (temp == null)
                {
                    // if so, remove it from the list
                    coaches.Add(c);
                }
            }

            // one-liner version
            //List<Coach> coaches = db.Coaches.Where(c => db.Teams.FirstOrDefault(t => t.CoachId == c.Id) == null).ToList();

            ViewBag.Coaches = new SelectList(coaches, "Id", "Name");
            return View(new Team());
        }

        [HttpPost]
        public IActionResult Create(Team model)
        {
            db.Teams.Add(model);
            db.SaveChanges();
            return RedirectToAction("Details", model); // pass more than what we need to display the model
            // return RedirectToAction("Details", new { id = model.Id.ToString()});
        }
    }
}
