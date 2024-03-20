using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Enemigo
    {
        public string Nombre { get; }
        public int Nivel { get; set; }
        public int Ataque { get; set; }
        public int Resistencia { get; set; }
        public int Salud { get; internal set; }
        
        public Enemigo(string param_Nombre)
        {
            Nombre = param_Nombre;
            Salud = 100;
        }
        
        public Enemigo(string param_Nombre, int Param_Salud):this(param_Nombre) 
        {
            Salud += Param_Salud;
        }
    
        public void RecibirDaño(int Intensidad)
        {
            int Daño = Intensidad - Resistencia;

            if (Daño > 0)
            {
                Salud -= Daño;
                
                if(Salud < 0)
                {
                    Salud = 0;
                }
            }
        }
    }
}
