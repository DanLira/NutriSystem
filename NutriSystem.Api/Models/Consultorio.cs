using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Models
{
    public class Consultorio
    {
        public int ConsultorioId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        //public List<Nutricionista> Nutricionista { get; set; }

    }
}
