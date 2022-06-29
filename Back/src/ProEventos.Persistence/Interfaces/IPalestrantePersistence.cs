using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Iterfaces
{
    public interface IEventosPersistence
    {
        //Events
        Task<Evento[]> GetAllEventosByTemasAsync(string tema, bool includePalestrante);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrante );
        Task<Evento> GetAllEventoByIdAsync(int EventoId, bool includePalestrante);
    }
}   