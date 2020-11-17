using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_A.P.I___COVID.Models
{
    public class Covid
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Sexo{ get; set; }
        public string EstadoCivil { get; set; }
        public Boolean Comorbidade { get; set; }
        public DateTime DataRegistro { get; set; }


    }
}
