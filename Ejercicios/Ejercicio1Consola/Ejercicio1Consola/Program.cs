using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ESCRIBE EL NOMBRE PARA TU ARMA: ");
            string _NombreArma=Console.ReadLine();

            Arma _Arma = new Arma(_NombreArma);

            bool Continuar = true;

            while(Continuar)
            {
                Console.WriteLine("PULSA LA TECLA 'D' PARA DISPARAR, SI QUIERES SALIR PULSA LA TECLA 'S'");
                char Opcion = Console.ReadKey().KeyChar;
                #region EXTRA "NO ES NECESARIO"
                Console.WriteLine();
                Console.Clear();
                #endregion

                switch (Opcion)
                {
                    case 'D':
                    case 'd':
                        _Arma.Disparar();
                        break;
                    case 'S':
                    case 's':
                        Continuar = false;
                        break;
                    default:
                        Console.WriteLine("LA TECLA PULSADA NO ES VALIDA, POR FAVOR PULSE LAS CORRESPONDIENTES");
                        break;
                }
            }
        }
    }
}
