using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    namespace StarWars// 5) Implemente al menos un namespace propio para agrupar las clases Nave y Flota
    {
        public class Nave
        {
            // 6) Utilice al menos 3 regiones en alguna clase
            #region Propiedades
            // 1) Nave tendrá los atributos TipoNave (de un tipo enumerado {XWing, Millenium, HomeOne},
            // ConArmamento(boolean) y Atacando(boolean, lectura pública y escritura dentro del mismo assembly)

            public enum TipoNave { XWing, Millenium, HomeOne }
            public TipoNave _TipoNave { get; }
            public bool ConArmamento { get; set; }
            public bool Atacando { get; internal set; }
            #endregion

            #region Constructor
            // 4) Nave tendrá un solo constructor con un parámetro con el tipo de nave. La propiedad TipoNave será
            // de solo lectura
            public Nave(TipoNave param_TipoNave)
            {
                _TipoNave = param_TipoNave;
            }
            #endregion

            #region Metodo
            public void Atacar()
            {
                if (ConArmamento)
                {
                    Atacando = true;
                }
            }
            #endregion
        }
    }
}
