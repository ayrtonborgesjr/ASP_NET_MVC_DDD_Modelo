using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class EFCoreService<T> : IEFCoreService<T> where T : class
    {
        private readonly IEFCoreRepository<T> _repository;

        public EFCoreService(IEFCoreRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public Task<bool> SaveChangeAsync()
        {
            return _repository.SaveChangeAsync();
        }
    }
}
