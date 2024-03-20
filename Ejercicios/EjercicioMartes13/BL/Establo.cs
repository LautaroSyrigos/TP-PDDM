using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Establo : IEnumerable<Arma>, ICloneable
    {
        private List<Arma> armas = new List<Arma>();

        public void Agregar(Arma arma)
        {
            armas.Add(arma);
        }

        public IEnumerator<Arma> GetEnumerator()
        {
            #region Punto 12
            foreach (var arma in armas)
            {
                if (arma is Motosierra motosierra && motosierra.NivelCombustible == 0)
                {
                    var clon = (Motosierra)motosierra.Clone();
                    clon.Nombre += " [CARGAR]";
                    yield return clon;
                }
                else
                {
                    yield return arma;
                }
            }
            #endregion

            //version anterior
            //return armas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #region Punto 8
        public delegate void ProbarArmasDelegate();

        public void ProbarArmas()
        {
            ProbarArmasDelegate delegado = null;

            foreach (var arma in armas)
            {
                delegado += arma.Matar;
            }

            delegado?.Invoke();
        }
        #endregion

        #region Punto 9
        /// <summary>
        /// CantidadArmasPreparadas es una propiedad de solo lectura que usa la función Count() de LINQ para contar las armas en la lista armas que están preparadas. La expresión arma => arma.Preparada es una expresión lambda que se usa como predicado para Count(): selecciona las armas para las cuales Preparada es true.
        /// </summary>
        public int CantidadArmasPreparadas
        {
            get { return armas.Count(arma => arma.Preparada); }
        }
        #endregion

        #region Punto 10
        public object Clone()
        {
            Establo nuevoEstablo = new Establo();

            foreach (Arma arma in armas)
            {
                Arma armaClonada = (Arma)arma.Clone();
                nuevoEstablo.Agregar(armaClonada);
            }

            return nuevoEstablo;
        }
        #endregion
    }
}
