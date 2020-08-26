using ProjetoModeloDDD.Domain.Entities;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IEFCoreRepository<Cliente>
    {
        Task<Cliente[]> GetAllClientes();
        Task<Cliente> GetClienteById(int id);
        Task<Cliente[]> GetClientesByNome(string nome);
    }
}
