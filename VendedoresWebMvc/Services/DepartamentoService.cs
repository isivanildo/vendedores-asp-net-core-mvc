﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendedoresWebMvc.Models;

namespace VendedoresWebMvc.Services
{
    public class DepartamentoService
    {
        private readonly VendedoresWebMvcContext _context;

        public DepartamentoService(VendedoresWebMvcContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
