using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectángulo : Figura
    {
       
        public override double CalcularArea()
        {
           double areaRectangulo = lado1Rectangulo * lado2Rectangulo;
            return areaRectangulo;
            throw new NotImplementedException();
        }
        public Double lado1Rectangulo
        {
            get;
            set;
        }
        public Double lado2Rectangulo
        {
            get;
            set;
        }
        public override double CalcularPerimetro()
        {
           Double perimetroRectangulo = 2*(lado1Rectangulo + lado2Rectangulo);
            return perimetroRectangulo;
            throw new NotImplementedException();
        }
        void setLadosRectangulo(string l1Rectangulo,string l2Rectangulo) {
            lado1Rectangulo = Convert.ToDouble(l1Rectangulo);
            lado2Rectangulo = Convert.ToDouble(l2Rectangulo);
        }
    }
}