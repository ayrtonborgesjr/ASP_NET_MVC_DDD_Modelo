using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClienteService : EFCoreService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<Cliente[]> GetAllClientes()
        {
            return _clienteRepository.GetAllClientes();
        }

        public Task<Cliente> GetClienteById(int id)
        {
            return _clienteRepository.GetClienteById(id);
        }

        public Task<Cliente[]> GetClientesByNome(string nome)
        {
            return _clienteRepository.GetClientesByNome(nome);
        }
    }
}
