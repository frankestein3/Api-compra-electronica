using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace compraElectronica.Models
{
    public class Pedido
    {
        [Key]
        public int id_pedido { get; set; }
        public int id_cliente { get; set; }
        public string fecha { get; set; }
    }
}
