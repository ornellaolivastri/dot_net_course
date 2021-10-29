using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos.Models;
using Datos.Admin;

namespace WindowsEF
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            gridPacientes.DataSource = AdmPaciente.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente()
            {
                Nombre = "Lauri"
                Apellido = "Ylönen";
                FechaNacimiento 

            }
        }
    }
}
