using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Iterfaces
{
    public interface IPalestrantePersistence
    {

        //Palestrante
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos );
        Task<Palestrante> GetAllPalestranteByIdAsync(int PalestranteId, bool includeEventos);

    }
}