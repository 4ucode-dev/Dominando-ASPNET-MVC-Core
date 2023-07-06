using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Areas.Produtos.Controllers;

[Area("Produtos")]
[Route("Produtos/[controller]/[action]")]
public class CadastroController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
