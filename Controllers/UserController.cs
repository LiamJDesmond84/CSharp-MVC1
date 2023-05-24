using CSharp_MVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC1.Controllers
{
    public class UserController : Controller
    {



        [HttpGet("/UserIndex")]
        public IActionResult Index()
        {

            List<User> users = new List<User>();

            User user = new User();

            user.FirstName = "Karl";
            user.LastName = "Pilkington";
            user.Email = "kpilk@gmail.com";

            User user2 = new User();

            user.FirstName = "Ricky";
            user.LastName = "Gervais";
            user.Email = "rickyg@gmail.com";

            // Using @ViewBag in cshtml
            ViewBag.User = user;

            users.Add(user);
            users.Add(user2);

            // Using @Model in cshtml(user argument)
                // "Index" if you wanted to name a specific View file
            return View("Index", users);
        }
    }
}
