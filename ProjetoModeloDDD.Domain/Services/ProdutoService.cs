using ProjetoModeloDDD.Domain.Entities; 
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : EFCoreService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task<Produto[]> GetAllProdutos()
        {
            return _produtoRepository.GetAllProdutos();
        }

        public Task<Produto> GetProdutoById(int id)
        {
            return _produtoRepository.GetProdutoById(id);
        }

        public Task<Produto[]> GetProdutosByNome(string nome)
        {
            return _produtoRepository.GetProdutosByNome(nome);
        }
    }
}
