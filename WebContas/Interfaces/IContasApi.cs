using WebContas.Dtos;
using WebContas.Models;

namespace WebContas.Interfaces;

public interface IContasApi
{
    Task<ResponseGenerico<Categoria>> BuscarTodasCategorias();
    Task<ResponseGenerico<Conta>> BuscarTodasContas();
}
