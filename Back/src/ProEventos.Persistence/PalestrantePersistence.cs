
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
namespace ProEventos.Persistence.Iterfaces
{
    public class PalestrantePersistence : IPalestrantePersistence
    {
        private readonly ProEventosContext _context;
        public PalestrantePersistence(ProEventosContext context)
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

        public async Task<Evento>  GetAllEventoByIdAsync(int EventoId, bool includePalestrante = false)
        {
            IQueryable<Evento> query = _context.Eventos.Include(e => e.Lotes).Include(e => e.RedeSociais);
            
            if(includePalestrante)
            {
                query = query.Include(e => e.PalestranteEvento).ThenInclude(pe => pe.Palestrante);
            }
            query = query.OrderBy(e => e.Id).Where(e => e.Id == EventoId);
            return await query.FirstOrDefaultAsync();
            
        }

        


        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrante.Include(p => p.RedeSociais);
            
            if(includeEventos)
            {
                query = query.Include(p => p.PalestranteEventos).ThenInclude(pe => pe.Evento);
            }
            query = query.OrderBy(p => p.Id);
            return await query.ToArrayAsync();
        }
        public async Task<Palestrante> GetAllPalestranteByIdAsync(int PalestranteId, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrante.Include(p => p.RedeSociais);
            
            if(includeEventos)
            {
                query = query.Include(p => p.PalestranteEventos).ThenInclude(pe => pe.Evento);
            }
            query = query.OrderBy(p => p.Id).Where(p => p.Id == PalestranteId);
            return await query.FirstOrDefaultAsync();
        }

        public  async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrante.Include(p => p.RedeSociais);
            
            if(includeEventos)
            {
                query = query.Include(p => p.PalestranteEventos).ThenInclude(pe => pe.Evento);
            }
            query = query.OrderBy(p => p.Id).Where(p => p.Name.ToLower().Contains(nome.ToLower()));
            return await query.ToArrayAsync();
        }

        
    }
}