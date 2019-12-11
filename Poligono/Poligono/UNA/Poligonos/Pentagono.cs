using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Pentagono : Figura
    {
        
        public Pentagono()
        {
         
        }
        public Double lado
        {
            get;
            set;
          
        }
        public Double apotema{ 
            get;
            set;
        }

        public override double CalcularArea()
        {
            Double area;
             area=((lado*5)*apotema)/ 2;
            return area;
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            double perimero = lado * 5;
            return perimero;
            throw new NotImplementedException();
        }
    }
}