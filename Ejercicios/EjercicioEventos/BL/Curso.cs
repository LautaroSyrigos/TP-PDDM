using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //Contiene una lista de alumnos (AlumnosList) y métodos para agregar alumnos (AgregarAlumno)
    //y tomar el examen (TomarExamen).
    public class Curso
    {
        public List<Alumno> AlumnosList = new List<Alumno> ();

        //Define un evento ExamenTomado del tipo EventHandler que se invoca al tomar el examen.
        public event EventHandler ExamenTomado;

        //Al agregar un alumno, se añade a la lista y se suscribe el método RendirExamen del alumno
        //al evento ExamenTomado.
        public void AgregarAlumno(Alumno param_Alumno)
        {
            AlumnosList.Add(param_Alumno);
            ExamenTomado += param_Alumno.RendirExamen;
        }

        public void TomarExamen()
        {
            ExamenTomado?.Invoke(this,EventArgs.Empty);// null = EventsArgs.Empty 
            // Aquí se está verificando si ExamenTomado no es nulo 
            // antes de invocar el evento. Si ExamenTomado tiene al menos un manejador de eventos
            // suscrito, entonces Invoke() se ejecuta, lo que desencadena la ejecución de todos los métodos de
            // manejo de eventos suscritos al evento ExamenTomado.
        }
    }
}
