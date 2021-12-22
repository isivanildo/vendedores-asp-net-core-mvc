using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendedoresWebMvc.Models
{
    public class VendedoresWebMvcContext : DbContext
    {
        public VendedoresWebMvcContext (DbContextOptions<VendedoresWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<VendedoresWebMvc.Models.Departamentos> Departamentos { get; set; }
    }
}
