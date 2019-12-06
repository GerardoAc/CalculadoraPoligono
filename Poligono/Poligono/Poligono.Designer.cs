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
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.calcularPerimetroBtn = new System.Windows.Forms.Button();
            this.calcularAreaBtn = new System.Windows.Forms.Button();
            this.figurasTabControl.SuspendLayout();
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
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Size = new System.Drawing.Size(778, 288);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
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
    }
}

