using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVehiculos.Classes
{
    public class Moto : Vehiculo
    {
        public virtual Boolean TieneMonoshock { get; set; }
        public virtual int CantidadCilindros { get; set; }
        public virtual int Cilindrada { get; set; }
    }
}
