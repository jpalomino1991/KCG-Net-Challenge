using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCG_Net_Challenge.Models
{
    public class DetallePedido
    {
        [Key]
        public String CodigoProducto { get; set; }
        public String Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public Decimal SubTotal { get; set; }
        public Guid CodigoPedido { get; set; }
    }
}
