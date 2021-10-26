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
    public partial class notasAlumnos : Form
    {
        public notasAlumnos()
        {
            InitializeComponent();
        }

        //mostrar nombres de 4 alumnos con 3 notas por alumno

        private string[] nombres = new string[4]; 
        private string[] materias = new string[3] {"matematica", "fisica", "quimica"};
        private decimal[] notas = new decimal[3]; 

        private void cargarDatos()
        {
            
            for (int i = 0; i < materias.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese los Nombres: ");
                
                for (int j = 0; j < notas.Length; j++)
                {
                    notas[j] = Convert.ToInt32(Interaction.InputBox("Ingresar nota de la cada materia: "));
                }
                
            }


        }

        
        private void btnCargarNombres_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
