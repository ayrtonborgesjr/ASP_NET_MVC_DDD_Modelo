using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IEFCoreRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<bool> SaveChangeAsync();
    }
}
