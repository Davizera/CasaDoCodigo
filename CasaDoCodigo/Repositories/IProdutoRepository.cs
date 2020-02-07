using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProducts(List<Livro> livros);
        IList<Produto> GetProducts();
    }
}