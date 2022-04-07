using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using I9site.Models;

namespace I9site.Controllers
{
    public class OrcamentosController:Controller
    {
        
        
    //INSERIR
        public IActionResult Inserir()
        {
            return RedirectToAction("Confirmacao","Index");
        }
       
    //EDITAR
        
        public IActionResult Editar()
        {
            return RedirectToAction("Listagem");
    
        }
    //LISTAR


    //EXCLUIR
    public IActionResult Excluir()
        {
            return RedirectToAction("Listagem");
    
        }
    }

     
}