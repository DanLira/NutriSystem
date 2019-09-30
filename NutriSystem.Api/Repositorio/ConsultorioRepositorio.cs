using NutriSystem.Api.Context;
using NutriSystem.Api.Interface;
using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Repositorio
{
    public class ConsultorioRepositorio : IConsultorioRepositorio
    {
        private readonly Contexto _contexto;
        public ConsultorioRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Add(Consultorio consultorio)
        {
            _contexto.Consultorio.Add(consultorio);
            _contexto.SaveChanges();

        }

        public Consultorio Find(long id)
        {
            return _contexto.Consultorio.FirstOrDefault(c => c.ConsultorioId == id);
        }

        public IEnumerable<Consultorio> GetAll()
        {
            return _contexto.Consultorio.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Consultorio.First(c => c.ConsultorioId == id);
            _contexto.Consultorio.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Consultorio consultorio)
        {
            _contexto.Consultorio.Update(consultorio);
            _contexto.SaveChanges();
        }
    }
}
