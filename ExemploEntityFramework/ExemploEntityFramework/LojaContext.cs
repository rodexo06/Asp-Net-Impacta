using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ExemploEntityFramework
{
    public class LojaContext:DbContext
    {
        public LojaContext() : base(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = LojaExmplo; Integrated Security = True")
        {

        }
        //public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}