using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T entity) where T: class;
        Task<bool> saveChangesAsync();

        //Events
        Task<Evento[]> GetAllEventosByTemasAsync(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosAsync(string tema, bool includePalestrante );
        Task<Evento> GetAllEventoByIdAsync(int EventoId, bool includePalestrante);

        //Palestrante
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(string tema, bool includeEventos );
        Task<Palestrante> GetAllPalestranteByIdAsync(int PalestranteId, bool includeEventos);

    }
}