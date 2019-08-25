using System;

namespace Ex_6A_Solorzano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solorzano Exercise 6A -C#\n");
            int[] ArrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] ArrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

           CountingSummingComputing(ArrayA, ArrayB, ArrayC);//Part one
           RotatingArrayA(ArrayA, ArrayA.Length, 2);//Part Three
           RotatingArrayB(ArrayB, ArrayB.Length, 2);//Part Three
           RotatingArrayC(ArrayC, ArrayC.Length, 4);//Part Three
           ReverseArrays(ArrayA, ArrayB, ArrayC);//Part two (Placed after Part Three so rotating is correct) 
           SortingArray(ArrayC);//Part Four
        }
        static double[] CountingSummingComputing(int[] inputArrayA,int[] inputArrayB,int[] inputArrayC)
        {
            Console.WriteLine("Counting, summing, computing the mean");

            //Counting Elements in each Array. (Count)
            int CountA = inputArrayA.Length;
            int CountB = inputArrayB.Length;
            int CountC = inputArrayC.Length; 
            Console.WriteLine("Total Elements in ArrayA : {0}", CountA);
            Console.WriteLine("Total Elements in ArrayB : {0}", CountB);
            Console.WriteLine("Total Elements in ArrayC : {0}", CountC);

            //Getting total Sum of each Array. (Sum)
            int sumA = 0;
            for (int x = 0; x < inputArrayA.Length; x++)
            {
                sumA += inputArrayA[x]; 
            }
            Console.WriteLine("Sum of ArrayA : " + sumA);
            int sumB = 0; 
            for (int x = 0; x < inputArrayB.Length; x++)
            {
                sumB += inputArrayB[x];
            }
            Console.WriteLine("Sum of ArrayB : " + sumB);
            int sumC = 0; 
            for (int x=0; x < inputArrayC.Length; x++)
            {
                sumC += inputArrayC[x];
            }
            Console.WriteLine("Sum of ArrayC : " + sumC);

            //Getting Average Element in each Array. (Sum / Count)
            double AverageA = sumA / CountA;
            double AverageB = sumB / CountB;
            double AverageC = sumC / CountC;
            Console.WriteLine("Average Element in ArrayA : " + AverageA);
            Console.WriteLine("Average Element in ArrayB : " + AverageB);
            Console.WriteLine("Average Element in ArrayC : " + AverageC);

            //Returning Average Element in a Array. 
            double[] AverageElement = { AverageA, AverageB, AverageC };
            return AverageElement;  
        }
        static int[][] ReverseArrays(int[] inputArrayA, int[] inputArrayB, int[] inputArrayC)
        {
            //Array.Reverse(); This is an alternative way. 
            //Reversing Arrays
            for (int x = 0; x < inputArrayA.Length / 2; x++)
            {
                int temp = inputArrayA[x];
                inputArrayA[x] = inputArrayA[inputArrayA.Length - 1 - x];
                inputArrayA[inputArrayA.Length - 1 - x] = temp; 
            }
            for (int x = 0; x < inputArrayB.Length / 2; x++)
            {
                int temp = inputArrayB[x];
                inputArrayB[x] = inputArrayB[inputArrayB.Length - 1 - x];
                inputArrayB[inputArrayB.Length - 1 - x] = temp;
            }
            for (int x = 0; x < inputArrayC.Length / 2; x++)
            {
                int temp = inputArrayC[x];
                inputArrayC[x] = inputArrayC[inputArrayC.Length - 1 - x];
                inputArrayC[inputArrayC.Length - 1 - x] = temp; 
            }
            Console.WriteLine("\n\nReversed ArrayA");
            foreach (int x in inputArrayA)
            {
                Console.Write(x + ",");
            }
            Console.WriteLine("\nReversed ArrayB");
            foreach (int x in inputArrayB)
            {
                Console.Write(x + ",");
            }
            Console.WriteLine("\nReversed ArrayC");
            foreach (int x in inputArrayC)
            {
                Console.Write(x + ",");
            }
            int[][] ReversedArrays = { inputArrayA, inputArrayB, inputArrayC };
            return ReversedArrays;
        }
        static int[] RotatingArrayA(int[] inputArrayA, int element, int num)
        {
            //Rotate to the right X2
            //int[] ArrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            //Expected for ArrryA 8,10,0,2,4,6,
            for (int s = 0; s < num; s++)
            {
                int temp = inputArrayA[0];
                for (int c = 1; c < element; c++)
                {
                    inputArrayA[c - 1] = inputArrayA[c];
                }
                inputArrayA[element + 1] = temp;
            }
            Console.WriteLine("\nRotated ArrayA");
            foreach (int ele in inputArrayA)
            {
                Console.Write(ele + ",");
            }
            return inputArrayA;
        }
        static int[] RotatingArrayB(int[] inputArrayB, int n, int num)
        {
            //Rotate to the left X2
            // int[] ArrayB = new int[5] { 1, 3, 5, 7, 9 };
            //Expected 5, 7,9,1,3
            for (int i = 0; i < num ; i ++)
            {
                int temp = inputArrayB[0];
                for(int j = 1; j < n; j++)
                {
                    inputArrayB[j - 1] = inputArrayB[j];
                }
                inputArrayB[n - 1] = temp;
            }
            Console.WriteLine("\nRotated ArrayB");
            foreach (int element in inputArrayB)
            {
                Console.Write(element + ","); 
            }
           
            return inputArrayB;
        }
        static int [] RotatingArrayC(int[] inputArrayC, int element, int num)
        {
            //Rotate array C four places to the left.
            //int[] ArrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            //Expected 5,9,2,6,5,3,5,9,3,1,4,1,
            for (int i = 0; i < num; i++)
            {
                int temp = inputArrayC[0];
                for (int j = 1; j < element; j++)
                {
                    inputArrayC[j - 1] = inputArrayC[j];
                }
                inputArrayC[element - 1] = temp;
            }
            Console.WriteLine("\nRotated ArrayC");
            foreach( int ele in inputArrayC)
            {
                Console.Write(ele + "," );
            }
            return inputArrayC; 
        }
        static int[] SortingArray(int[] inputArrayC)
        {
            //Array.Sort() Is a alternative way. 
            //Sorting Arrays  int[] ArrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int temp = 0; 
            for (int x = 0; x < inputArrayC.Length; x++)
            {
                for (int j = 0; j < inputArrayC.Length; j++)
                {
                    if( inputArrayC[j] > inputArrayC[x]) 
                    {
                        temp = inputArrayC[x]; // Holds the value so it does not get erased. Like 1. 
                        inputArrayC[x] = inputArrayC[j]; // Sets the value of 1 to 3 
                        inputArrayC[j] = temp; // set the value 3 to 1
                        //Repeat
                    }
                }
            }
            Console.WriteLine("\n\nSorted ArrayC");
            foreach (int elemnt in inputArrayC)
            {
                Console.Write(elemnt+ ",");
            }
            return inputArrayC;
        }
    }
}
