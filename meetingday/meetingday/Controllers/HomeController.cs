using meetingday.Models;
using Microsoft.AspNetCore.Mvc;

namespace meetingday.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Count = Repository.Users.Where(info => info.WillAttend == true).Count();
            return View();
        }

        [HttpGet]
        public IActionResult apply()
        {
            return View();
        }

        
        
        [HttpPost]
        public IActionResult apply(Userinfo model)
        {
            if(ModelState.IsValid)
            {
                Repository.CreateUsers(model);
                ViewBag.Count = Repository.Users.Where(info => info.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult Userlist()
        {
            var user = Repository.Users;
            return View(user);
        }

        public IActionResult Userprofile(int id)
        {
            return View(Repository.GetById(id));
        }
        
        
        

    }


}
