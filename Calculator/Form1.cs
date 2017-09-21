using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        public float firstNum;
        public float secondNum;
        public char currentOperator;

        Sorter sorter;

        public Calculator()
        {
            InitializeComponent();       
            sorter = new Sorter();           
        }
   
        private void Calculator_Load(object sender, EventArgs e)
        {
        }
          
        // Function that handles the creation of an operator between the 2 numbers.
        private void buttonOperatorClick(object sender, EventArgs e)
        {
            char c = System.Convert.ToChar((sender as Button).Text);      
            displayBox.Text += " "+c;
        }

        // Function that takes the whole array of both numbers and operators and does the math.
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string[] words = displayBox.Text.Split(' ');

            float.TryParse("15.44", out var test);
               
            float.TryParse(words[0], out firstNum);
            char.TryParse(words[1], out currentOperator);
            float.TryParse(words[2], out secondNum);

            sorter.feedFunction(firstNum, secondNum, currentOperator);

            displayBox.Text = sorter.result.ToString();
        }

        // Function that handles the input from the number buttons.
        private void button1_Click(object sender, EventArgs e)
        {
            if (displayBox.Text.Length > 1)
            {
                char last = displayBox.Text[displayBox.Text.Length - 1];

                if (last == '*' || last == '+' || last == '/' || last == '-')
                {
            
                    displayBox.Text += " ";
                }
            }
            displayBox.Text += (sender as Button).Text;
        }
    }
}
