using System;
using System.Windows.Forms;

namespace Calculo
{
    public partial class Form1 : Form
    {
        double area = 0, ladoCaixa = 0, alturaCaixa=0, ladoFolha = 0, delta = 0, b = 0, a = 0, c = 0,  x1 = 0, x2 = 0;

        private void txtBoxArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxArea.Clear();
            txtBoxLado.Clear();
            txtBoxX1.Clear();
            txtBoxX2.Clear();
            txtBoxLadoCaixa.Clear();
            txtBoxAlturaCaixa.Clear();               
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {

                if (txtBoxArea.Text == "")
                {
                    MessageBox.Show("Digite um valor para a área do quadrado");
                    txtBoxArea.Clear();
                }
                else if (txtBoxArea.Text == "0")
                {
                    MessageBox.Show("Valor é Inválido. Digite outro valor para a área");
                    txtBoxArea.Clear();
                }
                
                ladoFolha =Math.Sqrt(Convert.ToDouble(txtBoxArea.Text)); // recebendo o valor da área e calculando a raiz quadrada

                area = (ladoFolha * ladoFolha);  // atribuindo o valor da área
                txtBoxLado.Text = ladoFolha.ToString();//Imprimindo na tela o valor do lado da folha
               
                b = -(ladoFolha * 2); 
                b = (b - (2 * ladoFolha)) * 2; // calculando o termo b
                a = (4 * 3);                   // calculando o termo a           
                c = area;                      // calculando o termo c -> atribuindo a variável c o valor de área

                delta = Math.Pow(b, 2) - (4 * a * c); // calculando o valor de delta

                x1 = (-(b) + Math.Sqrt(delta)); // Cálculo do valor do X1
                x1 = x1 / (2 * a);
                txtBoxX1.Text = x1.ToString(); // imprimindo na tela o valor de x1

                x2 = (-(b) - Math.Sqrt(delta)); // Cálculando o valor do X2
                x2 = x2 / (2 * a);
                txtBoxX2.Text = x2.ToString(); // imprimindo na tela o valor de x2

                /*Calculando o Lado da Caixa
                Verificando se o valor de x2 é valido,
                senão o lado da caixa é feito pelo x1
                */
                ladoCaixa = ladoFolha - (x2 * 2); 
                if(ladoCaixa == 0)
                {
                    ladoCaixa = ladoFolha - (x1 * 2);
                    alturaCaixa = x1;
                    txtBoxAlturaCaixa.Text = x1.ToString();
                }
                txtBoxLadoCaixa.Text = ladoCaixa.ToString();
                
                //Calculando a altura da Caixa
                alturaCaixa = x2;
                txtBoxAlturaCaixa.Text = alturaCaixa.ToString();            
                     
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());

            }
        }
    }
}
