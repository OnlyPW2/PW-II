using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeLuan.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aluno()
        {
            
            ViewBag.Mensagem = "Os melhores alunos são aqueles que estudam mais!";
            if (TempData["ca"] != null)
            ViewData["Exemplo"] = TempData["ca"];
            return View();
        }

        public ActionResult Testando()
        {
            TempData["ca"] = "O MVC é um padrão de desenvolvimento muito utilizado no mundo web é conhecimento por 'forçar' o programador a separar as responsabilidades.";
            return RedirectToAction("Aluno");
        }
        public ActionResult Redirecionamento()
        {
            return Redirect("https://google.com");
        }
    }
}