using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.StarWars;

namespace EjercicioPreParcial1
{
    public partial class Form1 : Form
    {
        Flota List_Flotas = new Flota(); 

        public Form1()
        {
            InitializeComponent();
        }

        #region Metodos del formulario
        // 3) Muestre al menos cuatro naves en una Grilla y con un botón dispare.
        private void Form1_Load(object sender, EventArgs e)
        {
            List_Flotas.Agregar(new Nave(Nave.TipoNave.HomeOne) { ConArmamento = false });
            List_Flotas.Agregar(new Nave(Nave.TipoNave.XWing) { ConArmamento=true });
            List_Flotas.Agregar(new Nave(Nave.TipoNave.Millenium) { ConArmamento=false });
            Actualizar();
        }

        private void Boton_EstrellaDetectada_Click(object sender, EventArgs e)
        {
            List_Flotas.DetectarEstrellaDeLaMuerte();
            Actualizar();
        }
        #endregion

        #region Metodos
        void Actualizar()
        {
            Grilla_Flota.DataSource = null;
            Grilla_Flota.DataSource = List_Flotas.flota_Naves;
        }
        #endregion
    }
}
