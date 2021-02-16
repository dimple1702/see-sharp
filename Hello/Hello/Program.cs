using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is my first C# program"); 
                    //WriteLine makes the pointer will point to next line after printing the specified content
            Console.Write("Enter the value of num: ");
                    // Write makes the pointer point in the same line after printing the specified content
            int num;    // Declaring a Variable
            num = Convert.ToInt32(Console.ReadLine());  // Taking input from user
            Console.WriteLine("You have entered 'num': " + num);  // You can concatenate the strings and data
            
            int num1 = 2; // Declaring and initializing a variable
            Console.WriteLine("Value of num1 is: " + num1);

            num = 10;   // you can modify the value of variable
            Console.WriteLine("Value of num becomes: " + num);


            double d1 = num1;
            Console.WriteLine("num1 in double form: " + d1);    // Implicit type-conversion

            double d2 = 123.45;
            int num2 = (int)d2;     // Explicit type-conversion
            Console.WriteLine("double d2 in integer form: " + num2);


            const double pi = 3.14159;

            // constant declaration 
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.WriteLine("Radius: " + r + ", Area: " + areaCircle);

            // Odd-Even
            Console.WriteLine("\nEnter a number to check if it is even or odd");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine("{0} is Even", number);
            }
            else
            {
                Console.WriteLine("{0} is Odd", number);
            }

            // practicing Ternary Operation
            string result = number % 2 == 0 ? " is Even" : " is Odd";
            Console.WriteLine(number + result);


            // Greatest of three numbers- practicing nested if-else
            Console.WriteLine("\nEnter three numbers to find greatest of three numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if(a > b && a > c)
            {
                Console.WriteLine("{0} is greatest of all the entered numbers.", a);
            }
            else
            {
                if( b > c)
                {
                    Console.WriteLine("{0} is greatest of all the entered numbers.", b);
                }
                else
                {
                    Console.WriteLine("{0} is greatest of all the entered numbers.", c);
                }
            }

            // Pattern- practicing for loop
            Console.WriteLine("\nPattern");
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            // Switch-Case
            Console.WriteLine("\n Switch Statements: ");
            Console.Write("Enter a number to find day of week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("\nMonday ");
                    break;
                case 2:
                    Console.WriteLine("\nTuesday ");
                    break;
                case 3:
                    Console.WriteLine("\nWednesday ");
                    break;
                case 4:
                    Console.WriteLine("\nThursday ");
                    break;
                case 5:
                    Console.WriteLine("\nFriday ");
                    break;
                case 6:
                    Console.WriteLine("\nSaturday ");
                    break;
                case 7:
                    Console.WriteLine("\nSunday ");
                    break;
                default:
                    Console.WriteLine("\n There are only 7 days in a week ");
                    break;
            }


            // Reversing a number
            Console.Write("\nEnter a number: ");
            int originalNum = Convert.ToInt32(Console.ReadLine());
            int reversedNum = 0;
            while(originalNum > 0)
            {
                int rem = originalNum % 10;
                reversedNum = reversedNum * 10 + rem;
                originalNum /= 10;
            }
            Console.WriteLine("The entered number {0} in the reversed order is {1}", originalNum, reversedNum);

            // Number is prime or not
            Console.WriteLine("\nEnter a number to check is prime or not");
            int isPrime = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for(int i = 2; i < isPrime/2; i++)
            {
                if(isPrime % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if(isPrime == 1)
            {
                Console.WriteLine("Entered number is neither prime nor composite.");
            }
            else
            {
                if (!flag)
                {
                    Console.WriteLine("Entered number is a prime number");
                }
                else
                {
                    Console.WriteLine("Entered number is not a prime number");
                }
            }

            Console.ReadLine();     // ReadLine methods block the console until user press Enter
        }
    }
}
