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
            throw new System.NotImplementedException();
        }
        public Double ladoPentagono
        {
            get;
            set;
          
        }
        public Double apotemaPentagono { 
            get;
            set;
        }

        public override double CalcularArea()
        {
            Double area;
             area=((ladoPentagono*5)*apotemaPentagono)/ 2;
            return area;
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            double perimero = ladoPentagono * 5;
            return perimero;
            throw new NotImplementedException();
        }
    }
}