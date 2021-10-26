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

namespace app_jueves_30_9
{
    public partial class fondo : Form
    {
        public fondo()
        {
            InitializeComponent();
        }

        private string[] nombres; //declaracion de un vector de strings
        private decimal[] sueldos; //otra de decimals

        private void cargarDatos()
        {
            //creacion de instancias
            nombres = new string[3];
            sueldos = new decimal[3];

            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese Nombre: ");
                sueldos[i] = Convert.ToDecimal(Interaction.InputBox("Ingrese sueldo"));
            }

            
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                lstMostrarDatos.Items.Add(nombres[i] + " -> " + sueldos[i].ToString());
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
