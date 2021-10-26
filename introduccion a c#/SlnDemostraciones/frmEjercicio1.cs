using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnDemostraciones
{
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string materia = txtMateria.Text;
            string profesor = txtProfesor.Text;
            DateTime fecha = Convert.ToDateTime(txtFecha.Text);

            lblMensaje.Text = "Nombre del profesor: " + profesor + " Nombre de la materia: " + materia + " Fecha: " + fecha;

        }

        //Caso 1
        private void button1_Click(object sender, EventArgs e)
        {
            string materia = txtMateria.Text;
            string profesor = txtProfesor.Text;
            DateTime fecha = Convert.ToDateTime(txtFecha.Text);
            
            MessageBox.Show("Materia" + materia + "Profesor: " + profesor + "Fecha " + fecha);

        }



    }
}
