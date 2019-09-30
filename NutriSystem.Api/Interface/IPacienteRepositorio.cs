using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Interface
{
    public interface IPacienteRepositorio
    {
        void Add(Paciente paciente);
        IEnumerable<Paciente> GetAll();
        Paciente Find(long id);
        void Remove(long id);
        void Update(Paciente paciente);
    }
}
