using System;

namespace ArrayHomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //add additinal element
            int[] ArrAdd = { 3, 5, 7 };
            Array.Resize(ref ArrAdd, ArrAdd.Length + 1);
            ArrAdd[^1] = 10;      //^1 = ArrAdd.Length-1
            for (int k = 0; k < ArrAdd.Length; k++)
            {
                Console.Write(ArrAdd[k] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //find element with special mean
            int[] Arr;
            int i = 0;
            Console.WriteLine("Enter number of elements of array:");
            int n = Int32.Parse(Console.ReadLine());
            Arr = new int[n];
            Console.WriteLine("Enter elements of array:");
            bool check = true;
            while (check == true)
            {
                if (i < n)
                {
                    int input = Int32.Parse(Console.ReadLine());
                    Arr[i] = input;
                    i++;
                }
                else 
                {
                    check = false;
                }
            }
            for (int p = 0; p < Arr.Length; p++)
            {
                Console.Write(Arr[p] + " ");
            }
            Console.WriteLine();
            int index = 0;
            Console.WriteLine("Enter element of array which you want to find:");
            int elementToFind = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < Arr.Length; j++)
            {
                if (Arr[j] == elementToFind)
                {
                    index = j;
                }
            }
            Console.Write("Serching index is " + index + ".");
            Console.WriteLine();
            Console.WriteLine();



            //reverse array
            int reverse = Arr.Length - 1;
            Console.WriteLine("Reverse array:");
            while (reverse < i)
            {
                Console.Write(Arr[reverse] + " ");
                reverse--;
                if (reverse < 0)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();



            //ordering elements
            int needLength = Arr.Length;
            Console.WriteLine("Ordering elements:");
            while (needLength > 1)
            {
                for (int y = 1; y < needLength; y++)
                {
                    if (Arr[y] < Arr[y - 1])
                    {
                        int additionalElement = Arr[y];
                        Arr[y] = Arr[y - 1];
                        Arr[y - 1] = additionalElement;
                    }
                }
                needLength--;
            }
            for (int r = 0; r < Arr.Length; r++)
            {
                Console.Write(Arr[r] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();



            // quick search element
            Console.WriteLine("Eneter element of array which you want to find:");
            int elementToFind2 = Int32.Parse(Console.ReadLine());
            int div = Arr.Length / 2;
            int middleElement = Arr[div];
            while (elementToFind2 != middleElement)
            {
                if (elementToFind2 < middleElement)
                {
                    div = div / 2;
                    middleElement = Arr[div];

                }
                if (elementToFind2 > middleElement)
                {
                    div = div + div / 2;
                    middleElement = Arr[div];
                }
            }
            Console.WriteLine("Serching index is " + div + ".");

            Console.ReadLine();

        }
    }
}
