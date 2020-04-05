using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final2.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }
        public string BusquedaActual { get; set; }

    }
    //public class ProductoProveedor
    //{
    //    public int ProductoId { get; set; }
    //    public int ProveedorId { get; set; }
    //    public Producto Producto { get; set; }
    //    public Proveedor Proveedor { get; set; }
    //}
}