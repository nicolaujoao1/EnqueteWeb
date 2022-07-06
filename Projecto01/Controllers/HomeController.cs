using Microsoft.AspNetCore.Mvc;
using Projecto01.Models;

namespace Projecto01.Controllers;
public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View();
    }
    public IActionResult Resultado()
    {
        return View(Repositorio.Respostas);
    }
    [HttpGet]
    public IActionResult Responder()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Responder(Resposta resposta)
    {
        if (ModelState.IsValid)
        {
            Repositorio.AdicionarResposta(resposta);
            return View("Agradecer");
        }
        else
        {
            return View(resposta);
        }
    }
}
