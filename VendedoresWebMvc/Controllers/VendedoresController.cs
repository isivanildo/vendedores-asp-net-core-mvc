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
        private readonly VendedorServico _vendedorService;
        private readonly DepartamentoService _departamento;

        public VendedoresController(VendedorServico vendedor, DepartamentoService departamento)
        {
            _vendedorService = vendedor;
            _departamento = departamento;
        }
        public IActionResult Index()
        {
            var lista = _vendedorService.FindAll();
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
            _vendedorService.Inserir(vendedor);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _vendedorService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _vendedorService.Remove(id);

            return RedirectToAction(nameof(Index));
        }
    }
}