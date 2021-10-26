using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindowsFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Tarea 2

        private void btnValidations_Click(object sender, EventArgs e)
        {
            if ( (Convert.ToInt32(txtSalary.Text) > 0) && ( (txtRole.Text == "Soporte Tecnico") || (txtRole.Text == "DBA") || (txtRole.Text == "Desarrollador") ) )
            {
                lblMessage.Text = "Resultado de validacion: todo correcto.";
            } else
            {
                lblMessage.Text = "El sueldo o el puesto ingresado no es valido. Reintentar.";
            }
        }
        

        //Tarea 3: imprimir nombre completo y puesto en mayuscula
        private void btnShow_Click(object sender, EventArgs e)
        {
            string auxiliarString = txtName.Text + " " + txtLastName.Text + ": " + txtRole.Text;
            lblMessage2.Text = auxiliarString.ToUpper();
        }  

        
        //Tarea 4: 
        
        private string[] workedHours;

        private void btnSetHours_Click(object sender, EventArgs e)
        {
            workedHours = new string[5];             //creacion de instancia


            for (int i = 0; i < workedHours.Length; i++)
            {
                workedHours[i] = Convert.ToDouble(Interaction.InputBox("Ingrese horas trabajadas desde el lunes hasta el viernes: " ));
                
            }

            double totalWorkedHours = 0;

            foreach (double hour in workedHours)
            {
                totalWorkedHours += hour;    // se va agregando la hora al total
            }
           
            double averageWorkedHours = totalWorkedHours / workedHours.Length;


            lblTotalWorkedHours.Text = Convert.ToString(totalWorkedHours);

            lblAverage.Text = Convert.ToString(averageWorkedHours);

            if (averageWorkedHours < 20)
            {
                lblMessage3.Text = "No tiene un dia libre la proxima semana";
            }
            else
            {
                if (averageWorkedHours < 30)
                {
                    lblMessage3.Text = "Tiene un dia libre la semana proxima";
                }
                else
                {
                    lblMessage3.Text = "Tiene dos dias libres la semana proxima";
                }
            }

        }

       


    }
}
