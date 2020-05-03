using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext  //Encapsula os dados no DbContext, com as 3 entidades
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
       
        }

        public DbSet<Department> Department { get; set; } //DbSet Departamento
        public DbSet<Seller> Seller { get; set; }         //DbSet Vendedor
        public DbSet<SalesRecord> SalesRecords { get; set; } // DbSet Registro de Vendas
    }
}
