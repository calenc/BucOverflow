using BucOverflow.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BucOverflow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //returns the default homepage view, contains first login cookie
        public IActionResult Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString());
                ViewBag.firstLogin = true;
            }

            return View();
        }

        //returns the FAQ from the MVP
        public IActionResult FAQ()
        {
            return View();
        }


        //returns the login page
        public IActionResult UserLogin()
        {
            using (var db = new UserContext())
            {
                return View();
            }
        }

		public IActionResult NewUser(UserModel user)
		{
			using (var db = new UserContext())
	        {
			    db.Users.Add(user);
			    db.SaveChanges();
		   	}
		    return RedirectToAction("UserProfile", "Home");
		}

        // returns the Privacy Policy page, a simplified version to increase professionalism and aid disclaimer in making
        // privacy/security conditions known to users
        public IActionResult Privacy()

        {
            return View();
        }

        // returns the About page for the website, briefly describing the project and team
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}