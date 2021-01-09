
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
