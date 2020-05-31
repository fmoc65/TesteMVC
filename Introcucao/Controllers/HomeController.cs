using System.Web.Mvc;


namespace Introcucao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Models.Pessoa
            {
                PessoaId = 1,
                Nome = "Jose Carlos",
                Tipo = "Administrador"
            };

            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Nome = pessoa.Nome;
            //ViewBag.Tipo = pessoa.Tipo;
            return  View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

    }
}