using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Nave
    {
        public enum TipoNave { XWing, Millenium, HomeOne }
        public bool ConArmamento { get;}
        public bool Atacando { get; internal set; }
    }
}
