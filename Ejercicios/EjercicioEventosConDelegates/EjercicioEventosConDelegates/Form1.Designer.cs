namespace EjercicioEventosConDelegates
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
            this.Boton_TomarExamen = new System.Windows.Forms.Button();
            this.GrillaAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_TomarExamen
            // 
            this.Boton_TomarExamen.Location = new System.Drawing.Point(125, 305);
            this.Boton_TomarExamen.Name = "Boton_TomarExamen";
            this.Boton_TomarExamen.Size = new System.Drawing.Size(171, 23);
            this.Boton_TomarExamen.TabIndex = 0;
            this.Boton_TomarExamen.Text = "TOMAR EXAMEN";
            this.Boton_TomarExamen.UseVisualStyleBackColor = true;
            this.Boton_TomarExamen.Click += new System.EventHandler(this.Boton_TomarExamen_Click);
            // 
            // GrillaAlumnos
            // 
            this.GrillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaAlumnos.Location = new System.Drawing.Point(12, 12);
            this.GrillaAlumnos.Name = "GrillaAlumnos";
            this.GrillaAlumnos.Size = new System.Drawing.Size(435, 287);
            this.GrillaAlumnos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 332);
            this.Controls.Add(this.GrillaAlumnos);
            this.Controls.Add(this.Boton_TomarExamen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_TomarExamen;
        private System.Windows.Forms.DataGridView GrillaAlumnos;
    }
}

