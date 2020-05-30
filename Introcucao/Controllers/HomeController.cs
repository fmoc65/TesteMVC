using System.Web.Mvc;

namespace Introcucao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return  View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

    }
}