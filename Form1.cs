using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoradoTiagoL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Operacao
        {
            Soma,
            Subtrai,
            Divide,
            Multiplica,
            Nenhuma
        }

        static Operacao ultimaOperacao = Operacao.Nenhuma;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox0_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0) 
            {
                textBoxDisplay.Text =
                    textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttomLimpar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            if(ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Soma;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void fazerCalculo(Operacao ultimaOperacao)
        {
            List<double> ListaDeNumeros = new List<double>();
            switch (ultimaOperacao)
            { 

                case Operacao.Soma:
                    ListaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                   textBoxDisplay.Text = (ListaDeNumeros[0] + ListaDeNumeros[1]).ToString();
                  break;
                case Operacao.Subtrai:
                ListaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                textBoxDisplay.Text = (ListaDeNumeros[0] - ListaDeNumeros[1]).ToString();
                break;
                case Operacao.Divide:
                ListaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                textBoxDisplay.Text = (ListaDeNumeros[0] / ListaDeNumeros[1]).ToString();
                break;
                case Operacao.Multiplica:
                ListaDeNumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                textBoxDisplay.Text = (ListaDeNumeros[0] * ListaDeNumeros[1]).ToString();
                break;
                case Operacao.Nenhuma:
                break;
                default:
                break;
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Subtrai;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacao.Nenhuma)
            {
                fazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacao.Nenhuma;
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Multiplica;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Divide;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }
    }
}

