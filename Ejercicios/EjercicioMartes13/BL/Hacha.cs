//Punto 10using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Hacha : Arma
    {
        public bool Afilada { get; set; }

        public override bool Preparada
        {
            get { return Afilada; }
        }

        public override object Clone()//Punto 10
        {
            return new Hacha
            {
                Nombre = this.Nombre,
                Afilada = this.Afilada
            };
        }
    }
}
