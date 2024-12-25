using Microsoft.AspNetCore.Mvc;

namespace SignalRDay1.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
