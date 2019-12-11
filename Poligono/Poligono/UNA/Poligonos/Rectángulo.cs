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
           double areaRectangulo = lado1 * lado2;
            return areaRectangulo;
            throw new NotImplementedException();
        }
        public Double lado1
        {
            get;
            set;
        }
        public Double lado2
        {
            get;
            set;
        }
        public override double CalcularPerimetro()
        {
           Double perimetroRectangulo = 2*(lado1 + lado2);
            return perimetroRectangulo;
            throw new NotImplementedException();
        }
        void setLadosRectangulo(string l1Rectangulo,string l2Rectangulo) {
            lado1 = Convert.ToDouble(l1Rectangulo);
            lado2 = Convert.ToDouble(l2Rectangulo);
        }
    }
}