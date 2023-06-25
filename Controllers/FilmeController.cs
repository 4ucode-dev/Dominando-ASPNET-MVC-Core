using Microsoft.AspNetCore.Mvc;

namespace MinhaDemoMvc.Controllers;

public class FilmeController : Controller
{
    [HttpGet]
    public IActionResult Adicionar()
    {
        return View();
    }
}
