using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaSegura.Admin;//Agregar
using LibreriaSegura.Models;//agregar


namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Crear instancia de usuario
            Usuario usuario = new Usuario(txtNombre.Text, txtPassword.Text);

            //Crear una instancia de AdmUsuario
            AdmUsuario admUsuario = new AdmUsuario();

            //invocar al método autenticación
            bool resultado = admUsuario.autenticar(usuario);

            if (resultado)
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }


        }


    }
}
