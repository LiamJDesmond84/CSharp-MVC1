using CSharp_MVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC1.Controllers
{
    public class UserController : Controller
    {


        [HttpGet("/UserIndex")]
        public IActionResult Index()
        {
            // Using @ViewBag in cshtml
            User user = new User();

            user.Name = "Karl";
            user.Email = "kpilk@gmail.com";

            ViewBag.User = user;

            // Using @Model in cshtml
                // "Index" if you wanted to name a specific View file
            return View("Index", user);
        }
    }
}
