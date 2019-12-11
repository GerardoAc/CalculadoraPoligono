using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Triangulo : Figura
    {
    
        public Double baseT
        {
            get;
            set;
        }
        public Double altura
        {
            get;
            set;
        }

        public Double lado1 {
            get;
            set;
        }
        public Double lado2
        {
            get;
            set;
        }
        public Double lado3
        {
            get;
            set;
        }



        public Triangulo()
        {
        }

        public override double CalcularArea()
        {
           double areaT=(baseT* altura)/ 2;
            return areaT;
          throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            Double perimetro = lado1 + lado2 +lado3;
            return perimetro;
            throw new NotImplementedException();
        }
        void setDatosTriangulo(string ladoTriangulo1,string ladoTriangulo2,string ladoTriangulo3,string baseTri,string alturaTri) {
            lado1 = Convert.ToDouble(ladoTriangulo1);
            lado2 = Convert.ToDouble(ladoTriangulo2);
            lado3 = Convert.ToDouble(ladoTriangulo3);
            baseT= Convert.ToDouble(baseTri);
            altura = Convert.ToDouble(alturaTri);
        }
    }
}