using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace Poligono
{
    public partial class Poligonos : Form
    {
        Figura figura;
        public Poligonos()
        {
            figura = new Triangulo();
            InitializeComponent();
        }

        private void Poligonos_Load(object sender, EventArgs e)
        {

        }

        private void calcularPerimetroBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString("El perimetro de la figura es:" + figura.CalcularPerimetro()));



        }

        private void rectanguloTabPage_Click(object sender, EventArgs e)
        {

        }

        private void trianguloTabPage_Click(object sender, EventArgs e)
        {

        }

        private void figurasTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (figurasTabControl.SelectedIndex == 0)
            {
                figura = new Triangulo();

            }
            if (figurasTabControl.SelectedIndex == 1)
            {
                figura = new Cuadrado();
            }
            if (figurasTabControl.SelectedIndex == 2)
            {
                figura = new Circulo();
            }
            if (figurasTabControl.SelectedIndex == 3)
            {
                figura = new Rectángulo();
            }
            if (figurasTabControl.SelectedIndex == 4)
            {
                figura = new Pentagono();
            }
        }

        private void TrianguloTxtLado1_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figura;
            triangulo.lado1 = Convert.ToDouble(TrianguloTxtLado1.Text);
        }

        private void TrianguloTxtLado2_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figura;
            triangulo.lado2 = Convert.ToDouble(TrianguloTxtLado2.Text);
        }

        private void TrianguloTxtLado3_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figura;
            triangulo.lado3 = Convert.ToDouble(TrianguloTxtLado3.Text);

        }




        private void calcularAreaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString("El Area de la figura es:" + figura.CalcularArea()));
        }


        private void trianguloTxrBase_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figura;
            triangulo.baseT = Convert.ToDouble(trianguloTxrBase.Text);
        }

        private void TrianguloTxtAltura_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figura;
            triangulo.altura = Convert.ToDouble(TrianguloTxtAltura.Text);
        }

       

        private void circuloRadiotxt_Leave(object sender, EventArgs e)
        {
            Circulo circulo = (Circulo)figura;
            circulo.radio = Convert.ToDouble(circuloRadiotxt.Text);
        }

        private void TrianguloTxtLado1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CuadradoLadotxt_Leave(object sender, EventArgs e)
        {
            Cuadrado cuadrado = (Cuadrado)figura;
            cuadrado.lado = Convert.ToDouble(CuadradoLadotxt.Text);
        }

        private void rectanguloLado1Txt_Leave(object sender, EventArgs e)
        {
            Rectángulo rectangulo = (Rectángulo)figura;
            rectangulo.lado1 = Convert.ToDouble(rectanguloLado1Txt.Text);
        }

        private void rectangulo2Lado2Txt_Leave(object sender, EventArgs e)
        {
            Rectángulo rectangulo = (Rectángulo)figura;
            rectangulo.lado2 = Convert.ToDouble(rectangulo2Lado2Txt.Text);
        }

        private void pentagonoLadoLabel_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono= (Pentagono)figura;
            pentagono.lado = Convert.ToDouble(pentagonoLadoLabel.Text);
        }

        private void pentagonoApotemaTxt_Leave(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)figura;
            pentagono.apotema = Convert.ToDouble(pentagonoApotemaTxt.Text);
        }
    } 
}
