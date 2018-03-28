using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebConsultasv10.Models;

namespace WebConsultasv10.Controllers
{
    public class LoginController : Controller
    {
        private WebConsultasContext db = new WebConsultasContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autentica(Usuarios usuarios)
        {
            Usuarios usuario = db.Usuarios.Where(c => c.Nick == usuarios.Nick && c.Senha == usuarios.Senha ).FirstOrDefault();
           if (usuario != null)
            {
                Session["usuarioLogado"] = usuarios;
                return RedirectToAction("Index","Funcionarios");

            }

           else
            {
                ViewBag.ErroAutenticacao = "Usuário ou senha inválidos!";
                return View("Index");
            }
            
        }
    }
}