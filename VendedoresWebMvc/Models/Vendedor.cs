using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendedoresWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public  Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<VendaRegistro> VendasReg { get; set; } = new List<VendaRegistro>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(VendaRegistro vr)
        {
            VendasReg.Add(vr);
        }

        public void RemoverVendas(VendaRegistro vr)
        {
            VendasReg.Remove(vr);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return VendasReg.Where(vr => vr.Data >= inicial && vr.Data <= final).Sum(vr => vr.Montante);
        }

    }
}
