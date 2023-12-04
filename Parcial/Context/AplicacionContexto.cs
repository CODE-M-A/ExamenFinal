using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Aviones> Disco { get; set; }
        public DbSet<Hangares> Musica { get; set; }
        //public DbSet<Universidad> Universidad { get; set; }
    }
}
