using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaFiguras.Models;

namespace WindowsFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Circulo circulo1 = new Circulo(Convert.ToDouble(txtRadio.Text));
            
            MessageBox.Show("El perimetro es: " + Convert.ToString( circulo1.perimetro()) 
                + ". Y el area es: " + Convert.ToString(circulo1.area()) );


        }
    }
}
