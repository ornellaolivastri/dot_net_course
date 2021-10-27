using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos.Admin;

namespace WindowsDataReader
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void mostrarProductos()
        {
            gridProduct.DataSource = AdmProduct.Listar();
        }

        private void btnTraerPorIdCategoria_Click(object sender, EventArgs e)
        {
            int IdCategoria = Convert.ToInt32(txtIdCategoriaParametros.Text);

            gridProduct.DataSource = AdmProduct.Listar(IdCategoria);
        }

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            mostrarProductos();
        }
    }
}
