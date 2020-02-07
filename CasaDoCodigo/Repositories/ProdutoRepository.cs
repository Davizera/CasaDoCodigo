using CasaDoCodigo.Models;
using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AplicationContext context) : base(context)
        {
        }

        public IList<Produto> GetProducts()
        {
            return dbSet.ToList();
        }

        public void SaveProducts(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                if (!dbSet.Where(produto => produto.Codigo == livro.Codigo).Any())
                {
                    dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }
            }
            context.SaveChanges();
        }
    }

    public class Livro
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public decimal Preco { get; set; }

    }

}
