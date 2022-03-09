using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_app.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public int CodigoDepartamento { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string UltimoNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public int Fone { get; set; }
        public string Funcao { get; set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {

        }
    }
}