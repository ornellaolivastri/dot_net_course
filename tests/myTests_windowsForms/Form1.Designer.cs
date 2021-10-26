
namespace myTests_windowsForms
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblAskName = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblAskAge = new System.Windows.Forms.Label();
            this.btnAgeClasification = new System.Windows.Forms.Button();
            this.lblAgeClasification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaludo.Location = new System.Drawing.Point(70, 196);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(211, 38);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Say hi !";
            this.btnSaludo.UseVisualStyleBackColor = false;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblAskName
            // 
            this.lblAskName.AutoSize = true;
            this.lblAskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskName.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAskName.Location = new System.Drawing.Point(85, 58);
            this.lblAskName.Name = "lblAskName";
            this.lblAskName.Size = new System.Drawing.Size(187, 24);
            this.lblAskName.TabIndex = 1;
            this.lblAskName.Text = "Which is your name?";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(146, 267);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(40, 20);
            this.lblGreeting.TabIndex = 2;
            this.lblGreeting.Text = "lbl hi";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(89, 112);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(170, 20);
            this.txtBoxNombre.TabIndex = 3;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(391, 112);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(162, 20);
            this.txtBoxAge.TabIndex = 6;
            // 
            // lblAskAge
            // 
            this.lblAskAge.AutoSize = true;
            this.lblAskAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskAge.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAskAge.Location = new System.Drawing.Point(387, 58);
            this.lblAskAge.Name = "lblAskAge";
            this.lblAskAge.Size = new System.Drawing.Size(158, 24);
            this.lblAskAge.TabIndex = 5;
            this.lblAskAge.Text = "How old are you?";
            // 
            // btnAgeClasification
            // 
            this.btnAgeClasification.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgeClasification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgeClasification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgeClasification.Location = new System.Drawing.Point(341, 196);
            this.btnAgeClasification.Name = "btnAgeClasification";
            this.btnAgeClasification.Size = new System.Drawing.Size(266, 38);
            this.btnAgeClasification.TabIndex = 4;
            this.btnAgeClasification.Text = "Let\'s clasificate your age";
            this.btnAgeClasification.UseVisualStyleBackColor = false;
            this.btnAgeClasification.Click += new System.EventHandler(this.btnAgeClasification_Click);
            // 
            // lblAgeClasification
            // 
            this.lblAgeClasification.AutoSize = true;
            this.lblAgeClasification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeClasification.Location = new System.Drawing.Point(404, 267);
            this.lblAgeClasification.Name = "lblAgeClasification";
            this.lblAgeClasification.Size = new System.Drawing.Size(141, 20);
            this.lblAgeClasification.TabIndex = 7;
            this.lblAgeClasification.Text = "lbl age clasification";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(661, 349);
            this.Controls.Add(this.lblAgeClasification);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.lblAskAge);
            this.Controls.Add(this.btnAgeClasification);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblAskName);
            this.Controls.Add(this.btnSaludo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblAskName;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblAskAge;
        private System.Windows.Forms.Button btnAgeClasification;
        private System.Windows.Forms.Label lblAgeClasification;
    }
}

