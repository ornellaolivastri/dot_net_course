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

namespace ejercicios_bucles_vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarNombresNotas();
            lstNombresNotas.Text = string.Empty;
        }

        //mostrar nombres de 4 alumnos con 3 notas (de 3 materias) por alumno

        private string[] nombres = new string[4];
        private decimal[] notas = new decimal[3];

        private void cargarNombresNotas()
        {

            for (int nombre = 0; nombre < nombres.Length; nombre++)
            {
                nombres[nombre] = Interaction.InputBox("Ingresar el nombre del alumno: ");

                for (int nota = 0; nota < notas.Length; nota++)
                {
                    notas[nota] = Convert.ToInt32(Interaction.InputBox("Ingresar nota de cada una de las 3 materias: "));

                }

            }
        }


        void mostrarInformacion()
        {
            for(int n = 0; n < nombres.Length; n++)
            lstNombresNotas.Items.Add("Nombre: " + nombres[n]);

            for (int i = 0; i < notas.Length; i++)
            {
                
                for (int j = 0; j < notas.Length; j++)
                {
                    lstNombresNotas.Items.Add("Materia y nota: " + notas[j].ToString());
                }
            }    
        }

        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            mostrarInformacion();
        }
    }
}
