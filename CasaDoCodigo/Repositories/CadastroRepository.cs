using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(AplicationContext context) : base(context)
        {
        }
    }
}
