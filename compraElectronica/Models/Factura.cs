using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace compraElectronica.Models
{
    public class Factura
    {
        [Key]
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public int id_pedido { get; set; }
        
    }
}
