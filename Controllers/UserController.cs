using CSharp_MVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC1.Controllers
{
    public class UserController : Controller
    {


        [HttpGet("/UserIndex")]
        public IActionResult Index()
        {

            User user = new User();

            user.Name = "Karl";
            user.Email = "kpilk@gmail.com";

            // Using @ViewBag in cshtml
            ViewBag.User = user;

            // Using @Model in cshtml(user argument)
                // "Index" if you wanted to name a specific View file
            return View("Index", user);
        }
    }
}
