namespace Poligono
{
    partial class Poligonos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tituloLabel = new System.Windows.Forms.Label();
            this.figurasTabControl = new System.Windows.Forms.TabControl();
            this.trianguloTabPage = new System.Windows.Forms.TabPage();
            this.TrianguloTxtAltura = new System.Windows.Forms.TextBox();
            this.trianguloTxrBase = new System.Windows.Forms.TextBox();
            this.trianguloAlturaLabel = new System.Windows.Forms.Label();
            this.trianguloBaseLabel = new System.Windows.Forms.Label();
            this.TrianguloTxtLado3 = new System.Windows.Forms.TextBox();
            this.TrianguloTxtLado2 = new System.Windows.Forms.TextBox();
            this.TrianguloTxtLado1 = new System.Windows.Forms.TextBox();
            this.trianguloLado3Labe = new System.Windows.Forms.Label();
            this.trianguloLado1Labe = new System.Windows.Forms.Label();
            this.trianguloLado1Label = new System.Windows.Forms.Label();
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.LadoCuadradoLabel = new System.Windows.Forms.Label();
            this.CuadradoLadotxt = new System.Windows.Forms.TextBox();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.circuloRadiotxt = new System.Windows.Forms.TextBox();
            this.circuloRadioLabel = new System.Windows.Forms.Label();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.rectangulo2Lado2Txt = new System.Windows.Forms.TextBox();
            this.rectanguloLado1Txt = new System.Windows.Forms.TextBox();
            this.rectanguloLado2Label = new System.Windows.Forms.Label();
            this.rectanguloLado1Label = new System.Windows.Forms.Label();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoApotemaTxt = new System.Windows.Forms.TextBox();
            this.pentagonoLadoLabel = new System.Windows.Forms.TextBox();
            this.pentagoApotemaLabel = new System.Windows.Forms.Label();
            this.pentagonoLadoLabe = new System.Windows.Forms.Label();
            this.calcularPerimetroBtn = new System.Windows.Forms.Button();
            this.calcularAreaBtn = new System.Windows.Forms.Button();
            this.figurasTabControl.SuspendLayout();
            this.trianguloTabPage.SuspendLayout();
            this.cuadradoTabPage.SuspendLayout();
            this.circuloTabPage.SuspendLayout();
            this.rectanguloTabPage.SuspendLayout();
            this.pentagonoTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.Green;
            this.tituloLabel.Location = new System.Drawing.Point(309, 33);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(275, 23);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Calculadora de Poligonos";
            // 
            // figurasTabControl
            // 
            this.figurasTabControl.Controls.Add(this.trianguloTabPage);
            this.figurasTabControl.Controls.Add(this.cuadradoTabPage);
            this.figurasTabControl.Controls.Add(this.circuloTabPage);
            this.figurasTabControl.Controls.Add(this.rectanguloTabPage);
            this.figurasTabControl.Controls.Add(this.pentagonoTabPage);
            this.figurasTabControl.Location = new System.Drawing.Point(12, 70);
            this.figurasTabControl.Name = "figurasTabControl";
            this.figurasTabControl.SelectedIndex = 0;
            this.figurasTabControl.Size = new System.Drawing.Size(786, 314);
            this.figurasTabControl.TabIndex = 1;
            this.figurasTabControl.SelectedIndexChanged += new System.EventHandler(this.figurasTabControl_SelectedIndexChanged);
            // 
            // trianguloTabPage
            // 
            this.trianguloTabPage.Controls.Add(this.TrianguloTxtAltura);
            this.trianguloTabPage.Controls.Add(this.trianguloTxrBase);
            this.trianguloTabPage.Controls.Add(this.trianguloAlturaLabel);
            this.trianguloTabPage.Controls.Add(this.trianguloBaseLabel);
            this.trianguloTabPage.Controls.Add(this.TrianguloTxtLado3);
            this.trianguloTabPage.Controls.Add(this.TrianguloTxtLado2);
            this.trianguloTabPage.Controls.Add(this.TrianguloTxtLado1);
            this.trianguloTabPage.Controls.Add(this.trianguloLado3Labe);
            this.trianguloTabPage.Controls.Add(this.trianguloLado1Labe);
            this.trianguloTabPage.Controls.Add(this.trianguloLado1Label);
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(778, 288);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            this.trianguloTabPage.Click += new System.EventHandler(this.trianguloTabPage_Click);
            // 
            // TrianguloTxtAltura
            // 
            this.TrianguloTxtAltura.Location = new System.Drawing.Point(79, 188);
            this.TrianguloTxtAltura.Name = "TrianguloTxtAltura";
            this.TrianguloTxtAltura.Size = new System.Drawing.Size(100, 20);
            this.TrianguloTxtAltura.TabIndex = 11;
            this.TrianguloTxtAltura.Leave += new System.EventHandler(this.TrianguloTxtAltura_Leave);
            // 
            // trianguloTxrBase
            // 
            this.trianguloTxrBase.Location = new System.Drawing.Point(79, 155);
            this.trianguloTxrBase.Name = "trianguloTxrBase";
            this.trianguloTxrBase.Size = new System.Drawing.Size(100, 20);
            this.trianguloTxrBase.TabIndex = 10;
            this.trianguloTxrBase.Leave += new System.EventHandler(this.trianguloTxrBase_Leave);
            // 
            // trianguloAlturaLabel
            // 
            this.trianguloAlturaLabel.AutoSize = true;
            this.trianguloAlturaLabel.Location = new System.Drawing.Point(22, 188);
            this.trianguloAlturaLabel.Name = "trianguloAlturaLabel";
            this.trianguloAlturaLabel.Size = new System.Drawing.Size(34, 13);
            this.trianguloAlturaLabel.TabIndex = 9;
            this.trianguloAlturaLabel.Text = "Altura";
            // 
            // trianguloBaseLabel
            // 
            this.trianguloBaseLabel.AutoSize = true;
            this.trianguloBaseLabel.Location = new System.Drawing.Point(22, 161);
            this.trianguloBaseLabel.Name = "trianguloBaseLabel";
            this.trianguloBaseLabel.Size = new System.Drawing.Size(31, 13);
            this.trianguloBaseLabel.TabIndex = 8;
            this.trianguloBaseLabel.Text = "Base";
            // 
            // TrianguloTxtLado3
            // 
            this.TrianguloTxtLado3.Location = new System.Drawing.Point(79, 128);
            this.TrianguloTxtLado3.Name = "TrianguloTxtLado3";
            this.TrianguloTxtLado3.Size = new System.Drawing.Size(100, 20);
            this.TrianguloTxtLado3.TabIndex = 5;
            this.TrianguloTxtLado3.Leave += new System.EventHandler(this.TrianguloTxtLado3_Leave);
            // 
            // TrianguloTxtLado2
            // 
            this.TrianguloTxtLado2.Location = new System.Drawing.Point(79, 96);
            this.TrianguloTxtLado2.Name = "TrianguloTxtLado2";
            this.TrianguloTxtLado2.Size = new System.Drawing.Size(100, 20);
            this.TrianguloTxtLado2.TabIndex = 4;
            this.TrianguloTxtLado2.Leave += new System.EventHandler(this.TrianguloTxtLado2_Leave);
            // 
            // TrianguloTxtLado1
            // 
            this.TrianguloTxtLado1.Location = new System.Drawing.Point(79, 56);
            this.TrianguloTxtLado1.Name = "TrianguloTxtLado1";
            this.TrianguloTxtLado1.Size = new System.Drawing.Size(100, 20);
            this.TrianguloTxtLado1.TabIndex = 3;
            this.TrianguloTxtLado1.TextChanged += new System.EventHandler(this.TrianguloTxtLado1_TextChanged);
            this.TrianguloTxtLado1.Leave += new System.EventHandler(this.TrianguloTxtLado1_Leave);
            // 
            // trianguloLado3Labe
            // 
            this.trianguloLado3Labe.AutoSize = true;
            this.trianguloLado3Labe.Location = new System.Drawing.Point(19, 128);
            this.trianguloLado3Labe.Name = "trianguloLado3Labe";
            this.trianguloLado3Labe.Size = new System.Drawing.Size(37, 13);
            this.trianguloLado3Labe.TabIndex = 2;
            this.trianguloLado3Labe.Text = "Lado3";
            // 
            // trianguloLado1Labe
            // 
            this.trianguloLado1Labe.AutoSize = true;
            this.trianguloLado1Labe.Location = new System.Drawing.Point(19, 96);
            this.trianguloLado1Labe.Name = "trianguloLado1Labe";
            this.trianguloLado1Labe.Size = new System.Drawing.Size(37, 13);
            this.trianguloLado1Labe.TabIndex = 1;
            this.trianguloLado1Labe.Text = "Lado2";
            // 
            // trianguloLado1Label
            // 
            this.trianguloLado1Label.AutoSize = true;
            this.trianguloLado1Label.Location = new System.Drawing.Point(19, 63);
            this.trianguloLado1Label.Name = "trianguloLado1Label";
            this.trianguloLado1Label.Size = new System.Drawing.Size(37, 13);
            this.trianguloLado1Label.TabIndex = 0;
            this.trianguloLado1Label.Text = "Lado1";
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Controls.Add(this.LadoCuadradoLabel);
            this.cuadradoTabPage.Controls.Add(this.CuadradoLadotxt);
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Size = new System.Drawing.Size(778, 288);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // LadoCuadradoLabel
            // 
            this.LadoCuadradoLabel.AutoSize = true;
            this.LadoCuadradoLabel.Location = new System.Drawing.Point(18, 34);
            this.LadoCuadradoLabel.Name = "LadoCuadradoLabel";
            this.LadoCuadradoLabel.Size = new System.Drawing.Size(31, 13);
            this.LadoCuadradoLabel.TabIndex = 2;
            this.LadoCuadradoLabel.Text = "Lado";
            // 
            // CuadradoLadotxt
            // 
            this.CuadradoLadotxt.Location = new System.Drawing.Point(86, 28);
            this.CuadradoLadotxt.Name = "CuadradoLadotxt";
            this.CuadradoLadotxt.Size = new System.Drawing.Size(160, 20);
            this.CuadradoLadotxt.TabIndex = 0;
            this.CuadradoLadotxt.Leave += new System.EventHandler(this.CuadradoLadotxt_Leave);
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Controls.Add(this.circuloRadiotxt);
            this.circuloTabPage.Controls.Add(this.circuloRadioLabel);
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Size = new System.Drawing.Size(778, 288);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // circuloRadiotxt
            // 
            this.circuloRadiotxt.Location = new System.Drawing.Point(141, 46);
            this.circuloRadiotxt.Name = "circuloRadiotxt";
            this.circuloRadiotxt.Size = new System.Drawing.Size(100, 20);
            this.circuloRadiotxt.TabIndex = 1;
            this.circuloRadiotxt.Leave += new System.EventHandler(this.circuloRadiotxt_Leave);
            // 
            // circuloRadioLabel
            // 
            this.circuloRadioLabel.AutoSize = true;
            this.circuloRadioLabel.Location = new System.Drawing.Point(55, 46);
            this.circuloRadioLabel.Name = "circuloRadioLabel";
            this.circuloRadioLabel.Size = new System.Drawing.Size(35, 13);
            this.circuloRadioLabel.TabIndex = 0;
            this.circuloRadioLabel.Text = "Radio";
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Controls.Add(this.rectangulo2Lado2Txt);
            this.rectanguloTabPage.Controls.Add(this.rectanguloLado1Txt);
            this.rectanguloTabPage.Controls.Add(this.rectanguloLado2Label);
            this.rectanguloTabPage.Controls.Add(this.rectanguloLado1Label);
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Size = new System.Drawing.Size(778, 288);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            this.rectanguloTabPage.Click += new System.EventHandler(this.rectanguloTabPage_Click);
            // 
            // rectangulo2Lado2Txt
            // 
            this.rectangulo2Lado2Txt.Location = new System.Drawing.Point(98, 72);
            this.rectangulo2Lado2Txt.Name = "rectangulo2Lado2Txt";
            this.rectangulo2Lado2Txt.Size = new System.Drawing.Size(100, 20);
            this.rectangulo2Lado2Txt.TabIndex = 3;
            this.rectangulo2Lado2Txt.Leave += new System.EventHandler(this.rectangulo2Lado2Txt_Leave);
            // 
            // rectanguloLado1Txt
            // 
            this.rectanguloLado1Txt.Location = new System.Drawing.Point(98, 28);
            this.rectanguloLado1Txt.Name = "rectanguloLado1Txt";
            this.rectanguloLado1Txt.Size = new System.Drawing.Size(100, 20);
            this.rectanguloLado1Txt.TabIndex = 2;
            this.rectanguloLado1Txt.Leave += new System.EventHandler(this.rectanguloLado1Txt_Leave);
            // 
            // rectanguloLado2Label
            // 
            this.rectanguloLado2Label.AutoSize = true;
            this.rectanguloLado2Label.Location = new System.Drawing.Point(20, 79);
            this.rectanguloLado2Label.Name = "rectanguloLado2Label";
            this.rectanguloLado2Label.Size = new System.Drawing.Size(37, 13);
            this.rectanguloLado2Label.TabIndex = 1;
            this.rectanguloLado2Label.Text = "Lado2";
            // 
            // rectanguloLado1Label
            // 
            this.rectanguloLado1Label.AutoSize = true;
            this.rectanguloLado1Label.Location = new System.Drawing.Point(18, 35);
            this.rectanguloLado1Label.Name = "rectanguloLado1Label";
            this.rectanguloLado1Label.Size = new System.Drawing.Size(37, 13);
            this.rectanguloLado1Label.TabIndex = 0;
            this.rectanguloLado1Label.Text = "Lado1";
            // 
            // pentagonoTabPage
            // 
            this.pentagonoTabPage.Controls.Add(this.pentagonoApotemaTxt);
            this.pentagonoTabPage.Controls.Add(this.pentagonoLadoLabel);
            this.pentagonoTabPage.Controls.Add(this.pentagoApotemaLabel);
            this.pentagonoTabPage.Controls.Add(this.pentagonoLadoLabe);
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Size = new System.Drawing.Size(778, 288);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
            // 
            // pentagonoApotemaTxt
            // 
            this.pentagonoApotemaTxt.Location = new System.Drawing.Point(148, 50);
            this.pentagonoApotemaTxt.Name = "pentagonoApotemaTxt";
            this.pentagonoApotemaTxt.Size = new System.Drawing.Size(100, 20);
            this.pentagonoApotemaTxt.TabIndex = 3;
            this.pentagonoApotemaTxt.Leave += new System.EventHandler(this.pentagonoApotemaTxt_Leave);
            // 
            // pentagonoLadoLabel
            // 
            this.pentagonoLadoLabel.Location = new System.Drawing.Point(148, 22);
            this.pentagonoLadoLabel.Name = "pentagonoLadoLabel";
            this.pentagonoLadoLabel.Size = new System.Drawing.Size(100, 20);
            this.pentagonoLadoLabel.TabIndex = 2;
            this.pentagonoLadoLabel.Leave += new System.EventHandler(this.pentagonoLadoLabel_Leave);
            // 
            // pentagoApotemaLabel
            // 
            this.pentagoApotemaLabel.AutoSize = true;
            this.pentagoApotemaLabel.Location = new System.Drawing.Point(27, 58);
            this.pentagoApotemaLabel.Name = "pentagoApotemaLabel";
            this.pentagoApotemaLabel.Size = new System.Drawing.Size(49, 13);
            this.pentagoApotemaLabel.TabIndex = 1;
            this.pentagoApotemaLabel.Text = "Apotema";
            // 
            // pentagonoLadoLabe
            // 
            this.pentagonoLadoLabe.AutoSize = true;
            this.pentagonoLadoLabe.Location = new System.Drawing.Point(24, 30);
            this.pentagonoLadoLabe.Name = "pentagonoLadoLabe";
            this.pentagonoLadoLabe.Size = new System.Drawing.Size(31, 13);
            this.pentagonoLadoLabe.TabIndex = 0;
            this.pentagonoLadoLabe.Text = "Lado";
            // 
            // calcularPerimetroBtn
            // 
            this.calcularPerimetroBtn.Location = new System.Drawing.Point(462, 390);
            this.calcularPerimetroBtn.Name = "calcularPerimetroBtn";
            this.calcularPerimetroBtn.Size = new System.Drawing.Size(122, 23);
            this.calcularPerimetroBtn.TabIndex = 2;
            this.calcularPerimetroBtn.Text = "Calcular Perimetro";
            this.calcularPerimetroBtn.UseVisualStyleBackColor = true;
            this.calcularPerimetroBtn.Click += new System.EventHandler(this.calcularPerimetroBtn_Click);
            // 
            // calcularAreaBtn
            // 
            this.calcularAreaBtn.Location = new System.Drawing.Point(595, 390);
            this.calcularAreaBtn.Name = "calcularAreaBtn";
            this.calcularAreaBtn.Size = new System.Drawing.Size(132, 23);
            this.calcularAreaBtn.TabIndex = 3;
            this.calcularAreaBtn.Text = "Calcular Area";
            this.calcularAreaBtn.UseVisualStyleBackColor = true;
            this.calcularAreaBtn.Click += new System.EventHandler(this.calcularAreaBtn_Click);
            // 
            // Poligonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcularAreaBtn);
            this.Controls.Add(this.calcularPerimetroBtn);
            this.Controls.Add(this.figurasTabControl);
            this.Controls.Add(this.tituloLabel);
            this.Name = "Poligonos";
            this.Text = "Calculadora de Poligonos";
            this.Load += new System.EventHandler(this.Poligonos_Load);
            this.figurasTabControl.ResumeLayout(false);
            this.trianguloTabPage.ResumeLayout(false);
            this.trianguloTabPage.PerformLayout();
            this.cuadradoTabPage.ResumeLayout(false);
            this.cuadradoTabPage.PerformLayout();
            this.circuloTabPage.ResumeLayout(false);
            this.circuloTabPage.PerformLayout();
            this.rectanguloTabPage.ResumeLayout(false);
            this.rectanguloTabPage.PerformLayout();
            this.pentagonoTabPage.ResumeLayout(false);
            this.pentagonoTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TabControl figurasTabControl;
        private System.Windows.Forms.TabPage trianguloTabPage;
        private System.Windows.Forms.TabPage cuadradoTabPage;
        private System.Windows.Forms.TabPage circuloTabPage;
        private System.Windows.Forms.TabPage rectanguloTabPage;
        private System.Windows.Forms.TabPage pentagonoTabPage;
        private System.Windows.Forms.Button calcularPerimetroBtn;
        private System.Windows.Forms.Button calcularAreaBtn;
        private System.Windows.Forms.TextBox CuadradoLadotxt;
        private System.Windows.Forms.TextBox TrianguloTxtLado3;
        private System.Windows.Forms.TextBox TrianguloTxtLado2;
        private System.Windows.Forms.TextBox TrianguloTxtLado1;
        private System.Windows.Forms.Label trianguloLado3Labe;
        private System.Windows.Forms.Label trianguloLado1Labe;
        private System.Windows.Forms.Label trianguloLado1Label;
        private System.Windows.Forms.Label trianguloAlturaLabel;
        private System.Windows.Forms.Label trianguloBaseLabel;
        private System.Windows.Forms.Label LadoCuadradoLabel;
        private System.Windows.Forms.TextBox circuloRadiotxt;
        private System.Windows.Forms.Label circuloRadioLabel;
        private System.Windows.Forms.TextBox rectangulo2Lado2Txt;
        private System.Windows.Forms.TextBox rectanguloLado1Txt;
        private System.Windows.Forms.Label rectanguloLado2Label;
        private System.Windows.Forms.Label rectanguloLado1Label;
        private System.Windows.Forms.TextBox pentagonoApotemaTxt;
        private System.Windows.Forms.TextBox pentagonoLadoLabel;
        private System.Windows.Forms.Label pentagoApotemaLabel;
        private System.Windows.Forms.Label pentagonoLadoLabe;
        private System.Windows.Forms.TextBox trianguloTxrBase;
        private System.Windows.Forms.TextBox TrianguloTxtAltura;
    }
}

