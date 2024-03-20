using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumno
    {
        //Define la estructura de un alumno con atributos como Nombre, Legajo, HorasEstudio, y NotaFinal.
        public string Nombre { get; }
        public string Legajo { get; }
        public enum Nota { Aprobado, Desaprobado, Promocionado }
        /* (EXTRA) public Nota NotaFinal //get; private set; con eso esta esto es EXTRA
        { 
            get
            {
                return MostrarNota ? NotaFinal : default;
                //(EXTRA)Si MostrarNota es false, retorna el valor default de Nota (Desaprobado en este caso)
            }
            private set
            {
                NotaFinal= value;//(EXTRA)Propiedad para controlar la visibilidad de la NotaFinal
            } 
        }*/
        public Nota NotaFinal { get; private set; }
        public int HorasEstudio { get; set; }

        // (EXTRA)public bool MostrarNota {  get; private set; }

        //El constructor Alumno recibe el nombre, legajo y horas de estudio del alumno.
        public Alumno(string nombre, string legajo, int horasEstudio)
        {
            Nombre = nombre;
            Legajo = legajo;
            HorasEstudio = horasEstudio;
            // (EXTRA) MostrarNota = false; //Al inicio, la nota está oculta (EXTRA)
        }

        //El método RendirExamen es un manejador de eventos (EventHandler) que evalúa las horas de estudio
        //y asigna una nota final al alumno.
        public void RendirExamen(object sender, EventArgs e)
        {
            if (HorasEstudio<20)
            {
                NotaFinal = Nota.Desaprobado;
            }
            else if (HorasEstudio>50)
            {
                NotaFinal = Nota.Promocionado;
            }
            else
            {
                NotaFinal = Nota.Aprobado;
            }

            //(EXTRA) MostrarNota = true; //Después de rendir el examen, se muestra la nota
        }
    }
}
