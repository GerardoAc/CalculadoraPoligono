using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Circulo : Figura
    {
       
 
        public Circulo()
        {
          //  throw new System.NotImplementedException();
        }
        public Double radio
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            double areaCirculo = Math.PI* Math.Pow(radio, 2);
            return areaCirculo;
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            double perimetroCirculo = 2 * Math.PI * radio;
            return perimetroCirculo;

           // throw new NotImplementedException();
        }
        void setRadioCirculo(string radioCircul) {
            radio = Convert.ToDouble(radioCircul);

        }
    }
}