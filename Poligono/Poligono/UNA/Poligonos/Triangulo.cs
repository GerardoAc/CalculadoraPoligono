using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Triangulo : Figura
    {
        double lado1Triangulo;
        double lado2Triangulo;
        double lado3Triangulo;
        double baseTriangulo;
        double alturaTriangulo;
        public Triangulo()
        {
            throw new System.NotImplementedException();
        }

        public override double CalcularArea()
        {
           double area=(baseTriangulo* alturaTriangulo)/ 2;
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            Double perimetro = lado1Triangulo + lado2Triangulo + lado3Triangulo;
            throw new NotImplementedException();
        }
        void setDatosTriangulo(string ladoTriangulo1,string ladoTriangulo2,string ladoTriangulo3,string baseTri,string alturaTri) {
            lado1Triangulo = Convert.ToDouble(ladoTriangulo1);
            lado2Triangulo = Convert.ToDouble(ladoTriangulo2);
            lado3Triangulo = Convert.ToDouble(ladoTriangulo3);
            baseTriangulo = Convert.ToDouble(baseTri);
            alturaTriangulo = Convert.ToDouble(alturaTri);
        }
    }
}