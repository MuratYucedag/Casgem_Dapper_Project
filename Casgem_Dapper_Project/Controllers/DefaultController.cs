using Microsoft.AspNetCore.Mvc;

namespace Casgem_Dapper_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
