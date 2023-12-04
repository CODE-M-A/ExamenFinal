using Microsoft.EntityFrameworkCore;
using ProyectoBackendMiguelVillca.Models;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Hangares> Hangares { get; set; }
        public DbSet<Pilotos> Pilotos { get; set; }
    }
}
