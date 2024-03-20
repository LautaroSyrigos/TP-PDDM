using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace EjercicioEventosConDelegates
{
    public partial class Form1 : Form
    {
        //En el evento Load, se inicializa el formulario y se configura una grilla (GrillaAlumnos) con columnas
        //para mostrar información de los alumnos.
        private Curso CursoList =new Curso();
        public Form1()
        {
            InitializeComponent();
        }

        //Se agregan varios alumnos al CursoList con diferentes cantidades de horas de estudio.
        private void Form1_Load(object sender, EventArgs e)
        {
            GrillaAlumnos.Columns.Add("Legajo", "Legajo");
            GrillaAlumnos.Columns.Add("Nombre", "Nombre");
            GrillaAlumnos.Columns.Add("Nota", "Nota");
            GrillaAlumnos.Columns.Add("HorasEstudio", "Horas de Estudio");

            //Se agregan varios alumnos al CursoList con diferentes cantidades de horas de estudio.
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 25 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 5 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 60 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 100 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 94 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 50 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 12 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 45 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 80 });
            CursoList.AgregarAlumnos(new Alumno("", "") { HorasEstudio = 30 });

            //Se suscribe el método Actualizar al evento ExamenTomado para actualizar la grilla cuando se
            //tome el examen.
            CursoList.ExamenTomado += Actualizar;
            Actualizar();
        }

        //El método Actualizar actualiza la grilla con la información de los alumnos del CursoList.
        void Actualizar()
        {
            GrillaAlumnos.Rows.Clear();
            foreach (var param_Alumno in CursoList.alumnoList)
            {
                GrillaAlumnos.Rows.Add(param_Alumno.Nombre, param_Alumno.Legajo,param_Alumno._Nota,param_Alumno.HorasEstudio);
            }
        }

        //Al hacer clic en el botón Boton_TomarExamen, se llama al método TomarExamen del CursoList.
        private void Boton_TomarExamen_Click(object sender, EventArgs e)
        {
            CursoList.TomarExamen();
        }
    }
}
