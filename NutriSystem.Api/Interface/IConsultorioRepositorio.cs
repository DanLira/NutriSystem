using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Interface
{
    public interface IConsultorioRepositorio
    {
        void Add(Consultorio consultorio);
        IEnumerable<Consultorio> GetAll();
        Consultorio Find(long id);
        void Remove(long id);
        void Update(Consultorio consultorio);
    }
}
