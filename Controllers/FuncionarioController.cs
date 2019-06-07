using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoR.Models;

namespace TrabalhoR.Controllers
{
    public class FuncionarioController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            Funcao f = new Funcao();

            List<Funcao> listaFuncoes = f.ObterTodasFuncoes();

            ViewBag.FuncaoId = new SelectList(listaFuncoes, "FuncaoId", "Descricao");
            return View();
        }


    }
}