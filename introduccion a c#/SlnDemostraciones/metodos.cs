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
    public partial class metodos : Form
    {
        public metodos()
        {
            InitializeComponent();
        }

        private void btnPruebaUnoVoid_Click_Click(object sender, EventArgs e)
        {
            //imprimir
            imprimir();

            //llamado con sobrecarga
            string nombre = txtNombre.Text;
            imprimir("mariana");
        }

        private void imprimir()
        {
            MessageBox.Show(txtNombre.Text);
        }

        private void imprimir(string nombre)
        {
            MessageBox.Show(txtNombre.Text);
        }

        private string mensaje(string nombre)
        {
            return "Bienvenido al sistema " + nombre;
        }

        //llamado a la funcion
        //lblMensaje.Text = mensaje(txtNombre.Text);
        //MessageBox.Show(mensaje("Juan"));


        //--------------------------------------------------------------
        //ejercicios de clase 
        //--------------------------------------------------------------


        //caso 1: crear metodo que devuelva el area de un rectangulo
        public double areaRectangulo(double lado, double altura)
        {
            double resultado = lado * altura;
            return resultado;
        }

        //caso 2: crear metodo que identifique la edad ingresada,
        //si ingresa el valor 0 muestre un mensaje de ERROR,
        //si ingresa un valor < 18 mostrar menor de edad,
        //si ingresa mayor a 18 y menor a 60, indicar que es una persona mayor de edad
        //si ingresa mayor a 60 mostrar que es una persona mayor

        public string clasificarEdad(int edad)
        {
            return (edad <= 0 ? "ingreso invalido" : 
                (edad < 18 ? "la persona es un menor de edad" : 
                (edad < 60 ? "la persona es mayor de edad" : 
                (edad > 60 ? "la persona es un adulto mayor" : "") ) ) );
        }


        //caso 3
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
