using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers;

public class HomeController : Controller
{
    private IPedidoRepository _pedidoRepository;

    public HomeController(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    //public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
    public IActionResult Index()
    {
        var pedido = _pedidoRepository.ObterPedido();

        return View();
    }
}
