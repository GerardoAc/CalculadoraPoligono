using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Cuadrado : Figura
    {

        public override double CalcularArea()
        {
            double areaC = Math.Pow(lado, 2);
            return areaC;
            throw new NotImplementedException();

        }
        public Double lado
        {
            get;
            set;
        }

        public override double CalcularPerimetro()
        {
            double perimetro=4*lado;
            return perimetro;
        }
        public void ValorLadoCuadadro(string valorLado) {
            
            lado = Convert.ToDouble(valorLado);

        }
    }
}