using System;

namespace Arrays
{
    class Program
    {
        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void PrintArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr1 = new int[5];    // creating an array
            arr1[0] = 1;       // initializing array  
            arr1[1] = 2;
            arr1[2] = 3;
            Console.Write("Elements of arr1 are: ");

            // Traversing array using simple loop
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");   // accessing the elements of array. Default value is 0
            }


            // Traversing array using for each loop
            Console.Write("\n\nAccessing elements of array using foreach loop: ");
            foreach (int i in arr1)
            {
                Console.Write(i + " ");   // accessing the elements of array. Default value is 0
            }

            // Declaring and Initializing array in same time
            int[] way1 = new int[]{1,2,3,4,5};
            int[] way2 = new int[7]{1,2,3,4,5,6,7};
            char[] way3 = { 'a', 'b', 'c', 'd', 'e' };

            // Find minimum
            int[] Find = {21, 22, 34, 12, 66, 77, 87, 99, 9, 39, 41};
            int min = Find[0];

            for(int i = 1; i < Find.Length; i++)
            {
                if(Find[i] < min)
                {
                    min = Find[i];
                }
            }
            Console.WriteLine("\n\nThe minimum element in Find array is: " + min);

            //Passing array to a function
            Console.WriteLine("The maximum element in Find array is: " + FindMax(Find));


            // Multidimensional array
            int[,] twoDArray = new int[,] { {1,2,3,4},{1,2,3,4}};

            Console.WriteLine("\nPrinting 2D array:");
            for(int i = 0; i < twoDArray.GetLength(0); i++)     // getting lenght of row --> GetLenght(dimension1)
            {
                for(int j = 0; j < twoDArray.GetLength(1); j++)     // getting lenght of column --> GetLenght(dimension2)
                {
                    Console.Write(twoDArray[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nTotal elements in the twoDArray: " + twoDArray.Length);  //gives the total number of element present in the multidimensional array
            Console.WriteLine("Number of dimensions in twoDArray: " + twoDArray.Rank);  //used to get the rank i.e. the number of dimensions of multidimensional array

            // Sorting array
            int[] sortArray = { 25, 92, 13, 53, 49, 81, 70, 11, 62 };
            Array.Sort(sortArray);
            Console.WriteLine("\n Sorted Array: ");
            PrintArray(sortArray);

            // Jagged Array
            Console.WriteLine("\n\nJagged Array Example");
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1 };   
            jaggedArray[1] = new int[] {1, 2};
            jaggedArray[2] = new int[] { 3, 4, 5, 6 };
            jaggedArray[3] = new int[] { 7, 8, 9, 10, 11};

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + " ");
                }
                System.Console.WriteLine();
            }


            /* Params: params is a keyword which is used to specify a parameter that takes variable number of arguments. 
               It is useful when we don't know the number of arguments prior.
            */
            Program program = new Program();
            program.Params(2, 4, 6, 8, 10, 12, 14, 16);

            Console.ReadLine();
        }

        public void Params(params int[] value)
        {
            Console.WriteLine("\n Params Example");
            for (int i = 0; i < value.Length; i++)
            {
                Console.Write(value[i] + " ");
            }
        }

    }
}
