using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnDemostraciones
{
    public partial class frmEjercicio2 : Form
    {

        //Caso 2
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreDeUsuario.Text;
            string password = txtPassword.Text;

            if (nombreUsuario == "orne" && password == "Password")
                MessageBox.Show("bienvenido al sistema orne");
            else
                MessageBox.Show("el usuario no esta registrado");
        }


    }
}
