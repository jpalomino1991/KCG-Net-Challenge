using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCG_Net_Challenge.Models
{
    public class Pedido
    {
        [Key]
        public Guid Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public String CodigoCliente { get; set; }
        public Decimal PrecioTotal { get; set; }
    }
}
