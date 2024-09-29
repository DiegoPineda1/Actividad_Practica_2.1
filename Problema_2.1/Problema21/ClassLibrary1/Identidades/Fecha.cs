using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackFecha.Identidades
{
    public class Fecha
    {
        public DateTime fechaHoy { get; set; }
        public Fecha()
        {
            fechaHoy = DateTime.Now;
        }
        
    }
}
