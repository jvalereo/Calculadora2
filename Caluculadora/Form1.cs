using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caluculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Declarando o if, código de comparação

            int periodo = DateTime.Now.Hour;

            if(periodo >=12 && periodo<= 18){

             lblPeriodo.Text = "Boa tarde!";


            }
            else if(periodo > 18 && periodo <=23){

                 lblPeriodo.Text = "Boa Noite!";

             }

            else
            {

                lblPeriodo.Text = "Bom dia!";
            }

            //fim do progarma
        }


        private void BtnSoma_Click(object sender, EventArgs e)
        {
            // Aula Revisão Calculadora Etec de São Pualo 
            // Aluno Jonas Valereo Técnico em Informátia

            //Declarando as variavies e o codigo da adição,

            //Exemplo de aplicação com dois codigo diferentes, resultado final aguais

            //Exemplo Codigo 1

            /* int num1, num2, media, resultado;

            num1 = Convert.ToInt32(textNum1.Text);
            num2 = Convert.ToInt32(textNum2.Text);
            resultado = num1 + num2;
            media = resultado / 2;

            textMedia.Text = media.ToString();

            MessageBox.Show("O resultado: " + resultado); */


            //Exemplo Codigo 2 

            int num1 = int.Parse(textNum1.Text);
            int num2 = int.Parse(textNum2.Text);
            int resultado = num1 + num2;
            int media = resultado / 2;

            textMedia.Text = media.ToString();

            MessageBox.Show("O resultado: " + resultado, "Messagem",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             
            //fim dor programa


        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            //Declarando a variaveis e o código Subtração

            int num1 = int.Parse(textNum1.Text);
            int num2 = int.Parse(textNum2.Text);
            int resultado = num1 - num2;
            int media = resultado / 2;

            //Declarando textMedia 

            textMedia.Text = media.ToString();

            //Declarando comando imprimir MessageBox

            MessageBox.Show("O Restultado: " + resultado, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //fim do programa

        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            //Declarando a variaveis e o codigo Multiplicação

            int num1 = int.Parse(textNum1.Text);
            int num2 = int.Parse(textNum2.Text);
            int resultado = num1 * num2;
            int media = resultado / 2;


            //Declarando o código textMedia imprimir na textbox

            textMedia.Text = media.ToString();

            //Declarando o código MessageBox, imprimir resultado

            MessageBox.Show("O Resultado: " + resultado, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 
            //fim do progarma

        }

        private void BtnDivisão_Click(object sender, EventArgs e)
        {
            //Declarando a variaveis e codigo Divisão

            int num1 = int.Parse(textNum1.Text);
            int num2 = int.Parse(textNum2.Text);
            int resultado = num1 / num2;
            int media = resultado / 2; 

            //Declarando o codigo textmedia, textbox, impirmir na tela

            textMedia.Text = media.ToString();

            //Declarando MessageBox, imprimi  resultado 

            MessageBox.Show("O Resultado: " + resultado, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //fim do programa 

        }

        private void BtnLimpa_Click(object sender, EventArgs e)
        {
            //Declarando o codido limpa as textbox

            textNum1.Text = " ";
            textNum2.Text = " ";
            textMedia.Text = " ";

           

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair

            Close();

        }

         //fim do programa
    }
}
