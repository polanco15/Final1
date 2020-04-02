using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Final2.Models
{
    public class FinalContext : DbContext
    {
        public FinalContext()
            :base("Cadena1")
        {}
        public DbSet<Producto> Productoes { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}