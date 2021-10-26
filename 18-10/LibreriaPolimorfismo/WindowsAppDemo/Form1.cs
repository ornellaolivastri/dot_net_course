using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPolimorfismo.Escuela;
using LibreriaPolimorfismo.Musicos;

namespace WindowsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            Alumno presencial = new Alumno()
            {
                Apellido = "pint",
                Nombre = "agustina",
                NroMatricula = 1255,
            };

            MessageBox.Show(presencial.imprimir());

            AlumnoVirtual alumnoVirtual = new AlumnoVirtual()
            {
                Apellido = "valo",
                Nombre = "ville",
                NroMatricula = 1666,
                NroSesionVirtual = 12338181,
            };

            MessageBox.Show(alumnoVirtual.imprimir());
        }
    }
}


