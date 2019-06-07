using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoR.Models
{
    public class Funcao
    {
        public int FuncaoId { get; set; }
        public string Descricao { get; set; }

        internal List<Funcao> ObterTodasFuncoes()
        {
            throw new NotImplementedException();
        }
    }
}