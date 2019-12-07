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
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.ResultadoPerimetroLabel = new System.Windows.Forms.Label();
            this.txtLadoCuadrado = new System.Windows.Forms.TextBox();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.calcularPerimetroBtn = new System.Windows.Forms.Button();
            this.calcularAreaBtn = new System.Windows.Forms.Button();
            this.trianguloLado1Label = new System.Windows.Forms.Label();
            this.trianguloLado1Labe = new System.Windows.Forms.Label();
            this.trianguloLado3Labe = new System.Windows.Forms.Label();
            this.TrianguloTxtLado1 = new System.Windows.Forms.TextBox();
            this.TrianguloTxtLado2 = new System.Windows.Forms.TextBox();
            this.TrianguloTxtLado3 = new System.Windows.Forms.TextBox();
            this.figurasTabControl.SuspendLayout();
            this.trianguloTabPage.SuspendLayout();
            this.cuadradoTabPage.SuspendLayout();
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
            // 
            // trianguloTabPage
            // 
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
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Controls.Add(this.ResultadoPerimetroLabel);
            this.cuadradoTabPage.Controls.Add(this.txtLadoCuadrado);
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Size = new System.Drawing.Size(778, 288);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // ResultadoPerimetroLabel
            // 
            this.ResultadoPerimetroLabel.AutoSize = true;
            this.ResultadoPerimetroLabel.Location = new System.Drawing.Point(533, 175);
            this.ResultadoPerimetroLabel.Name = "ResultadoPerimetroLabel";
            this.ResultadoPerimetroLabel.Size = new System.Drawing.Size(35, 13);
            this.ResultadoPerimetroLabel.TabIndex = 1;
            this.ResultadoPerimetroLabel.Text = "label1";
            // 
            // txtLadoCuadrado
            // 
            this.txtLadoCuadrado.Location = new System.Drawing.Point(37, 27);
            this.txtLadoCuadrado.Name = "txtLadoCuadrado";
            this.txtLadoCuadrado.Size = new System.Drawing.Size(160, 20);
            this.txtLadoCuadrado.TabIndex = 0;
            this.txtLadoCuadrado.Text = "Valor Lado";
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Size = new System.Drawing.Size(778, 288);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Size = new System.Drawing.Size(778, 288);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // pentagonoTabPage
            // 
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Size = new System.Drawing.Size(778, 288);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
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
            // trianguloLado1Labe
            // 
            this.trianguloLado1Labe.AutoSize = true;
            this.trianguloLado1Labe.Location = new System.Drawing.Point(19, 96);
            this.trianguloLado1Labe.Name = "trianguloLado1Labe";
            this.trianguloLado1Labe.Size = new System.Drawing.Size(37, 13);
            this.trianguloLado1Labe.TabIndex = 1;
            this.trianguloLado1Labe.Text = "Lado2";
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
            // TrianguloTxtLado1
            // 
            this.TrianguloTxtLado1.Location = new System.Drawing.Point(79, 56);
            this.TrianguloTxtLado1.Name = "TrianguloTxtLado1";
            this.TrianguloTxtLado1.Size = new System.Drawing.Size(100, 20);
            this.TrianguloTxtLado1.TabIndex = 3;
            // 
            // TrianguloTxtLado2
            // 
            this.TrianguloTxtLado2.Location = new System.Drawing.Point(79, 96);
            this.TrianguloTxtLado2.Name = "TrianguloTxtLado2";
            this.TrianguloTxtLado2.Size = new System.Drawing.Size(100, 20);
            this.TrianguloTxtLado2.TabIndex = 4;
            // 
            // TrianguloTxtLado3
            // 
            this.TrianguloTxtLado3.Location = new System.Drawing.Point(79, 128);
            this.TrianguloTxtLado3.Name = "TrianguloTxtLado3";
            this.TrianguloTxtLado3.Size = new System.Drawing.Size(100, 20);
            this.TrianguloTxtLado3.TabIndex = 5;
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
        private System.Windows.Forms.TextBox txtLadoCuadrado;
        private System.Windows.Forms.Label ResultadoPerimetroLabel;
        private System.Windows.Forms.TextBox TrianguloTxtLado3;
        private System.Windows.Forms.TextBox TrianguloTxtLado2;
        private System.Windows.Forms.TextBox TrianguloTxtLado1;
        private System.Windows.Forms.Label trianguloLado3Labe;
        private System.Windows.Forms.Label trianguloLado1Labe;
        private System.Windows.Forms.Label trianguloLado1Label;
    }
}

