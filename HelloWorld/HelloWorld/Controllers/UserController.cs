using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("{controller}/{action}")]
    public class UserController : Controller
    {
        public IActionResult GetUsers()
        {
            return View();
        }
    }
}
