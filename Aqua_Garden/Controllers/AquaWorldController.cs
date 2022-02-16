using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aqua_Garden.Controllers
{
    public class AquaWorldController : Controller
    {
        // GET: AquaWorldController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddData()
        {
            return View();
        }


    }
}
