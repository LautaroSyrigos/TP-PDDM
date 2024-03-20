using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Machete : Arma
    {
        public override bool Preparada { get { return true; } }

        public override object Clone()//Punto 10
        {
            return new Machete
            {
                Nombre = this.Nombre
            };
        }
    }
}
