using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendedoresWebMvc.Models;
using VendedoresWebMvc.Models.Enum;

namespace VendedoresWebMvc.Data
{
    public class SeedingService
    {
        private VendedoresWebMvcContext _context;

        public SeedingService(VendedoresWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.VendaRegistro.Any())
            {
                return;
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "Ivanildo", "ivanildo@gmail.com", new DateTime(1977, 10, 13), 7000.0, d1);
            Vendedor v2 = new Vendedor(2, "Renata", "renata@gmail.com", new DateTime(1993, 7, 24), 2400.0, d3);
            Vendedor v3 = new Vendedor(3, "Mariangela", "mariangela@gmail.com", new DateTime(2008, 8, 15), 2100.0, d3);
            Vendedor v4 = new Vendedor(4, "Arthur", "arthur@gmail.com", new DateTime(2017, 12, 2), 1800.0, d2);
            Vendedor v5 = new Vendedor(5, "Nicolas", "nicolas@gmail.com", new DateTime(2020, 1, 21), 1700.0, d4);
            Vendedor v6 = new Vendedor(6, "Rakel", "rakel@gmail.com", new DateTime(2012, 11, 20), 2600.0, d3);

            VendaRegistro r1 = new VendaRegistro(1, new DateTime(2021, 11, 10), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r2 = new VendaRegistro(2, new DateTime(2021, 11, 10), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r3 = new VendaRegistro(3, new DateTime(2021, 11, 10), 14000.0, VendaStatus.Pendente, v2);
            VendaRegistro r4 = new VendaRegistro(4, new DateTime(2021, 11, 13), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r5 = new VendaRegistro(5, new DateTime(2021, 11, 10), 11000.0, VendaStatus.Pendente, v2);
            VendaRegistro r6 = new VendaRegistro(6, new DateTime(2021, 11, 13), 14000.0, VendaStatus.Pendente, v1);
            VendaRegistro r7 = new VendaRegistro(7, new DateTime(2021, 11, 14), 18000.0, VendaStatus.Faturado, v1);
            VendaRegistro r8 = new VendaRegistro(8, new DateTime(2021, 11, 10), 11000.0, VendaStatus.Faturado, v4);
            VendaRegistro r9 = new VendaRegistro(9, new DateTime(2021, 11, 10), 9000.0, VendaStatus.Pendente, v1);
            VendaRegistro r10 = new VendaRegistro(10, new DateTime(2021, 12, 18), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r11 = new VendaRegistro(11, new DateTime(2021, 11, 10), 11000.0, VendaStatus.Faturado, v3);
            VendaRegistro r12 = new VendaRegistro(12, new DateTime(2021, 11, 8), 1000.0, VendaStatus.Cancelado, v3);
            VendaRegistro r13 = new VendaRegistro(13, new DateTime(2021, 11, 8), 11500.0, VendaStatus.Faturado, v1);
            VendaRegistro r14 = new VendaRegistro(14, new DateTime(2021, 11, 9), 11000.0, VendaStatus.Cancelado, v6);
            VendaRegistro r15 = new VendaRegistro(15, new DateTime(2021, 12, 10), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r16 = new VendaRegistro(16, new DateTime(2021, 11, 10), 12050.0, VendaStatus.Faturado, v5);
            VendaRegistro r17 = new VendaRegistro(17, new DateTime(2021, 11, 3), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r18 = new VendaRegistro(18, new DateTime(2021, 12, 2), 12000.0, VendaStatus.Faturado, v1);
            VendaRegistro r19 = new VendaRegistro(19, new DateTime(2021, 11, 3), 11000.0, VendaStatus.Pendente, v2);
            VendaRegistro r20 = new VendaRegistro(20, new DateTime(2021, 11, 12), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r21 = new VendaRegistro(21, new DateTime(2021, 12, 10), 13000.0, VendaStatus.Faturado, v6);
            VendaRegistro r22 = new VendaRegistro(22, new DateTime(2021, 12, 10), 11000.0, VendaStatus.Pendente, v5);
            VendaRegistro r23 = new VendaRegistro(23, new DateTime(2021, 11, 11), 22000.0, VendaStatus.Faturado, v1);
            VendaRegistro r24 = new VendaRegistro(24, new DateTime(2021, 11, 10), 11000.0, VendaStatus.Pendente, v6);
            VendaRegistro r25 = new VendaRegistro(25, new DateTime(2021, 12, 10), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r26 = new VendaRegistro(26, new DateTime(2021, 11, 10), 44000.0, VendaStatus.Faturado, v6);
            VendaRegistro r27 = new VendaRegistro(27, new DateTime(2021, 11, 11), 11000.0, VendaStatus.Faturado, v1);
            VendaRegistro r28 = new VendaRegistro(28, new DateTime(2021, 11, 10), 13000.0, VendaStatus.Faturado, v6);
            VendaRegistro r29 = new VendaRegistro(29, new DateTime(2021, 12, 19), 11000.0, VendaStatus.Cancelado, v1);
            VendaRegistro r30 = new VendaRegistro(30, new DateTime(2021, 11, 20), 10000.0, VendaStatus.Faturado, v1);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);

            _context.VendaRegistro.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15,
                r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();

        }
    }
}
