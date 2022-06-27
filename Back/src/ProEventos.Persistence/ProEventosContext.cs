using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class ProEventosContext : DbContext
    {
        public ProEventosContext(DbContextOptions<ProEventosContext> options): base(options)
        {

        }
        public DbSet<Evento> Eventos { get; set; } = default!;
        public DbSet<Lote> Lotes { get; set; } = default!;
        public DbSet<Palestrante> Palestrante { get; set; } = default!;
        public DbSet<RedeSocial> RedeSociais { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PalestranteEvento>().HasKey(PE => new {PE.EventoId, PE.PalestranteId});
        }
    }   
}