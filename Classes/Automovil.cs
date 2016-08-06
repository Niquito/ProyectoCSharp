using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVehiculos.Classes
{
    public class Automovil : Vehiculo
    {
        public virtual TipoVehiculo Tipo { get; set; }
        public virtual Boolean TieneAirbag { get; set; }
    }
}
