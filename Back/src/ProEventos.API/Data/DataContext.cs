using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Evento> Eventos { get; set; } = default!;
    }   
}