
namespace ejercicios_bucles_vectores
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
            this.lstNombresNotas = new System.Windows.Forms.ListBox();
            this.btnCargarNombres = new System.Windows.Forms.Button();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNombresNotas
            // 
            this.lstNombresNotas.FormattingEnabled = true;
            this.lstNombresNotas.Location = new System.Drawing.Point(36, 114);
            this.lstNombresNotas.Name = "lstNombresNotas";
            this.lstNombresNotas.Size = new System.Drawing.Size(241, 446);
            this.lstNombresNotas.TabIndex = 0;
            // 
            // btnCargarNombres
            // 
            this.btnCargarNombres.Location = new System.Drawing.Point(74, 27);
            this.btnCargarNombres.Name = "btnCargarNombres";
            this.btnCargarNombres.Size = new System.Drawing.Size(135, 23);
            this.btnCargarNombres.TabIndex = 1;
            this.btnCargarNombres.Text = "Cargar Nombres";
            this.btnCargarNombres.UseVisualStyleBackColor = true;
            this.btnCargarNombres.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(74, 68);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(135, 23);
            this.btnMostrarInformacion.TabIndex = 2;
            this.btnMostrarInformacion.Text = "Mostrar informacion";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            this.btnMostrarInformacion.Click += new System.EventHandler(this.btnMostrarInformacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 591);
            this.Controls.Add(this.btnMostrarInformacion);
            this.Controls.Add(this.btnCargarNombres);
            this.Controls.Add(this.lstNombresNotas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNombresNotas;
        private System.Windows.Forms.Button btnCargarNombres;
        private System.Windows.Forms.Button btnMostrarInformacion;
    }
}

