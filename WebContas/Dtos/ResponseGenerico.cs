using System.Dynamic;
using System.Net;

namespace WebContas.Dtos;

public class ResponseGenerico<T>
{
    public HttpStatusCode CodigoHttp { get; set; }

    public T[]? DadosRetorno { get; set; }
    public ExpandoObject? ErroRetorno { get; set; }
}
