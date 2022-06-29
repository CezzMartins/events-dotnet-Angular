
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
namespace ProEventos.Persistence.Iterfaces
{
    public class EventoPersistence : IEventosPersistence
    {
        private readonly ProEventosContext _context;
        public EventoPersistence(ProEventosContext context)
        {
            this._context = context;

        }
        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrante = false)
        {
            IQueryable<Evento> query = _context.Eventos.Include(e => e.Lotes).Include(e => e.RedeSociais);
            
            if(includePalestrante)
            {
                query = query.Include(e => e.PalestranteEvento).ThenInclude(pe => pe.Palestrante);
            }
            query = query.OrderBy(e => e.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventosByTemasAsync(string tema, bool includePalestrante = false)
        {
            IQueryable<Evento> query = _context.Eventos.Include(e => e.Lotes).Include(e => e.RedeSociais);
            
            if(includePalestrante)
            {
                query = query.Include(e => e.PalestranteEvento).ThenInclude(pe => pe.Palestrante);
            }
            query = query.OrderBy(e => e.Id).Where(e => e.Tema.ToLower().Contains(tema.ToLower()));
            return await query.ToArrayAsync();
        }

        public async Task<Evento> GetAllEventoByIdAsync(int EventoId, bool includePalestrante = false)
        {
            IQueryable<Evento> query = _context.Eventos.Include(e => e.Lotes).Include(e => e.RedeSociais);
            
            if(includePalestrante)
            {
                query = query.Include(e => e.PalestranteEvento).ThenInclude(pe => pe.Palestrante);
            }
            query = query.OrderBy(e => e.Id).Where(e => e.Id == EventoId);
            return await query.FirstOrDefaultAsync();
            
        }        
    }
}