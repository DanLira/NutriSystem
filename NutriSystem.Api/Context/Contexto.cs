using Microsoft.EntityFrameworkCore;
using NutriSystem.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriSystem.Api.Context
{
    public class Contexto : DbContext
    {

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Nutricionista> Nutricionista { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Consultorio> Consultorio { get; set; }

       

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
            
        }



    }
}
