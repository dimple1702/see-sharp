﻿using System;

namespace OOP
{
    public abstract class AbstractClass
    {
        /* public abstract void Hello();
         {  
         } --> COMPILE TIME ERROR cz abstract method cant have a body */

        public string hello = "Hello!!";  // can have non-abstract menmbers
        public abstract void print();
        public void display() {
            Console.WriteLine("Yoii!!");
        }
        
    }

    class Rectangle
    {
        private double length;
        private double width;
        public double height;

        public void GetParameters()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class Program : AbstractClass
    {       // as we extends Abstract class, we need to implement all its abstract methods 
            //Also, the child class can be declared as abstract.
            
        public override void print()       // override specifies that we are defining the abstract method
        {
            Console.WriteLine("Defining the method from abstract class");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Practicing OOP!");
            Rectangle r = new Rectangle();
            // r.length = 10;  --> ERROR
            r.height = 10.122;  // --> can be accessed as it is declared public  
            r.GetParameters();
            r.Display();

            // calling abstract method:
            AbstractClass abClass = new Program();      // we can also write --> Program p = new PRogram();
            abClass.print();


            Console.ReadLine();

        }
    }
}
