using NutriSystem.Api.Context;
using NutriSystem.Api.Interface;
using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Repositorio
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        private readonly Contexto _contexto;
        public PacienteRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Add(Paciente paciente)
        {
            _contexto.Paciente.Add(paciente);
            _contexto.SaveChanges();

        }

        public Paciente Find(long id)
        {
            return _contexto.Paciente.FirstOrDefault(p => p.PacienteId == id);
        }

        public IEnumerable<Paciente> GetAll()
        {
            return _contexto.Paciente.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Paciente.First(p => p.PacienteId == id);
            _contexto.Paciente.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Paciente paciente)
        {
            _contexto.Paciente.Update(paciente);
            _contexto.SaveChanges();
        }
    }
}
