using NutriSystem.Api.Context;
using NutriSystem.Api.Interface;
using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Contexto _contexto;
        public UsuarioRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Add(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
            _contexto.SaveChanges();

        }

        public Usuario Find(long id)
        {
            return _contexto.Usuario.FirstOrDefault(u => u.UsuarioId == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _contexto.Usuario.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Usuario.First(u => u.UsuarioId == id);
            _contexto.Usuario.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _contexto.Usuario.Update(usuario);
            _contexto.SaveChanges();
        }
    }
}
