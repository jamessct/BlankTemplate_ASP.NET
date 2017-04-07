using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        }    
    }
}