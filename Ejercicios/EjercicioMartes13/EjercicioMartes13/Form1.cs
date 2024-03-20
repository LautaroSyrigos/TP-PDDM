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

namespace EjercicioMartes13
{
    public partial class Form1 : Form
    {
        Establo _Establo = new Establo();
        // Crear una lista para almacenar la información de las armas
       // List<object> armasInfo = new List<object>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grilla_Armas.Columns.Add("Nombre", "Nombre");
            Grilla_Armas.Columns.Add("Preparada", "Preparada");
            Grilla_Armas.Columns.Add("Ensangrentada", "Ensangrentada");

            _Establo.Agregar(new Motosierra { Nombre = "Motosierra 1", NivelCombustible = 10 });
            _Establo.Agregar(new Motosierra { Nombre = "Motosierra 2", NivelCombustible = 0 });
            _Establo.Agregar(new Cuchilla { Nombre = "Cuchilla 1" });
            _Establo.Agregar(new Hacha { Nombre = "Hacha 1", Afilada = true });
            _Establo.Agregar(new Hacha { Nombre = "Hacha 2", Afilada = false });
            _Establo.Agregar(new Machete { Nombre = "Machete 1" });

            ActualizarGrilla();

            /*
            // Crear un establo y agregar algunas armas
            
            establo.Agregar(new Motosierra { Nombre = "Motosierra 1", NivelCombustible = 10 });
            establo.Agregar(new Motosierra { Nombre = "Motosierra 2", NivelCombustible = 0 });
            establo.Agregar(new Cuchilla { Nombre = "Cuchilla 1" });
            establo.Agregar(new Hacha { Nombre = "Hacha 1", Afilada = true });
            establo.Agregar(new Hacha { Nombre = "Hacha 2", Afilada = false });
            establo.Agregar(new Machete { Nombre = "Machete 1" });

            // Crear una lista para almacenar la información de las armas
            armasInfo = new List<object>();

            // Actualizar la grilla
            ActualizarGrilla();

            
            // Recorrer todas las armas en el establo
            foreach (Arma arma in establo)
            {
                // Agregar la información de la arma a la lista
                armasInfo.Add(new
                {
                    Nombre = arma.Nombre,
                    Preparada = arma.Preparada,
                    Ensangrentada = arma.Ensangrentada
                });
            }

            // Enlazar la lista con la grilla
            Grilla_Armas.DataSource = armasInfo;
            */
        }

        private void Boton_Usar_Click(object sender, EventArgs e)
        {
            /* Metodo anterior
            foreach (Arma a in _Establo)
            {
                a.Matar();
            }*/
            
            _Establo.ProbarArmas();//Punto 8
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            Grilla_Armas.Rows.Clear();
            foreach (Arma a in _Establo)
            {
                Grilla_Armas.Rows.Add(a.Nombre, a.Preparada, a.Ensangrentada);
            }

            /*
            // Limpiar la lista
            armasInfo.Clear();

            // Recorrer todas las armas en el establo
            foreach (Arma arma in establo)
            {
                // Agregar la información de la arma a la lista
                armasInfo.Add(new
                {
                    Nombre = arma.Nombre,
                    Preparada = arma.Preparada,
                    Ensangrentada = arma.Ensangrentada
                });
            }

            // Enlazar la lista con la grilla
            Grilla_Armas.DataSource = null;
            Grilla_Armas.DataSource = armasInfo;
            */
        }
    }
}