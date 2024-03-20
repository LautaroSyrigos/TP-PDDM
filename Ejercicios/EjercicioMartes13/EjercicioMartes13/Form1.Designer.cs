namespace EjercicioMartes13
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
            this.Grilla_Armas = new System.Windows.Forms.DataGridView();
            this.Boton_Usar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Armas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_Armas
            // 
            this.Grilla_Armas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Armas.Location = new System.Drawing.Point(12, 12);
            this.Grilla_Armas.Name = "Grilla_Armas";
            this.Grilla_Armas.Size = new System.Drawing.Size(463, 218);
            this.Grilla_Armas.TabIndex = 0;
            // 
            // Boton_Usar
            // 
            this.Boton_Usar.Location = new System.Drawing.Point(166, 246);
            this.Boton_Usar.Name = "Boton_Usar";
            this.Boton_Usar.Size = new System.Drawing.Size(142, 23);
            this.Boton_Usar.TabIndex = 1;
            this.Boton_Usar.Text = "USAR";
            this.Boton_Usar.UseVisualStyleBackColor = true;
            this.Boton_Usar.Click += new System.EventHandler(this.Boton_Usar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 287);
            this.Controls.Add(this.Boton_Usar);
            this.Controls.Add(this.Grilla_Armas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Armas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Armas;
        private System.Windows.Forms.Button Boton_Usar;
    }
}

