using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Models
{
    public class Nutricionista
    {
        public int NutricionistaId { get; set; }
        public string Nome { get; set; }
        public string Crn { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
       // public ICollection<Paciente> Paciente { get; set; }
    }
}
