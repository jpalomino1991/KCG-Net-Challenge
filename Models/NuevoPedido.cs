using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCG_Net_Challenge.Models
{
    public class NuevoPedido
    {
        public List<Cliente> cliente { get; set; }
        public List<Producto> producto { get; set; }
    }
}
