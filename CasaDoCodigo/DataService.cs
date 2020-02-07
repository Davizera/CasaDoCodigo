using CasaDoCodigo.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    public partial class Startup
    {
        class DataService : IDataService
        {
            private readonly AplicationContext context;
            private readonly IProdutoRepository produtoRepository;

            public DataService(AplicationContext context, IProdutoRepository produtoRepository)
            {
                this.context = context;
                this.produtoRepository = produtoRepository;
            }

            public void InicializaDB()
            {
                this.context.Database.EnsureCreated();
                List<Livro> livros = GetLivros();
                produtoRepository.SaveProducts(livros);
            }

            private static List<Livro> GetLivros()
            {
                var json = File.ReadAllText("livros.json");
                var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
                return livros;
            }
        }
    }
}
