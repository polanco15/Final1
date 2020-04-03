using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Final2.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
           ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public string Email { get; set; }
    }
}