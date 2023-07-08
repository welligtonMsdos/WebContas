using System.Dynamic;
using System.Text.Json;
using WebContas.Dtos;
using WebContas.Interfaces;
using WebContas.Models;

namespace WebContas.Rest;

public class ContasApiRest : IContasApi
{
    public async Task<ResponseGenerico<Categoria>> BuscarTodasCategorias()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7182/Categoria");

        var response = new ResponseGenerico<Categoria>();

        using (var client = new HttpClient())
        {
            var responseCategoria = await client.SendAsync(request);

            var contentResp = await responseCategoria.Content.ReadAsStringAsync();           

            var objResponse = JsonSerializer.Deserialize<Categoria[]>(contentResp);

            response.CodigoHttp = responseCategoria.StatusCode;

            if (responseCategoria.IsSuccessStatusCode)
                response.DadosRetorno = objResponse;
            else
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
        }

        return response;
    }

    public async Task<ResponseGenerico<Conta>> BuscarTodasContas()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7182/Conta");

        var response = new ResponseGenerico<Conta>();

        using (var client = new HttpClient())
        {
            var responseConta = await client.SendAsync(request);

            var contentResp = await responseConta.Content.ReadAsStringAsync();

            var objResponse = JsonSerializer.Deserialize<Conta[]>(contentResp);

            response.CodigoHttp = responseConta.StatusCode;

            if (responseConta.IsSuccessStatusCode)
                response.DadosRetorno = objResponse;
            else
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
        }

        return response;
    }
}
