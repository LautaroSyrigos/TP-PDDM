using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumno
    {
        //Define la estructura de un estudiante con atributos como Nombre, Legajo, Nota, y HorasEstudio.
        public string Nombre { get; set; }
        public string Legajo { get; set; }
        public enum Nota { Aprobado, Desaprobado, Promocionado }
        public Nota _Nota { get; set; }
        public int HorasEstudio { get; set; }

        //El constructor Alumno recibe el nombre y el legajo del alumno.
        public Alumno(string param_Nombre, string param_Legajo)
        {
            Nombre= param_Nombre;
            Legajo= param_Legajo;
        }

        //El método RendirExamen evalúa las horas de estudio y asigna una nota según
        //las condiciones establecidas.
        public void RendirExamen()
        {
            if (HorasEstudio < 20)
            {
                _Nota = Nota.Desaprobado;
            }else if (HorasEstudio > 50)
            {
                _Nota = Nota.Promocionado;
            }
            else
            {
                _Nota = Nota.Aprobado;
            }
        }
    }
}
