using CSharp_MVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_MVC1.Controllers
{
    public class UserController : Controller
    {


        [HttpGet("")]
        public IActionResult Index()
        {

            User user = new User();

            user.Name = "Karl";
            user.Email = "kpilk@gmail.com";

            ViewBag.User = user;

            return View();
        }
    }
}
