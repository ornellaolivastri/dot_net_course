
namespace app_jueves_30_9
{
    partial class notasAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lstMostrarDatos = new System.Windows.Forms.ListBox();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstMostrarDatos
            // 
            this.lstMostrarDatos.FormattingEnabled = true;
            this.lstMostrarDatos.Location = new System.Drawing.Point(150, 23);
            this.lstMostrarDatos.Name = "lstMostrarDatos";
            this.lstMostrarDatos.Size = new System.Drawing.Size(233, 121);
            this.lstMostrarDatos.TabIndex = 5;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(12, 99);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(120, 43);
            this.btnMostrarDatos.TabIndex = 4;
            this.btnMostrarDatos.Text = "mostrar nombres con promedios";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(12, 23);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(120, 32);
            this.btnCargarDatos.TabIndex = 3;
            this.btnCargarDatos.Text = "cargar nombres";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarNombres_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "cargar notas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstMostrarDatos);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.button1);
            this.Name = "notasAlumnos";
            this.Text = "notasAlumnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstMostrarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button button2;
    }
}