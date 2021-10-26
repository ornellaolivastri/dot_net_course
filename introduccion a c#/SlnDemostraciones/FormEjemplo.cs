
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SlnDemostraciones
{
    public partial class FormEjemplo : Form
    {
        
        private void btnPruebaInput_Click(object sender, EventArgs e)
        {
            //ejemplo input del usuario
            string nombre = Interaction.InputBox("Ingrese un nombre: ");

            //ejemplo output del usuario
            MessageBox.Show("Bienvenido al sistema " + nombre);
        }

    }
}
