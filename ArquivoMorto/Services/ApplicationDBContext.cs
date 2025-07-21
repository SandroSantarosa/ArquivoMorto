using ArquivoMorto.Models;
using Microsoft.EntityFrameworkCore;

namespace ArquivoMorto.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDBContext()
        {
        }

        public DbSet<Usuario> Usuario { get; set; } = null!;
        public DbSet<Perfil> Perfil { get; set; } = null!;
        public DbSet<Filial> Filial { get; set; } = null!;
        public DbSet<ArqMorto> ArqMorto { get; set; } = null!;
    }
}
