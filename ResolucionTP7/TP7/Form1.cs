using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7
{
    public partial class Form1 : Form
    {
        Calculadora miCalculadora;
        float numero1f, numero2f;
        char operador;
        public Form1()
        {
            InitializeComponent();
            miCalculadora = new Calculadora();
        }

        private void button9_Click(object sender, EventArgs e)// boton 4
        {
            tbPantalla.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)//boton 0
        {
            tbPantalla.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)//boton 1
        {
            tbPantalla.Text += "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "3";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)// boton +
        {
            operador = '+';
            numero1f = float.Parse(tbPantalla.Text);
            tbPantalla.Clear();
        }

        private void botonMenos_Click(object sender, EventArgs e)
        {
            operador = '-';
            numero1f = float.Parse(tbPantalla.Text);
            tbPantalla.Clear();
        }

        private void botonPor_Click(object sender, EventArgs e)
        {
            operador = '*';
            numero1f = float.Parse(tbPantalla.Text);
            tbPantalla.Clear();
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            operador = '/';
            numero1f = float.Parse(tbPantalla.Text);
            tbPantalla.Clear();
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            tbPantalla.Text += ".";
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            tbPantalla.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            numero2f = float.Parse(tbPantalla.Text);
            tbPantalla.Clear();
            miCalculadora = new Calculadora(numero1f, numero2f);
            switch (operador)
            {
                case '+':
                    tbPantalla.Text = miCalculadora.Suma().ToString();
                    break;

                case '-':
                    tbPantalla.Text = miCalculadora.Resta().ToString();
                    break;

                case '*':
                    tbPantalla.Text = miCalculadora.Multiplicacion().ToString();
                    break;

                case '/':
                    if (numero2f != 0)
                    {
                        tbPantalla.Text = miCalculadora.Division().ToString();
                    }
                    else
                    {
                        Console.WriteLine("Error. No existe la division entre cero");
                    }
                    break;
            }
        }
    }
}
