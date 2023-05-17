using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
  
    public partial class FormCalculadora : Form
    {
        private string currentNumber = string.Empty;
        private double result = 0;
        private char operation;
        private object txtDisplay;

        public FormCalculadora()
        {
            //InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            // Configuración inicial de la calculadora
            txtDisplay = "0";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Manejador de eventos para los botones numéricos (0-9)
            Button button = (Button)sender;
            currentNumber += button.Text;
            txtDisplay = currentNumber;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            // Manejador de eventos para los botones de operación (+, -, *, /)
            Button button = (Button)sender;
            operation = button.Text[0];
            result = double.Parse(currentNumber);
            currentNumber = string.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Manejador de eventos para el botón "="
            double secondNumber = double.Parse(currentNumber);

            switch (operation)
            {
                case '+':
                    result += secondNumber;
                    break;
                case '-':
                    result -= secondNumber;
                    break;
                case '*':
                    result *= secondNumber;
                    break;
                case '/':
                    result /= secondNumber;
                    break;
            }

            txtDisplay = result.ToString();
            currentNumber = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Manejador de eventos para el botón "C"
            currentNumber = string.Empty;
            result = 0;
            txtDisplay = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnDivi_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarx_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
