using NutriSystem.Api.Context;
using NutriSystem.Api.Interface;
using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Repositorio
{
    public class NutricionistaRepositorio : INutricionistaRepositorio
    {
        private readonly Contexto _contexto;
        public NutricionistaRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Add(Nutricionista nutricionista)
        {
            _contexto.Nutricionista.Add(nutricionista);
            _contexto.SaveChanges();

        }

        public Nutricionista Find(long id)
        {
            return _contexto.Nutricionista.FirstOrDefault(n => n.NutricionistaId == id);
        }

        public IEnumerable<Nutricionista> GetAll()
        {
            return _contexto.Nutricionista.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Nutricionista.First(n => n.NutricionistaId == id);
            _contexto.Nutricionista.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Nutricionista nutricionista)
        {
            _contexto.Nutricionista.Update(nutricionista);
            _contexto.SaveChanges();
        }
    }
}
