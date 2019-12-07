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
            throw new NotImplementedException();

        }
        public Double ladoCuadrado
        {
            get;
            set;
        }

        public override double CalcularPerimetro()
        {
            double perimetro=ladoCuadrado + ladoCuadrado + ladoCuadrado + ladoCuadrado;
            return perimetro;
        }
        public void ValorLadoCuadadro(string valorLado) {
            
            ladoCuadrado = Convert.ToDouble(valorLado);

        }
    }
}