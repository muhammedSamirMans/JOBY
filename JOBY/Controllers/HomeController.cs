using JOBY.BLL.IReposatories;
using JOBY.BLL.Repositories;
using JOBY.DAL.DataContext;
using JOBY.DAL.Entities;
using JOBY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JOBY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult FindJobs()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SendContactMessage([FromBody] ContactMessage message,[FromServices] IContactRepository _contactRepository)
        {
            //Check Validation
            #region
            if (message == null)
                return Json(new { Status = 500, Message = "PLZ Fill All Data and try agian later..." });
            if (message.Message == "" || message.Message == null || message.Message.Length < 10)
                return Json(new { Status = 500, Message = "Message Must Contain A text with min Lenth 10" });
            if (message.Name == "" || message.Name == null )
                return Json(new { Status = 500, Message = "Name must be fill." });
            if (message.Subject == "" || message.Subject == null )
                return Json(new { Status = 500, Message = "Subject is required" });
            if (message.Email == "" || message.Email == null || !message.Email.Contains("@"))
                return Json(new { Status = 500, Message = "Plz Make Sure This is Vaild Mail" });
            #endregion
            try
            {
                _contactRepository.InsertMessage(message);
                return Json(new { Status = 200, Message = "Your Message Sent Successfuly"});
            }
            catch { return Json(new { Status = 500, Message = "Sorry Server Error PLZ Try agian later...", Object = message }); }
            
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult CourseDetails()
        {
            return View();
        }
        public IActionResult JobDetails()
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
