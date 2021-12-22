using System;
using System.Collections.Generic;
using System.Linq;
using VendedoresWebMvc.Models.Enum;

namespace VendedoresWebMvc.Models
{
    public class VendaRegistro
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Montante { get; set; }
        public VendaStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public VendaRegistro()
        {
        }

        public VendaRegistro(int id, DateTime data, double montante, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
