using ProjetoModeloDDD.Domain.Entities;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IEFCoreRepository<Produto>
    {
        Task<Produto[]> GetAllProdutos();
        Task<Produto> GetProdutoById(int id);
        Task<Produto[]> GetProdutosByNome(string nome);
    }
}
