using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Colectivo
    {
        /// <summary>
        /// Toma un parámetro de tipo entero cantidadPasajeros que representa la cantidad de pasajeros a cargar 
        /// en el colectivo. Verifica si la cantidad de pasajeros es mayor a 20. Si la cantidad es mayor a 20, 
        /// lanza una excepción de tipo ArgumentException con un mensaje indicando que se superó el límite de 
        /// pasajeros. Si la cantidad es aceptable (20 o menos), simuladamente carga los pasajeros en el 
        /// colectivo(en el ejemplo, simplemente muestra un mensaje en la consola).
        /// </summary>
        /// <param name="CantidadPasajeros"></param>
        /// <exception cref="ArgumentException"></exception>
        public void CargarPasajeros(int CantidadPasajeros)
        {
            if (CantidadPasajeros > 20)
            {
                throw new ArgumentException("LIMITE EXCEDIDO, el maximo son 20 pasajeros");
            }
            Console.WriteLine($"Se subieron {CantidadPasajeros} pasajeros al bondi.");
        }
    }
}
