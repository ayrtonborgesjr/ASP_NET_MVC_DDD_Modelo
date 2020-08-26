using ProjetoModeloDDD.Domain.Entities;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IEFCoreService<Produto>
    {
        Task<Produto[]> GetAllProdutos();
        Task<Produto> GetProdutoById(int id);
        Task<Produto[]> GetProdutosByNome(string nome);
    }
}
