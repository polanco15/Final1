using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final2.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public string Categoria { get; set; }
    }
}