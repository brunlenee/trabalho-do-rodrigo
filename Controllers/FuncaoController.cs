using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoR.Models;

namespace TrabalhoR.Controllers
{
    public class FuncaoController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public List<Funcao> ObterTodasFuncoes()
        {
          
            List<Funcao> listaFuncoes = new List<Funcao>();
            Funcao f = new Funcao();
            f.FuncaoId = 1;
            f.Descricao = "dettt";

            listaFuncoes.Add(f);
            listaFuncoes.Add(new Funcao() { FuncaoId = 1, Descricao = "MALUCO" });
            return listaFuncoes;
        }

    }
}