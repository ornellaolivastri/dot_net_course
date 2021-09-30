
namespace SlnDemostraciones
{
    partial class metodos
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
            this.btnPruebaUnoVoid_Click = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPruebaUnoVoid_Click
            // 
            this.btnPruebaUnoVoid_Click.Location = new System.Drawing.Point(133, 208);
            this.btnPruebaUnoVoid_Click.Name = "btnPruebaUnoVoid_Click";
            this.btnPruebaUnoVoid_Click.Size = new System.Drawing.Size(240, 22);
            this.btnPruebaUnoVoid_Click.TabIndex = 0;
            this.btnPruebaUnoVoid_Click.Text = "prueba 1 void";
            this.btnPruebaUnoVoid_Click.UseVisualStyleBackColor = true;
            this.btnPruebaUnoVoid_Click.Click += new System.EventHandler(this.btnPruebaUnoVoid_Click_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 164);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnPruebaUnoVoid_Click);
            this.Name = "metodos";
            this.Text = "metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaUnoVoid_Click;
        private System.Windows.Forms.TextBox txtNombre;
    }
}