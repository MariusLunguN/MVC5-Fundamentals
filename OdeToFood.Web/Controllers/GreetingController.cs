using OdeToFood.Web.Models;
using System.Configuration;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index()
        {
            var model = new GreedingViewModel();
            model.MessageToDisplay = ConfigurationManager.AppSettings["message"];

            return View(model);
        }
    }
}