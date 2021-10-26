using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Rectangulo
    {
        // variables = base y altura
        // perimetro = 2 * base + 2 * altura
        // area = base * altura

        #region atributos

        public double Basee;
        public double Altura;

        #endregion

        #region metodos

        public double perimetro(double basee, double altura)
        {
            return basee * 2 + altura * 2;
        }

        public double area(double basee, double altura)
        {
            return basee * altura;
        }

        #endregion

        #region constructores

        public Rectangulo(double basee, double altura)
        {
            this.Basee = basee;
            this.Altura = altura;
        }

        #endregion

    }
}
