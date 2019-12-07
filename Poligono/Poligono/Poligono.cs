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
        public Poligonos()
        {
            InitializeComponent();
        }

        private void Poligonos_Load(object sender, EventArgs e)
        {

        }

        private void calcularPerimetroBtn_Click(object sender, EventArgs e)
        {
            Figura cuadrado = new Cuadrado();
             
            cuadrado.CalcularPerimetro();
            cuadrado.CalcularPerimetro();
            ResultadoPerimetroLabel.Text = cuadrado.CalcularPerimetro().ToString();
           



        }
    }
}
