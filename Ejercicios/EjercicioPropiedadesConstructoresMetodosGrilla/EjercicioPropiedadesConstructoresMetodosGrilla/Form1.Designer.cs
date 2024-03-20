namespace EjercicioPropiedadesConstructoresMetodosGrilla
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
            this.GrillaDeEnemigos = new System.Windows.Forms.DataGridView();
            this.BotonAtacarEnemigos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeEnemigos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaDeEnemigos
            // 
            this.GrillaDeEnemigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDeEnemigos.Location = new System.Drawing.Point(12, 12);
            this.GrillaDeEnemigos.Name = "GrillaDeEnemigos";
            this.GrillaDeEnemigos.Size = new System.Drawing.Size(540, 260);
            this.GrillaDeEnemigos.TabIndex = 0;
            this.GrillaDeEnemigos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDeEnemigos_CellContentClick);
            // 
            // BotonAtacarEnemigos
            // 
            this.BotonAtacarEnemigos.Location = new System.Drawing.Point(157, 308);
            this.BotonAtacarEnemigos.Name = "BotonAtacarEnemigos";
            this.BotonAtacarEnemigos.Size = new System.Drawing.Size(175, 23);
            this.BotonAtacarEnemigos.TabIndex = 1;
            this.BotonAtacarEnemigos.Text = "ATACAR ENEMIGOS";
            this.BotonAtacarEnemigos.UseVisualStyleBackColor = true;
            this.BotonAtacarEnemigos.Click += new System.EventHandler(this.BotonAtacarEnemigos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 350);
            this.Controls.Add(this.BotonAtacarEnemigos);
            this.Controls.Add(this.GrillaDeEnemigos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeEnemigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaDeEnemigos;
        private System.Windows.Forms.Button BotonAtacarEnemigos;
    }
}

