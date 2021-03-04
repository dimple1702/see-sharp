using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class SampleClass
    {
        public int number1 = 0, number2 = 0;
        public SampleClass()
        {
            this.number1 = 5;
            this.number2 = 5;
        }

        public SampleClass(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        /*  Just another way to define a variable.
         public int number3 {        
            get
            {
                return number1 + number2;
            }
            set{
                number3 = value;
            }
        }
        */
        

        public int Calculate()
        {
            return this.number1 + this.number2;
        }

        public string someValue()
        {
            return "Hey!! We had just refered this class to another class in a different project!! :)";
        }
    }
}