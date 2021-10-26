using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppStaticCollection.DemoStatic;

namespace WindowsAppStaticCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declarar y crear instancia de lista a nivel formulario para que sea accesible para todo
        List<Cliente> clientes;

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int resultado = Calculadora.suma(2,2);
            MessageBox.Show(resultado.ToString());
        }

        private void btnCrearClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("mariana");
            MessageBox.Show(Cliente.NroInstancias.ToString());

            Cliente cliente2 = new Cliente("Fernando");
            Cliente cliente3 = new Cliente("Marcelo");

            MessageBox.Show(Cliente.NroInstancias.ToString());
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            //subrutina generada por refactorizacion
            LlenarListaClientes();

            //mostrar los clientes en el control gridClientes
            gridClientes.DataSource = clientes;
            //esta propiedad DatSourse se llama 'propiedad de enlace de datos' o 'binding property'
            // porque permite mostrar en ese control una coleccion/lista/dataTable

        }

        private void LlenarListaClientes()
        {
            //declarar y crear instancia de lista
            clientes = new List<Cliente>();

            //otra declaracion del cliente3, interna a este boton
            Cliente cliente3;

            //instanciamos un elemento cliente
            cliente3 = new Cliente("gustavo");

            //agregar elementos a la lista
            clientes.Add(new Cliente("Sofia"));
            clientes.Add(new Cliente("Brenda"));
            clientes.Add(cliente3);
        }

        private void btnMostrarNombres_Click(object sender, EventArgs e)
        {
            //para poder acceder a la lista clientes dentro de este boton debemos declarar 
            //la lista a nivel formulario

            imprimirNombresDeClientes();
        }

        private void imprimirNombresDeClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                listMostrarNombres.Items.Add(cliente.Nombre);
            }
        }
    }
}
