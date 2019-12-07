using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Circulo : Figura
    {
       
        double radioCirculo;
        public Circulo()
        {
            throw new System.NotImplementedException();
        }

        public override double CalcularArea()
        {
            double areaCirculo = Math.PI* Math.Pow(radioCirculo, 2);
            return areaCirculo;
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            double perimetroCirculo = 2 * Math.PI * radioCirculo;


            throw new NotImplementedException();
        }
        void setRadioCirculo(string radioCircul) {
            radioCirculo = Convert.ToDouble(radioCircul);

        }
    }
}