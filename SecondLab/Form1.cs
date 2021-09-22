using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void СalculateButton_Click(object sender, EventArgs e)
        {
            String equation = EquationInputBox.Text;

            int result = Calculator.Calculate(equation);

            MessageBox.Show("Результат: " + result);
        }
    }
}
