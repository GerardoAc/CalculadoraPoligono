using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Triangulo : Figura
    {
    
        public Double baseTriangulo
        {
            get;
            set;
        }
        public Double alturaTriangulo
        {
            get;
            set;
        }

        public Double lado1Triangulo {
            get;
            set;
        }
        public Double lado2Triangulo
        {
            get;
            set;
        }
        public Double lado3Triangulo
        {
            get;
            set;
        }



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