using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace compraElectronica.Models
{
    public class Cliente
    {
        [Key]
        
        public int id_cliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }


    }
}
