using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendedoresWebMvc.Services;

namespace VendedoresWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorServico _vendedor;

        public VendedoresController(VendedorServico vendedor)
        {
            _vendedor = vendedor;
        }
        public IActionResult Index()
        {
            var lista = _vendedor.FindAll();
            return View(lista);
        }
    }
}