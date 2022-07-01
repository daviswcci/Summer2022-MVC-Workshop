using Basketball_Workshop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Basketball_Workshop.Controllers
{
    public class PlayerController : Controller
    {
        public BasketballContext db { get; set; }
        public SignInManager<User> signInManager { get; set; } // refactor
        public PlayerController(BasketballContext db, SignInManager<User> signInManager)
        {
            this.db = db;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(db.Players.ToList());
        }


        public IActionResult Details(int id)
        {
            return View(db.Players.Find(id));
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Create()
        {
            return View(new TempPlayer());
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(TempPlayer model)
        {
            Player player = new Player() { IsRetired = model.IsRetired, Name = model.Name, TeamId = model.TeamId, PPG = model.PPG, UserId = signInManager.UserManager.GetUserId(User)};
            db.Players.Add(player);
            db.SaveChanges();
            int playerId = player.Id;
            if (model.PointGuard)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = playerId, PositionId = 1 };
                db.PlayerPositions.Add(playerPosition);
            }
            if (model.ShootingGuard)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = playerId, PositionId = 2 };
                db.PlayerPositions.Add(playerPosition);
            }
            if (model.SmallForward)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = playerId, PositionId = 3 };
                db.PlayerPositions.Add(playerPosition);
            }
            if (model.PowerForward)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = playerId, PositionId = 4 };
                db.PlayerPositions.Add(playerPosition);
            }
            if (model.Center)
            {
                PlayerPosition playerPosition = new PlayerPosition() { PlayerId = playerId, PositionId = 5 };
                db.PlayerPositions.Add(playerPosition);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
