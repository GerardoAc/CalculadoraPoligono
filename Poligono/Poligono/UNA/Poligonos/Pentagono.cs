using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Pentagono : Figura
    {
        double ladoPentago;
        double apotemaPentagono;
        public Pentagono()
        {
            throw new System.NotImplementedException();
        }

        public override double CalcularArea()
        {
            Double area;
             area=((ladoPentago*5)*apotemaPentagono)/ 2;
            return area;
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            double perimero = ladoPentago * 5;
            return perimero;
            throw new NotImplementedException();
        }
    }
}