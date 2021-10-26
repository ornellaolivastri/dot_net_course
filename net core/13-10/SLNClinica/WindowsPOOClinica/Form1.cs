using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPOOClinica.Models;

namespace WindowsPOOClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            //declarar y crear instancia de Medico (objeto)
            Medico medico = new Medico();
            Enfermero enfermero = new Enfermero();
            Paciente paciente = new Paciente();
            Director director = new Director();
            Clinica clinica = new Clinica();

            //escribir las propiedades
            medico.Apellido = "Perez";
            medico.Nombre = "Juan";
            medico.Matricula = "A124";
            medico.Apellido = "Perez";
            medico.Nombre = "Juan";
            medico.Matricula = "A124";

            enfermero.Apellido = "einstein";
            enfermero.Nombre = "albert";
            enfermero.Domicilio = "weiss strasse 123";
            enfermero.FechaNacimiento = new DateTime(1879, 03, 14);

            director.Apellido = "sagan";
            director.Nombre = "carl";
            director.Domicilio = "first street 321";
            director.FechaNacimiento = new DateTime(1998, 01, 01);

            clinica.Nombre = "suomi";
            clinica.Domicilio = "artico 001";

            //leer propiedades
            
            MessageBox.Show(medico.Apellido + " " + medico.Nombre + " " + medico.Matricula);

            MessageBox.Show(enfermero.Apellido + " " + enfermero.Nombre + " " + enfermero.Domicilio + " " + enfermero.FechaNacimiento.ToShortDateString().ToString()); 

            MessageBox.Show(director.Apellido + " " + director.Nombre + " " + director.Domicilio + " " + director.FechaNacimiento);

            MessageBox.Show(clinica.Nombre + " " + clinica.Domicilio);

            //Ejemplo de instancia usando constructor con parametro
            Medico medico1 = new Medico("ana","pint","A503");

            MessageBox.Show(medico1.Apellido + " " + medico1.Nombre + " " + medico1.Matricula);
        }
    }
}
