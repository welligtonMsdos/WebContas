using Microsoft.AspNetCore.Mvc;
using WebContas.Interfaces;

namespace WebContas.Controllers;

public class CategoriaController : Controller
{
    private readonly IContasApi _contasApi;

    public CategoriaController(IContasApi contasApi) => (_contasApi) = (contasApi);

    public async Task<IActionResult> ListarCategorias()
    {
        var response = await _contasApi.BuscarTodasCategorias();

        var categorias = response.DadosRetorno;

        return View(categorias);
    }
}
