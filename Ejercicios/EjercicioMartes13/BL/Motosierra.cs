using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Motosierra : Arma
    {
        public int NivelCombustible { get; set; }

        public override bool Preparada
        {
            get { return NivelCombustible > 0; }
        }

        public override object Clone()//Punto 10
        {
            return new Motosierra
            {
                Nombre = this.Nombre,
                NivelCombustible = this.NivelCombustible
            };
        }
    }
}
