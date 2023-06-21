using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form {
        
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button18_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button16_Click(object sender, EventArgs e) {
            if (TxtResultado.Text != "") {
                TxtResultado.Text = TxtResultado.Text + ".";
            }
        }

        private void button12_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e) {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e) {
            if (TxtResultado.Text != "") {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
            TxtResultado.Text = "";
            operacao = "SUB";
            labelOperacao.Text = "-";
            }
        }

        private void button9_Click(object sender, EventArgs e) {
            if (TxtResultado.Text != "") {
                //aqui vamos pegar o valor1
                //armazenar o texto do TxtResultado
                //dentro dela
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                //limpando o TxtResultado
                TxtResultado.Text = "";
                //informa para o programa que é uma soma
                operacao = "SOMA";
                //informa para o usuario a operação que estamos usando
                labelOperacao.Text = "+";
            }
        }

        private void button14_Click(object sender, EventArgs e) {
            if (TxtResultado.Text != "") {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "MULT";
                labelOperacao.Text = "X";
            }
        }

        private void button17_Click(object sender, EventArgs e) {
            if (TxtResultado.Text != "") {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "DIV";
                labelOperacao.Text = "/";
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            valor2 = 0;
            TxtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) {
            valor1 = 0;
            valor2 = 0;
            TxtResultado.Text = "";
            operacao = "";
            labelOperacao.Text = "";
        }

        private void button19_Click(object sender, EventArgs e) {
            if (TxtResultado.Text != "") {
                //pegando o valor2
                valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                //verificando a soma de valor1 e valor2 no campo de texto
                //da calculadora, lembrando que a calculadora esta uma string
                //por isso estamos convertendo para string o que tinhamos convertido 
                //em decimal
                if (operacao == "SOMA") {
                    TxtResultado.Text = Convert.ToString(valor1 + valor2);
                } else if (operacao == "SUB") {
                    TxtResultado.Text = Convert.ToString(valor1 - valor2);
                } else if (operacao == "MULT") {
                    TxtResultado.Text = Convert.ToString(valor1 * valor2);
                } else if (operacao == "DIV") {
                    TxtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }
    }
}
