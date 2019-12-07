using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Cuadrado : Figura
    {
        double ladoCuadrado;
        public override double CalcularArea()
        {
            throw new NotImplementedException();

        }

        public override double CalcularPerimetro()
        {
            double perimetro=ladoCuadrado + ladoCuadrado + ladoCuadrado + ladoCuadrado;
            return perimetro;
            throw new NotImplementedException();
        }
        public void ValorLadoCuadadro(string valorLado) {
            
            ladoCuadrado = Convert.ToDouble(valorLado);

        }
    }
}