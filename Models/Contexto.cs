using Microsoft.EntityFrameworkCore;

namespace ProjetoApi.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Pessoa>? Pessoa { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Observacoes>? Observacoes { get; set; }
      
    }
}
