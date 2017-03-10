namespace Calculo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtBoxArea = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtBoxLado = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblladoCaixa = new System.Windows.Forms.Label();
            this.lblalturaCaixa = new System.Windows.Forms.Label();
            this.txtBoxX1 = new System.Windows.Forms.TextBox();
            this.txtBoxX2 = new System.Windows.Forms.TextBox();
            this.txtBoxLadoCaixa = new System.Windows.Forms.TextBox();
            this.txtBoxAlturaCaixa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(161, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cálculo de volume de uma caixa";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(73, 96);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(133, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Digite a área do quadrado:";
            this.lblArea.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxArea
            // 
            this.txtBoxArea.Location = new System.Drawing.Point(213, 93);
            this.txtBoxArea.Name = "txtBoxArea";
            this.txtBoxArea.Size = new System.Drawing.Size(176, 20);
            this.txtBoxArea.TabIndex = 2;
            this.txtBoxArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxArea_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(94, 395);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(197, 395);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(26, 141);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(184, 13);
            this.lblLado.TabIndex = 5;
            this.lblLado.Text = "Medida do Lado da folha de papelão:";
            // 
            // txtBoxLado
            // 
            this.txtBoxLado.Location = new System.Drawing.Point(212, 138);
            this.txtBoxLado.Name = "txtBoxLado";
            this.txtBoxLado.Size = new System.Drawing.Size(177, 20);
            this.txtBoxLado.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(312, 395);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(125, 185);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(85, 13);
            this.lblX1.TabIndex = 10;
            this.lblX1.Text = "O valor de x1 é: ";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(125, 231);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(85, 13);
            this.lblX2.TabIndex = 11;
            this.lblX2.Text = "O valor de x2 é: ";
            // 
            // lblladoCaixa
            // 
            this.lblladoCaixa.AutoSize = true;
            this.lblladoCaixa.Location = new System.Drawing.Point(73, 274);
            this.lblladoCaixa.Name = "lblladoCaixa";
            this.lblladoCaixa.Size = new System.Drawing.Size(137, 13);
            this.lblladoCaixa.TabIndex = 12;
            this.lblladoCaixa.Text = "O valor do lado da caixa é: ";
            // 
            // lblalturaCaixa
            // 
            this.lblalturaCaixa.AutoSize = true;
            this.lblalturaCaixa.Location = new System.Drawing.Point(72, 318);
            this.lblalturaCaixa.Name = "lblalturaCaixa";
            this.lblalturaCaixa.Size = new System.Drawing.Size(140, 13);
            this.lblalturaCaixa.TabIndex = 13;
            this.lblalturaCaixa.Text = "O valor da altura da caixa é:";
            // 
            // txtBoxX1
            // 
            this.txtBoxX1.Location = new System.Drawing.Point(212, 182);
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.Size = new System.Drawing.Size(176, 20);
            this.txtBoxX1.TabIndex = 14;
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.Location = new System.Drawing.Point(212, 228);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.Size = new System.Drawing.Size(176, 20);
            this.txtBoxX2.TabIndex = 15;
            // 
            // txtBoxLadoCaixa
            // 
            this.txtBoxLadoCaixa.Location = new System.Drawing.Point(212, 271);
            this.txtBoxLadoCaixa.Name = "txtBoxLadoCaixa";
            this.txtBoxLadoCaixa.Size = new System.Drawing.Size(176, 20);
            this.txtBoxLadoCaixa.TabIndex = 16;
            // 
            // txtBoxAlturaCaixa
            // 
            this.txtBoxAlturaCaixa.Location = new System.Drawing.Point(212, 315);
            this.txtBoxAlturaCaixa.Name = "txtBoxAlturaCaixa";
            this.txtBoxAlturaCaixa.Size = new System.Drawing.Size(176, 20);
            this.txtBoxAlturaCaixa.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 486);
            this.Controls.Add(this.txtBoxAlturaCaixa);
            this.Controls.Add(this.txtBoxLadoCaixa);
            this.Controls.Add(this.txtBoxX2);
            this.Controls.Add(this.txtBoxX1);
            this.Controls.Add(this.lblalturaCaixa);
            this.Controls.Add(this.lblladoCaixa);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtBoxLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBoxArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Cálculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtBoxArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtBoxLado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblladoCaixa;
        private System.Windows.Forms.Label lblalturaCaixa;
        private System.Windows.Forms.TextBox txtBoxX1;
        private System.Windows.Forms.TextBox txtBoxX2;
        private System.Windows.Forms.TextBox txtBoxLadoCaixa;
        private System.Windows.Forms.TextBox txtBoxAlturaCaixa;
    }
}

