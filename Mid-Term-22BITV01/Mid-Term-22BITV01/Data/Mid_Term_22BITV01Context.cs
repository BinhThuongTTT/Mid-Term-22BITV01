using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mid_Term_22BITV01.Models;

namespace Mid_Term_22BITV01.Data
{
    public class Mid_Term_22BITV01Context : DbContext
    {
        public Mid_Term_22BITV01Context (DbContextOptions<Mid_Term_22BITV01Context> options)
            : base(options)
        {
        }

        public DbSet<Mid_Term_22BITV01.Models.Department> Department { get; set; } = default!;
        public DbSet<Mid_Term_22BITV01.Models.Employee> Employee { get; set; } = default!;
    }
}
