using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Interface
{
    public interface INutricionistaRepositorio
    {
            void Add(Nutricionista nutricionista);
            IEnumerable<Nutricionista> GetAll();
            Nutricionista Find(long id);
            void Remove(long id);
            void Update(Nutricionista nutricionista);

        
    }
}
