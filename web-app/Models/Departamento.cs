using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_app.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Rg { get; set; }
        public string Sexo { get; set; }

        public Departamento()
        {

        }
    }
}