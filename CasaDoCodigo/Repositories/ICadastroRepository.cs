using CasaDoCodigo.Models;

namespace CasaDoCodigo
{
    public interface ICadastroRepository
    {
        Cadastro Update(int cadastroId, Cadastro novoCadastro);
    }
}