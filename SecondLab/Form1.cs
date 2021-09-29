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
            try
            {
                if (IsOnlyNumbers(equation))
                {
                    var result = Calculator.Calculate(equation);

                    EquationInputBox.BackColor = Color.White;
                    MessageBox.Show("Результат: " + result);
                } else
                {
                    EquationInputBox.BackColor = Color.Red;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private bool IsOnlyNumbers(String str)
        {
            str = str.Replace(" ", "");
            for (int i=0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]) && str[i]!='-' && str[i]!='+')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
