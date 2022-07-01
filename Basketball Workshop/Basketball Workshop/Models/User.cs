using Microsoft.AspNetCore.Identity;

namespace Basketball_Workshop.Models
{
    public class User : IdentityUser
    {
        public virtual List<Player> Players { get; set; }
    }
}
