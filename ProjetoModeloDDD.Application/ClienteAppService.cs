using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : EFCoreAppService<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public Task<IEnumerable<Cliente>> GetAllClientes()
        {
            return _clienteService.GetAllClientes();
        }

        public Task<Cliente> GetClienteById(int id)
        {
            return _clienteService.GetClienteById(id);
        }

        public Task<IEnumerable<Cliente>> GetClientesByNome(string nome)
        {
            return _clienteService.GetClientesByNome(nome);
        }

        public async Task<IEnumerable<Cliente>> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(await _clienteService.GetAllClientes());
        }
    }
}
