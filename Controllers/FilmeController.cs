﻿using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;

namespace MinhaDemoMvc.Controllers;

public class FilmeController : Controller
{
    [HttpGet]
    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar(Filme filme)
    {
        if (ModelState.IsValid)
        {

        }

        return View(filme);
    }
}
