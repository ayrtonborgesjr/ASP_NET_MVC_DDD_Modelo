using ProjetoModeloDDD.Domain.Entities;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IEFCoreService<Cliente>
    {
        Task<Cliente[]> GetAllClientes();
        Task<Cliente> GetClienteById(int id);
        Task<Cliente[]> GetClientesByNome(string nome);
    }
}
