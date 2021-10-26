
namespace AppWindowsFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnValidations = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSetHours = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.lblWorkedHours = new System.Windows.Forms.Label();
            this.lblTotalWorkedHours = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.lblMessage2lbl = new System.Windows.Forms.Label();
            this.lblAveragelbl = new System.Windows.Forms.Label();
            this.lblTotallbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(44, 76);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(51, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Apellido";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(44, 127);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(43, 15);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Sueldo";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(44, 175);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 15);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Puesto";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(145, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(145, 124);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 23);
            this.txtSalary.TabIndex = 6;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(145, 172);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 23);
            this.txtRole.TabIndex = 7;
            // 
            // btnValidations
            // 
            this.btnValidations.Location = new System.Drawing.Point(311, 30);
            this.btnValidations.Name = "btnValidations";
            this.btnValidations.Size = new System.Drawing.Size(97, 23);
            this.btnValidations.TabIndex = 8;
            this.btnValidations.Text = "Validations";
            this.btnValidations.UseVisualStyleBackColor = true;
            this.btnValidations.Click += new System.EventHandler(this.btnValidations_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(311, 76);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(97, 23);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSetHours
            // 
            this.btnSetHours.Location = new System.Drawing.Point(311, 124);
            this.btnSetHours.Name = "btnSetHours";
            this.btnSetHours.Size = new System.Drawing.Size(97, 23);
            this.btnSetHours.TabIndex = 10;
            this.btnSetHours.Text = "SetHours";
            this.btnSetHours.UseVisualStyleBackColor = true;
            this.btnSetHours.Click += new System.EventHandler(this.btnSetHours_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(311, 171);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(97, 23);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(42, 216);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 15);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "Message";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Location = new System.Drawing.Point(42, 249);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(59, 15);
            this.lblMessage2.TabIndex = 13;
            this.lblMessage2.Text = "Message2";
            // 
            // lblWorkedHours
            // 
            this.lblWorkedHours.AutoSize = true;
            this.lblWorkedHours.Location = new System.Drawing.Point(263, 216);
            this.lblWorkedHours.Name = "lblWorkedHours";
            this.lblWorkedHours.Size = new System.Drawing.Size(80, 15);
            this.lblWorkedHours.TabIndex = 14;
            this.lblWorkedHours.Text = "WorkedHours";
            // 
            // lblTotalWorkedHours
            // 
            this.lblTotalWorkedHours.AutoSize = true;
            this.lblTotalWorkedHours.Location = new System.Drawing.Point(311, 245);
            this.lblTotalWorkedHours.Name = "lblTotalWorkedHours";
            this.lblTotalWorkedHours.Size = new System.Drawing.Size(32, 15);
            this.lblTotalWorkedHours.TabIndex = 15;
            this.lblTotalWorkedHours.Text = "Total";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(311, 260);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(59, 15);
            this.lblAverage.TabIndex = 16;
            this.lblAverage.Text = "Promedio";
            // 
            // lblMessage3
            // 
            this.lblMessage3.AutoSize = true;
            this.lblMessage3.Location = new System.Drawing.Point(311, 275);
            this.lblMessage3.Name = "lblMessage3";
            this.lblMessage3.Size = new System.Drawing.Size(59, 15);
            this.lblMessage3.TabIndex = 17;
            this.lblMessage3.Text = "Message3";
            // 
            // lblMessage2lbl
            // 
            this.lblMessage2lbl.AutoSize = true;
            this.lblMessage2lbl.Location = new System.Drawing.Point(238, 275);
            this.lblMessage2lbl.Name = "lblMessage2lbl";
            this.lblMessage2lbl.Size = new System.Drawing.Size(59, 15);
            this.lblMessage2lbl.TabIndex = 20;
            this.lblMessage2lbl.Text = "Message3";
            // 
            // lblAveragelbl
            // 
            this.lblAveragelbl.AutoSize = true;
            this.lblAveragelbl.Location = new System.Drawing.Point(238, 260);
            this.lblAveragelbl.Name = "lblAveragelbl";
            this.lblAveragelbl.Size = new System.Drawing.Size(59, 15);
            this.lblAveragelbl.TabIndex = 19;
            this.lblAveragelbl.Text = "Promedio";
            // 
            // lblTotallbl
            // 
            this.lblTotallbl.AutoSize = true;
            this.lblTotallbl.Location = new System.Drawing.Point(238, 245);
            this.lblTotallbl.Name = "lblTotallbl";
            this.lblTotallbl.Size = new System.Drawing.Size(32, 15);
            this.lblTotallbl.TabIndex = 18;
            this.lblTotallbl.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 300);
            this.Controls.Add(this.lblMessage2lbl);
            this.Controls.Add(this.lblAveragelbl);
            this.Controls.Add(this.lblTotallbl);
            this.Controls.Add(this.lblMessage3);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalWorkedHours);
            this.Controls.Add(this.lblWorkedHours);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSetHours);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnValidations);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnValidations;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSetHours;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Label lblWorkedHours;
        private System.Windows.Forms.Label lblTotalWorkedHours;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMessage3;
        private System.Windows.Forms.Label lblMessage2lbl;
        private System.Windows.Forms.Label lblAveragelbl;
        private System.Windows.Forms.Label lblTotallbl;
    }
}

