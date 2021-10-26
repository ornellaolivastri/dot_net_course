using LibreriaEntidades.Models;
using LibreriaEntidades.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            //no podemos instanciar clases abstractas
            //Persona persona = new Persona("valo", "ville", "123456");
            Empleado empleado = new Empleado("ylönen", "lauri", "123456", 69);
            Director director = new Director("vartiainen", "jenni", "123456", 666);

        }
    }
}
