using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IEFCoreService<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<bool> SaveChangeAsync();
    }
}
