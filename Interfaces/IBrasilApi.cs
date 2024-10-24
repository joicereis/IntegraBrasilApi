using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscaEnderecoPorCep(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscaTodosOsBancos();
        Task<ResponseGenerico<BancoModel>> BuscaBancoPorCodigo(string codigo);
    }
}
