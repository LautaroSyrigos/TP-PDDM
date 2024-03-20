using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //Contiene una lista de alumnos(alumnoList) y métodos para agregar alumnos(AgregarAlumnos)
    //y tomar el examen(TomarExamen).
    public class Curso
    {
        //Define un delegate ExamenDelegate y un evento ExamenTomado que se invoca al tomar el examen.
        public delegate void ExamenDelegate();
        public event ExamenDelegate ExamenTomado;

        public List<Alumno> alumnoList=new List<Alumno>();

        public void AgregarAlumnos(Alumno alumno)
        {
            alumnoList.Add(alumno);
        }

        //Al tomar el examen, invoca el evento ExamenTomado y evalúa a cada alumno en la lista.
        public void TomarExamen()
        {
            ExamenTomado?.Invoke();//SUSCRIPCION

            foreach (var param_Alumno in alumnoList)
            {
                param_Alumno.RendirExamen();
            }
        }
    }
} 
