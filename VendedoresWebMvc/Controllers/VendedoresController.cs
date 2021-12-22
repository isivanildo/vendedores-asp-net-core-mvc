using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendedoresWebMvc.Models;
using VendedoresWebMvc.Services;
using VendedoresWebMvc.Models.ViewModels;

namespace VendedoresWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorServico _vendedor;
        private readonly DepartamentoService _departamento;

        public VendedoresController(VendedorServico vendedor, DepartamentoService departamento)
        {
            _vendedor = vendedor;
            _departamento = departamento;
        }
        public IActionResult Index()
        {
            var lista = _vendedor.FindAll();
            return View(lista);
        }
        
        public IActionResult Create()
        {
            var departamentos = _departamento.FindAll();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedor.Inserir(vendedor);

            return RedirectToAction(nameof(Index));
        }
    }
}