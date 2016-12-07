using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            dato1.Clear();
            dato2.Clear();
            resultado.Clear();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            string operaciones = Operadores.Text;
            double num1 = double.Parse(dato1.Text);
            double num2 = double.Parse(dato2.Text);

            double result = 0;

            switch (operaciones)  {

                case "SUMA" :

                    result = num1 + num2;
                    break;

                case "RESTA":

                    result = num1 - num2;

                    break;

                case "DIVISION":

                    
                        result = num1 / num2;
                    
                    break;

                case "MULTIPLICACION":

                    result = num1 * num2;
                    break;
              
                default:
                    break;
            }

            resultado.Text = result.ToString();

        }

        private void Operadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
