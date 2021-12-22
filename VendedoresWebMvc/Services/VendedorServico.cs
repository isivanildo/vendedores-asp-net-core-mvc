using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendedoresWebMvc.Models;

namespace VendedoresWebMvc.Services
{
    public class VendedorServico
    {
        private readonly VendedoresWebMvcContext _context;

        public VendedorServico(VendedoresWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Inserir(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Vendedor FindById(int id)
        {
            return _context.Vendedor.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }
    }
}
