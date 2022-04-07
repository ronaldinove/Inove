using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using I9site.Models;

namespace I9site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Isso é um alerta. Controller/Index");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult SobreNos()
        {
            return View();
        }

        public IActionResult Produtos()
        {
            return View();
        }

        public IActionResult Orcamento ()
        {
            return Confirmacao();
        }

        public IActionResult Confirmacao()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    

        [HttpPost]
        public IActionResult Cadastrar(Orcamento o)
        {
            try
            {
                OrcamentoService os = new OrcamentoService();
                os.Inserir(o);
                return Json(new {status="OK"});
            
            }catch(Exception e){
                
                _logger.LogError("Erro global: " + e.Message);
                return Json(new {status="ERRO",mensagem="Falha ao gravar os dados! Tente novamente mais tarde."});
            }
        }
     
    }
}
