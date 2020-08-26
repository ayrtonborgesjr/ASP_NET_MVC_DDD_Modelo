using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infrastructure.Data.Context;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infrastructure.Data.Repositories
{
    public class EFCoreRepository<T> : IEFCoreRepository<T> where T : class
    {        
        protected ProjetoModeloContext _context;

        public EFCoreRepository(ProjetoModeloContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
