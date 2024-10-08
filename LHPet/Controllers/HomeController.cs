using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instanciar o objeto 
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "123.456.789-00", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "987.654.321-00", "william.henry@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "543.123.789-00", "ada.lovelace@sesi.br", "Byron");
        Cliente cliente4 = new Cliente(04, "Sheila F S da Hora", "022.899.755-02", "sheilafernanda7@gmail.com", "Loky");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);

        ViewBag.listaClientes = listaClientes;
        

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102.0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Java PET LTDA", "00.000.000/0001-00", "java@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "Python PET INC", "11.111.111/0001-11", "python@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "Use Girls Store", "222.777.777-58", "usegirlstore@gmail.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
ViewBag.listaFornecedores = listaFornecedores;




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
