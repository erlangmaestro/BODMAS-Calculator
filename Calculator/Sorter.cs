using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Sorter
    {
        public Sorter()
        {  
            mathOperator = 'c';
        }

        public float result { get; set; }
        public float numberOne { get; set; }
        public float numberTwo { get; set; }
        public char mathOperator { get; set; }

        // Function that is called when calculations are needed, assigns the member variables and calls doMath.
        public void feedFunction(float firstNum, float secondNum, char mathOp)
        {    
            numberOne = firstNum;
            numberTwo = secondNum;
            mathOperator = mathOp;
            doMath();
        }

        // Checks what operator we are given and does the math between the number on its left and right.
        public void doMath()
        {
            switch(mathOperator)
            {
                case '+':
                    result = numberOne + numberTwo;
                    break;
                case '-':
                    result = numberOne - numberTwo;
                    break;
                case '/':
                    result = numberOne / numberTwo;
                    break;
                case '*':
                    result = numberOne * numberTwo;
                    break;
            }
        }
    }
}
