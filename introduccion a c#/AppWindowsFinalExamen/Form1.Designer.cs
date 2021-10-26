
namespace AppWindowsFinal
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.lblTotalWorkedHours = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnValidations = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSetHours = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.lblAveragelb = new System.Windows.Forms.Label();
            this.lblTotallbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Apellido";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(23, 109);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(40, 13);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Sueldo";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(23, 151);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 13);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Puesto";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(17, 208);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(10, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = " ";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(17, 252);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(10, 13);
            this.lblMessage2.TabIndex = 5;
            this.lblMessage2.Text = " ";
            // 
            // lblTotalWorkedHours
            // 
            this.lblTotalWorkedHours.AutoSize = true;
            this.lblTotalWorkedHours.Location = new System.Drawing.Point(397, 30);
            this.lblTotalWorkedHours.Name = "lblTotalWorkedHours";
            this.lblTotalWorkedHours.Size = new System.Drawing.Size(76, 13);
            this.lblTotalWorkedHours.TabIndex = 6;
            this.lblTotalWorkedHours.Text = "Worked Hours";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(443, 110);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(78, 13);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Valor Promedio";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(115, 106);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 11;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(115, 153);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 20);
            this.txtRole.TabIndex = 12;
            // 
            // btnValidations
            // 
            this.btnValidations.Location = new System.Drawing.Point(231, 20);
            this.btnValidations.Name = "btnValidations";
            this.btnValidations.Size = new System.Drawing.Size(75, 23);
            this.btnValidations.TabIndex = 13;
            this.btnValidations.Text = "Validations";
            this.btnValidations.UseVisualStyleBackColor = true;
            this.btnValidations.Click += new System.EventHandler(this.btnValidations_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(231, 62);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // btnSetHours
            // 
            this.btnSetHours.Location = new System.Drawing.Point(231, 100);
            this.btnSetHours.Name = "btnSetHours";
            this.btnSetHours.Size = new System.Drawing.Size(75, 23);
            this.btnSetHours.TabIndex = 15;
            this.btnSetHours.Text = "SetHours";
            this.btnSetHours.UseVisualStyleBackColor = true;
            this.btnSetHours.Click += new System.EventHandler(this.btnSetHours_Click_1);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(231, 151);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Valor Total";
            // 
            // lblMessage3
            // 
            this.lblMessage3.AutoSize = true;
            this.lblMessage3.Location = new System.Drawing.Point(345, 156);
            this.lblMessage3.Name = "lblMessage3";
            this.lblMessage3.Size = new System.Drawing.Size(10, 13);
            this.lblMessage3.TabIndex = 18;
            this.lblMessage3.Text = " ";
            // 
            // lblAveragelb
            // 
            this.lblAveragelb.AutoSize = true;
            this.lblAveragelb.Location = new System.Drawing.Point(374, 110);
            this.lblAveragelb.Name = "lblAveragelb";
            this.lblAveragelb.Size = new System.Drawing.Size(51, 13);
            this.lblAveragelb.TabIndex = 19;
            this.lblAveragelb.Text = "Promedio";
            // 
            // lblTotallbl
            // 
            this.lblTotallbl.AutoSize = true;
            this.lblTotallbl.Location = new System.Drawing.Point(389, 65);
            this.lblTotallbl.Name = "lblTotallbl";
            this.lblTotallbl.Size = new System.Drawing.Size(31, 13);
            this.lblTotallbl.TabIndex = 20;
            this.lblTotallbl.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 296);
            this.Controls.Add(this.lblTotallbl);
            this.Controls.Add(this.lblAveragelb);
            this.Controls.Add(this.lblMessage3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSetHours);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnValidations);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalWorkedHours);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Label lblTotalWorkedHours;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnValidations;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSetHours;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMessage3;
        private System.Windows.Forms.Label lblAveragelb;
        private System.Windows.Forms.Label lblTotallbl;
    }
}

