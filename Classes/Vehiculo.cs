using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVehiculos.Classes
{
    public class Vehiculo
    {
        public virtual int Id { get; set; }
        public virtual int IdMarca { get; set; }
        public virtual String Patente { get; set; }
        public virtual String NroMotor { get; set; }
        public virtual String NroChasis { get; set; }
        public virtual int ValorComercial { get; set; }
        public virtual bool TieneRastreador { get; set; }

    }
}
