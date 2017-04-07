using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   

        public IActionResult About()
        {
            return View();
        }    

        public IActionResult Error()
        {
            return View();
        }
    }
}