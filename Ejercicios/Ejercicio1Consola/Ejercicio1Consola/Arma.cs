using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Ejercicio1Consola
{
    public class Arma
    {
        public string NombreArma;
        public int MunicionActual;

        public Arma(string param_NombreArma) 
        {
            this.NombreArma = param_NombreArma;
            this.MunicionActual = 100;
        }

        public void Disparar()
        {
            if(MunicionActual > 0)
            {
                Console.WriteLine($" DISPARASTE TU {NombreArma}, MUNICION RESTANTE {--MunicionActual}");
            }
            else
            {
                Console.WriteLine($" YA NO TE QUEDA MUNICION {NombreArma}");
            }
        }
    }
}
