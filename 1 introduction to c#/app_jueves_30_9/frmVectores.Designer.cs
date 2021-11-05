
namespace app_jueves_30_9
{
    partial class fondo
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
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.lstMostrarDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(91, 52);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(189, 23);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "cargar nombres y sueldos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(91, 121);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(189, 23);
            this.btnMostrarDatos.TabIndex = 1;
            this.btnMostrarDatos.Text = "mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // lstMostrarDatos
            // 
            this.lstMostrarDatos.FormattingEnabled = true;
            this.lstMostrarDatos.Location = new System.Drawing.Point(91, 198);
            this.lstMostrarDatos.Name = "lstMostrarDatos";
            this.lstMostrarDatos.Size = new System.Drawing.Size(189, 121);
            this.lstMostrarDatos.TabIndex = 2;
            // 
            // fondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 356);
            this.Controls.Add(this.lstMostrarDatos);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCargarDatos);
            this.Name = "fondo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.ListBox lstMostrarDatos;
    }
}

