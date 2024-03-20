namespace EjercicioPreParcial1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Boton_EstrellaDetectada = new System.Windows.Forms.Button();
            this.Grilla_Flota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Flota)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_EstrellaDetectada
            // 
            this.Boton_EstrellaDetectada.Location = new System.Drawing.Point(119, 239);
            this.Boton_EstrellaDetectada.Name = "Boton_EstrellaDetectada";
            this.Boton_EstrellaDetectada.Size = new System.Drawing.Size(162, 23);
            this.Boton_EstrellaDetectada.TabIndex = 0;
            this.Boton_EstrellaDetectada.Text = "ESTRELLA DETECTADA";
            this.Boton_EstrellaDetectada.UseVisualStyleBackColor = true;
            this.Boton_EstrellaDetectada.Click += new System.EventHandler(this.Boton_EstrellaDetectada_Click);
            // 
            // Grilla_Flota
            // 
            this.Grilla_Flota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Flota.Location = new System.Drawing.Point(12, 12);
            this.Grilla_Flota.Name = "Grilla_Flota";
            this.Grilla_Flota.Size = new System.Drawing.Size(343, 221);
            this.Grilla_Flota.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 279);
            this.Controls.Add(this.Grilla_Flota);
            this.Controls.Add(this.Boton_EstrellaDetectada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Flota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_EstrellaDetectada;
        private System.Windows.Forms.DataGridView Grilla_Flota;
    }
}

