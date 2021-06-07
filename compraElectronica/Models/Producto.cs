using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace compraElectronica.Models
{
    public class Producto
    {
        [Key]
        public int id_producto { get; set; }

        public string nombre { get; set; }

        public string precio { get; set; }

       

    }
}
