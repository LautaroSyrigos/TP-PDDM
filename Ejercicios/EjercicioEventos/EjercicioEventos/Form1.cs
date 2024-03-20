using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace EjercicioEventos
{
    public partial class Form1 : Form
    {
        Curso Curso =new Curso();
        public Form1()
        {
            InitializeComponent();
            //GRILLA NO, EN EL FORMULARIO.
        }

        //En el evento Load, se configura una grilla(GrillaAlumnos) con columnas para mostrar información
        //de los alumnos.
        void ConfigurarGrilla()
        {
            GrillaAlumnos.Columns.Add("Legajo", "Legajo");
            GrillaAlumnos.Columns.Add("Nombre", "Nombre");
            GrillaAlumnos.Columns.Add("Horas estudiadas", "Horas estudiadas");
            GrillaAlumnos.Columns.Add("Nota final", "Nota final");
        }

        //El método CargarAlumnos agrega alumnos al curso con diferentes cantidades de horas de estudio
        //y actualiza la grilla.
        void CargarAlumnos()
        {
            Curso.AgregarAlumno(new Alumno("464644", "Roman", 15));
            Curso.AgregarAlumno(new Alumno("135445", "Carlos", 25));
            Curso.AgregarAlumno(new Alumno("312535", "Tucson", 60));
            Curso.AgregarAlumno(new Alumno("654654", "Dread", 2));
            Curso.AgregarAlumno(new Alumno("879976", "Gerson", 90));
            Curso.AgregarAlumno(new Alumno("134144", "Fabiola", 15));
            Curso.AgregarAlumno(new Alumno("989696", "Beto", 40));
            Curso.AgregarAlumno(new Alumno("451553", "Louis", 21));
            Curso.AgregarAlumno(new Alumno("546436", "Salazar", 35));
            Curso.AgregarAlumno(new Alumno("765765", "Virginia", 15));
            ActualizarGrilla();
        }

        //El método ActualizarGrilla actualiza la grilla con la información de los alumnos del curso.
        void ActualizarGrilla()
        {
            GrillaAlumnos.Rows.Clear();
            foreach(var alumno in Curso.AlumnosList)
            {
                GrillaAlumnos.Rows.Add(alumno.Legajo,alumno.Nombre,alumno.HorasEstudio,alumno.NotaFinal);
                //(EXTRA) GrillaAlumnos.Rows.Add(alumno.Legajo, alumno.Nombre, alumno.HorasEstudio, alumno.MostrarNota ? alumno.NotaFinal.ToString() : "Sin mostrar");
            }
        }

        //Al hacer clic en el botón Boton_TomarExamen, se toma el examen del curso, se actualiza la grilla y
        //se evalúa la nota final de los alumnos.
        private void Boton_TomarExamen_Click(object sender, EventArgs e)
        {
            Curso.TomarExamen();
            ActualizarGrilla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarAlumnos();
        }
    }
}
