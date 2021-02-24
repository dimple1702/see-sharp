using System;

namespace Assignment
{
    abstract class Vehicle
    {
        public abstract void Print();
    }

    class Program : Vehicle
    {
        public int id;
        public string name;
        public static string percentage;

        Program()       // Default Constructor
        {
            Console.WriteLine("In a Default Constructor");
        }

        Program(int id, string name)    // Parameterised Constructor
        {
            this.id = id;
            this.name = name;
        }

        Program(Program program)    // Copy Constructor
        {
            this.id = program.id;
            this.name = program.name;
        }

        static Program()        // static constrcutor
        {
            percentage = 80 + "%";
        }

        public void display()       
        {
            Console.WriteLine("My name is {0} and my id is {1}", name, id);
        }
        
        public void grade()
        {
            Console.WriteLine("Percentage:{0}", percentage + "\n");
        }

        public override void Print()
        {
            Console.WriteLine("This is the method from abstract class Vehicle.");
        }

        public unsafe void function()
        {
            int pointerNum = 10;
            int* pointer = &pointerNum;
            Console.WriteLine("Pointer value: " + (int)pointer);
            Console.WriteLine("PointerNumber value: " + pointerNum);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Assignment1 of C#");
            Console.WriteLine("Qs.1: Write a program to display diamond pattern.User will be asked to input number of rows.");

            // Question1
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int whiteSpace = rows - 1;

            for (int i = 1; i < rows; i++)
            {
                for (int spaces = rows; spaces > i; spaces--)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= 2 * i - 1; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }   
            for(int i = 1; i <= rows; i++)
            {
                for(int whitespaces = 1; whitespaces < i; whitespaces++)
                {
                    Console.Write(" ");
                }
                for(int stars = 1; stars <= (rows * 2 - (2 * i - 1)); stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Question 2
            Console.WriteLine("\nQs.2: Write a c# program to swap two numbers without using third variable.");
            Console.Write("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping, entered numbers are, num1 = {0}, num2 = {1}", num1, num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swapping, entered numbers are, num1 = {0}, num2 = {1}", num1, num2);
            
            // Question 3
            Console.WriteLine("\nQs.3: Write a c# program to check if a number is palindrome.User will be asked to input number.");
            Console.Write("Enter the number to check if it a palindrome: ");
            int OriginalNumber = Convert.ToInt32(Console.ReadLine());
            int temp = OriginalNumber;
            int ReveresedNumber = 0;
            while(temp > 0)
            {
                int rem = temp % 10;
                ReveresedNumber = ReveresedNumber * 10 + rem;
                temp /= 10;
            }
            if(OriginalNumber == ReveresedNumber)
            {
                Console.WriteLine("Entered Number is Palindrome.");
            }
            else
            {
                Console.WriteLine("Entered Number is not a Palindrome.");
            }

            // Question 4
            Console.WriteLine("\n Qs.4: Implement the concept of asbstarct class (having abstarct as well non-abstarct methods) and interfaces in a sample class.");
            Vehicle vehicle = new Program();
            vehicle.Print();

            //Question 5
            Console.WriteLine("\nQs.5: Implement all types of constructors for a class.");
            Program defaultConst = new Program();
            
            Program parameterisedConst = new Program(3, "Dimple Verma");
            Console.WriteLine("\nParameterised Constructor invoked.");
            parameterisedConst.display();
            
            Program copyConst = new Program(parameterisedConst);
            Console.WriteLine("\nCopy Constructor invoked.");
            copyConst.display();

            Program staticConst = new Program();
            Console.WriteLine("\nStatic Constructor invoked.");
            staticConst.grade();

            // Question 6
            Console.WriteLine("\n Qs.6: Write a code to throw exception and handle using try-catch-finally block.");
            Console.Write("Enter the value of divident: ");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int ans;
            try
            {
                ans = divident / divisor;
                Console.WriteLine("Will it execute?");
                Console.WriteLine("Answer after division: " + ans);
            }
            catch(Exception)
            {
                Console.WriteLine("Exception Occured");
            }
            finally
            {
                Console.WriteLine("Finally Block will definitely execute.");
            }

            // Question 7
            Console.WriteLine("\n Qs.7: Given a string, write a method that returns new string with reverted words order.");
            Console.Write("Enter any string: ");
            string str = Console.ReadLine();
            int start = 0, end = str.Length;
            string result = "";

            int first = 0, last = -1;
            while(first < end)
            {
                if(str[first] == ' ')
                {
                    start = first - 1;
                    while(start != last)
                    {
                        result += str[start--];
                    }
                    result += " ";
                    last = first;
                }
                first++;
            }
            start = end - 1;
            while(start != last)
            {
                result += str[start--];
            }
            Console.WriteLine("Reversed string is: " + result);

            // Question 8
            Console.WriteLine("\nQs.8: Write a method that checks if given number (positive integer) contains digit 3. " +
                "Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.");
            Console.Write("Enter a number: ");
            int checkNum = Convert.ToInt32(Console.ReadLine());
            bool flag = false;

            while(checkNum > 0)
            {
                if(checkNum % 10 == 3)
                {
                    flag = true;
                }
                checkNum /= 10;
            }

            if (flag)
            {
                Console.WriteLine("Entered number contains digit 3.");
            }
            else
            {
                Console.WriteLine("Entered number doesnot contain digit 3.");
            }

            // Question 9
            Console.WriteLine("\nQs.9: Create a pointer in c#.");
            Program ptrFunction = new Program();
            ptrFunction.function();

            // Question 10
            Console.WriteLine("\nQs.10: Create a method which will reverse the order of any array.");
            Console.Write("Enter the number of elements in the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Console.Write("Enter the elements of the array: ");
            for(int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int startIndex = 0;
            int endIndex = size - 1;
            int swap;

            while(startIndex < endIndex)
            {
                swap = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = swap;
                startIndex++;
                endIndex--;
            }

            Console.Write("Reversed array is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }

    }
}
//Custom attribute

