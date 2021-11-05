using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Triangulo
    {
        // variables = lado1, lado2, lado3, altura
        // perimetro = lado1 + lado2 + lado3
        // area = (lado1 * altura) / 2

        #region atributos

        public double Lado1;
        public double Lado2;
        public double Lado3;
        public double Altura;

        #endregion

        #region metodos

        public double perimetro(double lado1, double lado2, double lado3) 
        { 
            return lado1 + lado2 + lado3; 
        }

        public double area(double lado1, double altura)
        {
            return (lado1 * altura ) / 2;
        }

        #endregion

        #region constructores

        public Triangulo(double lado1, double lado2, double lado3, double altura)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
            this.Altura = altura;
        }

        #endregion

    }
}
