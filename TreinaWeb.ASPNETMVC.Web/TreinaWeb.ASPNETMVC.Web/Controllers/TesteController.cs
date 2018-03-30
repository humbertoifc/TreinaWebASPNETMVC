using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinaWeb.ASPNETMVC.Web.Models;

namespace TreinaWeb.ASPNETMVC.Web.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include ="Nome, Idade, Endereco, Email")]Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Saudacao", pessoa);
            }
            else
            {
                return View(pessoa); 
            }
        }
    }
}