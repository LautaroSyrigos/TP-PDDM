using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace EjercicioExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Este método se ejecuta cuando se hace clic en el botón button1_Click en el formulario. Crea una 
        /// instancia de la clase Colectivo. Intenta convertir el contenido del campo de texto Text_CantidadPasajeros 
        /// a un número entero(int CantidadPasajeros). Invoca el método CargarPasajeros del objeto colectivo con la 
        /// cantidad de pasajeros ingresada. Si se lanza una excepción de tipo ArgumentException, captura esa 
        /// excepción y muestra un mensaje de error al usuario utilizando MessageBox. Si ocurre cualquier otra 
        /// excepción, se captura en el bloque catch (Exception ex) y muestra un mensaje genérico de error al 
        /// usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Colectivo colectivo = new Colectivo();

            try
            {
                int CantidadPasajeros = Convert.ToInt32(Text_CantidadPasajeros.Text);
                colectivo.CargarPasajeros(CantidadPasajeros);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error al subir pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Acaba de ocurrir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
