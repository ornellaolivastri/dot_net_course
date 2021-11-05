using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaSegura.Models;
using LibreriaSegura.Admin;

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
            //creamos una instancia de usuario
            Usuario usuario = new Usuario(txtUsuario.Text, txtPassword.Text);

            //crear una instancia de admUsuario
            AdmUsuario admUsuario = new AdmUsuario();

            //invocar al metodo autenticar
            bool resultado = admUsuario.autenticar(usuario);
            
            if (resultado)
            {
                MessageBox.Show("Bienvenido al sistema!");
            }
            else
            {
                MessageBox.Show("Datos incorrectos! No se pudo acceder al sistema");
            }
        }
        
        

    }
}
