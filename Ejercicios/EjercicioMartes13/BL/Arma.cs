using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class Arma : ICloneable, IComparable<Arma>
    {
        public abstract bool Preparada { get; }
        public string Nombre { get; set; }
        protected bool ensangrentada;
        public bool Ensangrentada
        {
            get { return ensangrentada; }
        }

        public virtual void Matar()
        {
            if (Preparada)
            {
                ensangrentada = true;
            }
        }

        public virtual object Clone()//Punto 10
        {
            return this.MemberwiseClone();
        }

        #region Punto 11
        public int CompareTo(Arma other)
        {
            if (other == null) return 1;

            if (this.Preparada && this.Ensangrentada)
            {
                if (other.Preparada && other.Ensangrentada)
                    return 0;
                else
                    return 1;
            }
            else
            {
                if (other.Preparada && other.Ensangrentada)
                    return -1;
                else
                    return 0;
            }
        }

        public static bool operator >(Arma a, Arma b)
        {
            return a.CompareTo(b) > 0;
        }

        public static bool operator <(Arma a, Arma b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator ==(Arma a, Arma b)
        {
            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(Arma a, Arma b)
        {
            return a.CompareTo(b) != 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return this == (Arma)obj;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Preparada, Ensangrentada, Nombre).GetHashCode();
        }
        #endregion
    }
}
