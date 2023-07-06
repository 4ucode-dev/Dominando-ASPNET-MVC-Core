using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Vendas.Controllers;

[Area("Vendas")]
[Route("pedidos")]
public class PedidosController : Controller
{
    [Route("lista")]
    public IActionResult Index()
    {
        return View();
    }
}
