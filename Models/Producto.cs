using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCG_Net_Challenge.Models
{
    public class Producto
    {
        [Key]
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
    }
}
