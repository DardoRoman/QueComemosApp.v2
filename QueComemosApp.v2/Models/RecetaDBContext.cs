using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QueComemosApp.v2.Models;

namespace QueComemosApp.v2.Models
{
    public class RecetaDBContext : DbContext
    {
        public RecetaDBContext(DbContextOptions<RecetaDBContext> options) : base(options)
        {
        }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }

}
