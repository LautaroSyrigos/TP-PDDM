using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    namespace StarWars// 5) Implemente al menos un namespace propio para agrupar las clases Nave y Flota
    {
        public class Flota
        {
            // 2) Flota encapsulará una colección de Naves. Expodrá un método Agregar que recibirá una Nave
            // y un método DeathStarDetectada que notificará a todas las Naves y pondrá a las que tengan
            // Armamento en modo Atacando.(utilice un delegate o evento, NO UTILICE foreach NI for)

            #region Propiedades
            List<Nave> List_Naves = new List<Nave>();

            public delegate void DeathStarDetectadaDelegate();
            DeathStarDetectadaDelegate DeathStarDetectada;

            public List<Nave> flota_Naves { get { return List_Naves; } }
            #endregion

            #region Metodos
            public void Agregar(Nave param_Nave)
            {
                List_Naves.Add(param_Nave);
                DeathStarDetectada += param_Nave.Atacar;
            }

            // 7) Agregar estará sobrecargado recibiendo en otra forma el tipo de nave solamente.
            public void Agregar(Nave.TipoNave param_Nave)
            {
                Nave nave = new Nave(param_Nave);
                nave.ConArmamento = false;
                List_Naves.Add(nave);
                DeathStarDetectada += nave.Atacar;
            }

            public void DetectarEstrellaDeLaMuerte()
            {
                if (DeathStarDetectada != null)
                {
                    DeathStarDetectada();
                }
            }
            #endregion
        }
    }
}
