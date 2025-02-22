using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Entities;

namespace tech_test_payment_api.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) :
            base(options)
        {
        }

         public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }

     
      
}
}
