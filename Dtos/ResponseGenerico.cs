using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno { get; set; } //em tempo de execução, essa propriedade recebe um objeto da API quando houver um erro
    }
}
