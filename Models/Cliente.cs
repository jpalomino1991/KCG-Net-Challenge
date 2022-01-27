using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KCG_Net_Challenge.Models
{
    public class Cliente
    {
        [Key]
        public Guid Codigo{ get; set; }
        public String NombreCompleto { get; set; }
        public String Dni { get; set; }
    }
}
