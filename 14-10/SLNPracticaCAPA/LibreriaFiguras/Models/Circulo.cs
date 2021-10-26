using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaFiguras.Models
{

    public class Circulo
    {
        // variables =  radio       constante = pi = 3.1415926,
        // area = 3.1415926 * radio ^ 2
        // perimetro = 2 * 3.1415926 * radio

        const double pi = 3.1415926;

        #region atributos

        public double Radio;

        #endregion

        #region metodos

        public double perimetro()
        {
            return 2 * pi * this.Radio;
        }

        public double area()
        {
            return pi * this.Radio * this.Radio;
        }

        #endregion

        #region constructores

        public Circulo(double radio)
        {
            this.Radio = radio;
        }

        #endregion

    }
}
