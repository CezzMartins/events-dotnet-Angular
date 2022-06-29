
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
namespace ProEventos.Persistence.Iterfaces
{
    public class GeralPersistence : IGeralPersistence
    {
        private readonly ProEventosContext _context;
        public GeralPersistence(ProEventosContext context)
        {
            this._context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T entityArrays) where T : class
        {
            _context.RemoveRange(entityArrays);
        }
        public async Task<bool> saveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        
    }
}