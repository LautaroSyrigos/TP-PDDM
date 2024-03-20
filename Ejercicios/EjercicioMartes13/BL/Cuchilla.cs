using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Cuchilla : Arma
    {
        private bool preparada = true;

        public override bool Preparada
        {
            get { return preparada; }
        }

        public override void Matar()
        {
            if (Preparada)
            {
                ensangrentada = true;
                preparada = false;
            }
        }

        public override object Clone()
        {
            return new Cuchilla
            {
                Nombre = this.Nombre,
                preparada = this.preparada
            };
        }

        /*
        public override bool Preparada
        {
            get { return true; }
        }

        public override void Matar()
        {
            base.Matar();
            if (Ensangrentada)
            {
                Preparada = false;
            }
        }*/
    }
}
