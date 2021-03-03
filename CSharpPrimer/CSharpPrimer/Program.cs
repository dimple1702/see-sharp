using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPrimer
{
    class Program
    {
        static void MultipleLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs *= 2;
            petClass.Legs *= 2;

            Console.WriteLine("\nIn MultiLegs method: ");
            Console.WriteLine("A {0} named {1} has {2} Legs", petStruct.Type, petStruct.Name, petStruct.Legs);
            Console.WriteLine("A {0} named {1} has {2} Legs", petClass.Type, petClass.Name, petClass.Legs);

        }

        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Hello, This is my first C# program");
                //WriteLine makes the pointer will point to next line after printing the specified content
                Console.Write("Enter the value of num: ");
                // Write makes the pointer point in the same line after printing the specified content

                string myValue = "Dimple";
                string anotherValue = "Dinky";

                Console.WriteLine("myvalue: " + myValue);
                Console.WriteLine("anotherValue: " + anotherValue);

                anotherValue = myValue;
                Console.WriteLine("anotherValue: " + anotherValue);

                string value = anotherValue + myValue;
                Console.WriteLine("value: " + value);

                int number1 = 12;
                int number2 = 23;
                Console.WriteLine("Addition of numbers: " + (number1 + number2));
                Console.WriteLine("Concatenation of numbers: " + number1 + number2);

                Console.Write("Another way of concatenation: ");
                Console.WriteLine(number1.ToString() + number2.ToString());
                Console.WriteLine("Size of int: " + sizeof(int));

                int converted = Convert.ToInt32("1");
                Console.WriteLine("Converted string: " + converted);

                bool isTrue;
                isTrue = Int32.TryParse("One", out converted);
                bool isFalse = !isTrue;
                Console.WriteLine("Value of isTrue: " + isTrue);

                //Taking input from user
                int num1 = 0, num2 = 0;

                Console.Write("Enter num1: ");
                string sNum1 = Console.ReadLine();

                Console.Write("Enter num2: ");
                string sNum2 = Console.ReadLine();

                Int32.TryParse(sNum1, out num1);
                Int32.TryParse(sNum2, out num2);

                int add = num1 + num2;   // add will be zero if entered data is of any type other than int
                Console.WriteLine("Addition of two entered string: " + add);

                int num;    // Declaring a Variable

                Console.Write("Taking input from user directly as number. Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());  // Taking input from user
                Console.WriteLine("You have entered 'num': " + num);  // You can concatenate the strings and data

                int num3 = 2; // Declaring and initializing a variable
                Console.WriteLine("Value of num1 is: " + num3);

                num = 10;   // you can modify the value of variable
                Console.WriteLine("Value of num becomes: " + num);


                double d1 = num1;
                Console.WriteLine("num1 in double form: " + d1);    // Implicit type-conversion

                double d2 = 123.45;
                int num4 = (int)d2;     // Explicit type-conversion
                Console.WriteLine("double d2 in integer form: " + num4);


                const double pi = 3.14159;

                // constant declaration 
                double r;
                Console.Write("Enter Radius: ");
                r = Convert.ToDouble(Console.ReadLine());

                double areaCircle = pi * r * r;
                Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);

                // Another way to print result
                Console.WriteLine("(Practicing another way to write result) Radius: " + r + ", Area: " + areaCircle);

                // Odd-Even
                Console.Write("\nEnter a number to check if it is even or odd: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Using if-else, ");
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} is Even", number);
                }
                else
                {
                    Console.WriteLine("{0} is Odd", number);
                }

                // practicing Ternary Operation
                string result = number % 2 == 0 ? " is Even" : " is Odd";
                Console.WriteLine("Using Ternary Operation: " + number + result);


                // Greatest of three numbers- practicing nested if-else
                Console.Write("\nEnter three numbers to find greatest of three numbers: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());

                if (a > b && a > c)
                {
                    Console.WriteLine("--> {0} is greatest of all the entered numbers.", a);
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine("--> {0} is greatest of all the entered numbers.", b);
                    }
                    else
                    {
                        Console.WriteLine("--> {0} is greatest of all the entered numbers.", c);
                    }
                }

                // Pattern- practicing for loop
                Console.WriteLine("\nPattern");
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                // Switch-Case
                Console.WriteLine("\nSwitch Statements: ");
                Console.Write("Enter a number to find day of week: ");
                int day = Convert.ToInt32(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Day is: Monday ");
                        break;
                    case 2:
                        Console.WriteLine("Day is:  ");
                        break;
                    case 3:
                        Console.WriteLine("Day is: Wednesday ");
                        break;
                    case 4:
                        Console.WriteLine("Day is: Thursday ");
                        break;
                    case 5:
                        Console.WriteLine("Day is:  ");
                        break;
                    case 6:
                        Console.WriteLine("Day is:  ");
                        break;
                    case 7:
                        Console.WriteLine("Sunday ");
                        break;
                    default:
                        Console.WriteLine("There are only 7 days in a week ");
                        break;
                }


                // Reversing a number
                Console.Write("\nEnter a number: ");
                int originalNum = Convert.ToInt32(Console.ReadLine());
                int temp = originalNum;
                int reversedNum = 0;
                while (temp > 0)
                {
                    int rem = temp % 10;
                    reversedNum = reversedNum * 10 + rem;
                    temp /= 10;
                }
                Console.WriteLine("The entered number {0} in the reversed order is {1}", originalNum, reversedNum);

                // Number is prime or not
                Console.Write("\nEnter a number to check if it is prime or not: ");
                int isPrime = Convert.ToInt32(Console.ReadLine());
                bool flag = false;
                for (int i = 2; i < isPrime / 2; i++)
                {
                    if (isPrime % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (isPrime == 1)
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

                PetStruct dog = new PetStruct();
                dog.Type = PetType.Dog;
                dog.Legs = 4;
                dog.HasFur = true;
                dog.Name = "Shero";

                PetClass duck = new PetClass();
                duck.HasFur = false;
                duck.Legs = 2;
                duck.Type = PetType.Duck;
                duck.Name = "Tweety";

                Console.WriteLine("\nIn Main method, before calling MultipleLegs method: ");
                Console.WriteLine("A {0} named {1} has {2} Legs", dog.Type, dog.Name, dog.Legs);
                Console.WriteLine("A {0} named {1} has {2} Legs", duck.Type, duck.Name, duck.Legs);

                MultipleLegs(dog, duck);

                Console.WriteLine("\nIn Main method, after calling MultipleLegs method: ");
                Console.WriteLine("A {0} named {1} has {2} Legs", dog.Type, dog.Name, dog.Legs);
                Console.WriteLine("A {0} named {1} has {2} Legs", duck.Type, duck.Name, duck.Legs);

                List<PetClass> pets = new List<PetClass>();
                pets.Add(new PetClass { HasFur = false, Legs = 2, Name = "Donald", Type = PetType.Duck });
                pets.Add(new PetClass { HasFur = true, Legs = 2, Name = "Pluto", Type = PetType.Dog });


                //LINQ
                List<PetClass> results = (from p in pets
                                          where p.Type == PetType.Dog
                                          select p).ToList();

                Console.WriteLine("Founded " + results.Count + " Dogs.");

                // LAMBDA Query
                List<PetClass> lambdaResult = pets.Where(p => p.Type == PetType.Dog).ToList();
            }
            catch
            {
                Console.WriteLine("\n!!! System Format Exception occured. Input was not in correct format. !!!");
            }
            finally
            {
                Console.WriteLine("Your Programs ends here!!");
                Console.ReadLine();
            }
        }

        class PetClass  // Reference Type 
        {
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        struct PetStruct    // Value type
        {   
            public int Legs;
            public PetType Type;
            public string Name;
            public bool HasFur;
        }

        enum PetType
        {
            Dog,
            Duck, 
            Cat
        }
    }
}
