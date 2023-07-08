using Microsoft.AspNetCore.Mvc;
using WebContas.Interfaces;

namespace WebContas.Controllers;

public class ContaController : Controller
{
    private readonly IContasApi _contasApi;

    public ContaController(IContasApi contasApi) => (_contasApi) = (contasApi);

    public async Task<IActionResult> ListarContas()
    {
        var response = await _contasApi.BuscarTodasContas();

        var contas = response.DadosRetorno;

        return View(contas);
    }
}
