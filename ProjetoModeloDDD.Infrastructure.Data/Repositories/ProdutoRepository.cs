using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infrastructure.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : EFCoreRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProjetoModeloContext context) : base(context)
        {
        }

        //private readonly ProjetoModeloContext _context;

        //public ProdutoRepository(ProjetoModeloContext context) : base(context)
        //{
        //    _context = context;
        //}

        public async Task<Produto[]> GetAllProdutos()
        {
            IQueryable<Produto> query = _context.Produtos;
            query = query.AsNoTracking().OrderBy(h => h.ProdutoId);

            return await query.ToArrayAsync();
        }

        public async Task<Produto> GetProdutoById(int id)
        {
            IQueryable<Produto> query = _context.Produtos;

            return await query.AsNoTracking().FirstOrDefaultAsync(c => c.ProdutoId == id);
        }

        public async Task<Produto[]> GetProdutosByNome(string nome)
        {
            IQueryable<Produto> query = _context.Produtos;
            query = query.AsNoTracking().Where(h => h.Nome.Contains(nome)).OrderBy(h => h.ClienteId);

            return await query.ToArrayAsync();
        }
    }
}
