using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodBack_MVC_Arquivos_da_Atividade_Aluno.Models;

namespace CodBack_MVC_Arquivos_da_Atividade_Aluno.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        Cliente cliente1 = new Cliente(01, "Joao", "888.777.999-54", "xxxxx@gmail.com", "Xana");
        Cliente cliente2 = new Cliente(02, "Gabriel", "777.999.888-44", "xxxxx@gmail.com", "Nina");
        Cliente cliente3 = new Cliente(03, "Mayara", "784.346.475-48", "xxxxx@gmail.com", "Branquinho");
        Cliente cliente4 = new Cliente(04, "Roberta", "657.325.754-44", "xxxxx@gmail.com", "Anitta");
        Cliente cliente5 = new Cliente(05, "Alanis", "555.333.111-22", "xxxxx@gmail.com", "Belinha");

        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);

        ViewBag.listaCliente = listaCliente;

        Fornecedor fornecedor1 = new Fornecedor(01, "PetDream", "91.563.416/0001-73", "petdream@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Miaupet", "13.489.224/0001-50", "miaulpetm@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Petshow", "17.008.899/0001-91", "showpetm@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Dogmalvado", "81.015.714/0001-75", "dogmal@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Petlandia ", "50.109.939/0001-67", "paraisopet@gmail.com");
        List<Fornecedor> listaForcenedores = new List<Fornecedor>();
        listaForcenedores.Add(fornecedor1);
        listaForcenedores.Add(fornecedor2);
        listaForcenedores.Add(fornecedor3);
        listaForcenedores.Add(fornecedor4);
        listaForcenedores.Add(fornecedor5);

        ViewBag.listaForcenedores = listaForcenedores;


        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
