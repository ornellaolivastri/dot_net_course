using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myTests_windowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void Form1_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "";
            lblAgeClasification.Text = string.Empty;
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hola " + txtBoxNombre.Text + " !";
        }

        private void btnAgeClasification_Click(object sender, EventArgs e)
        {
            clasificarEdad( Convert.ToInt32(txtBoxAge.Text) );
        }

        public string clasificarEdad(int edad)
        {

            return (edad <= 0 ? (lblAgeClasification.Text = "ingreso invalido !") :
                (edad < 18 ? (lblAgeClasification.Text = "Eres menor de edad !") :
                (edad < 60 ? (lblAgeClasification.Text = "Eres mayor de edad !") :
                (edad > 60 ? (lblAgeClasification.Text = "Eres un adulto mayor !") : "" ))));
        }

    }
}
