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

namespace EjercicioPropiedadesConstructoresMetodosGrilla
{
    public partial class Form1 : Form
    {
        List<Enemigo> List_Enemigos = new List<Enemigo>();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrilla();
            CargarEnemigos();
        }

        private void ConfigurarGrilla()
        {
            GrillaDeEnemigos.Columns.Add("Nombre", "Nombre");
            GrillaDeEnemigos.Columns.Add("Nivel", "Nivel");
            GrillaDeEnemigos.Columns.Add("Ataque", "Ataque");
            GrillaDeEnemigos.Columns.Add("Resistencia", "Resistencia");
            GrillaDeEnemigos.Columns.Add("Salud", "Salud");

            GrillaDeEnemigos.AllowUserToAddRows = false;//NO AGREGA MAS FILAS
            GrillaDeEnemigos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrillaDeEnemigos.MultiSelect = false;
            GrillaDeEnemigos.EditMode = DataGridViewEditMode.EditProgrammatically;//EVITA QUE SE EDITE LA GRILLA EN EL MOMENTO
        }

        private void CargarEnemigos()
        {
            List_Enemigos.Add(new Enemigo("Duende") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Orco") { Nivel = 10, Ataque = 50, Resistencia = 20 });
            List_Enemigos.Add(new Enemigo("Elfo Oscuro") { Nivel = 56, Ataque = 60, Resistencia = 40 });
            List_Enemigos.Add(new Enemigo("Demonio") { Nivel = 80, Ataque = 62, Resistencia = 53 });
            List_Enemigos.Add(new Enemigo("Araña Gigante") { Nivel = 101, Ataque = 110, Resistencia = 95 });
            List_Enemigos.Add(new Enemigo("Minotauro") { Nivel = 71, Ataque = 53, Resistencia = 62 });
            List_Enemigos.Add(new Enemigo("Esbirro") { Nivel = 15, Ataque = 23, Resistencia = 20 });
            List_Enemigos.Add(new Enemigo("Sucubo") { Nivel = 40, Ataque = 34, Resistencia = 21 });
            List_Enemigos.Add(new Enemigo("Dragon") { Nivel = 200, Ataque = 150, Resistencia = 110 });
            List_Enemigos.Add(new Enemigo("Fantasma") { Nivel = 25, Ataque = 16, Resistencia = 74 });

            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            GrillaDeEnemigos.Rows.Clear();
            foreach (var enemigo in List_Enemigos)
            {
                GrillaDeEnemigos.Rows.Add(enemigo.Nombre, enemigo.Nivel, enemigo.Ataque, enemigo.Resistencia, enemigo.Salud);
            }
        }

        private void GrillaDeEnemigos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            GrillaDeEnemigos.Columns.Add("Nombre","Nombre");
            //GrillaDeEnemigos.Columns["Nombre"].DataPropertyName= "Nombre";
            GrillaDeEnemigos.Columns.Add("Nivel", "Nivel");
            //GrillaDeEnemigos.Columns["Nivel"].DataPropertyName = "Nivel";
            GrillaDeEnemigos.Columns.Add("Ataque", "Ataque");
            //GrillaDeEnemigos.Columns["Ataque"].DataPropertyName = "Ataque";
            GrillaDeEnemigos.Columns.Add("Resistencia", "Resistencia");
            //GrillaDeEnemigos.Columns["Resistencia"].DataPropertyName = "Resistencia";
            GrillaDeEnemigos.Columns.Add("Salud", "Salud");
            //GrillaDeEnemigos.Columns["Salud"].DataPropertyName = "Salud";

            List_Enemigos.Add(new Enemigo("Duende") { Nivel = 5, Ataque = 10, Resistencia = 5});
            List_Enemigos.Add(new Enemigo("Orco") { Nivel = 10, Ataque = 50, Resistencia = 20 });
            List_Enemigos.Add(new Enemigo("Elfo Oscuro") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Demonio") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Araña Gigante") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Minotauro") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Esbirro") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Sucubo") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Dragon") { Nivel = 5, Ataque = 10, Resistencia = 5 });
            List_Enemigos.Add(new Enemigo("Fantasma") { Nivel = 5, Ataque = 10, Resistencia = 5 });

            Actualizar();
            */
        } //NO HAY NADA ACA

        private void BotonAtacarEnemigos_Click(object sender, EventArgs e)
        {
            if (GrillaDeEnemigos.SelectedRows.Count > 0)
            {
                Enemigo enemigo = List_Enemigos[GrillaDeEnemigos.SelectedRows[0].Index];
                enemigo.RecibirDaño(100);
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un enemigo para atacar.");
            }

            /*
            Enemigo enemigo = (Enemigo)GrillaDeEnemigos.SelectedRows[0].DataBoundItem;
            enemigo.RecibirDaño(10);
            */
        }
    }
}
