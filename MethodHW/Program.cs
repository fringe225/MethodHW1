using System;

namespace MethodHW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Console.WriteLine("Enter word: ");
            //string text = Console.ReadLine();
            //Console.WriteLine("Enter char : ");
            //string elem = Console.ReadLine();
            //char element = Convert.ToChar(elem);
            //Console.WriteLine(FindCharIndex(text,element));
            #endregion
            #region Task2
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //Console.WriteLine(IsPrime(number));
            #endregion
            #region task3
            //int[] arr;
            //arr = FillArray();
            //if (Average(arr) > 60)
            //{
            //    Console.WriteLine($"Siz {Average(arr)} balnan mezun oldunuz!");
            //}
            //else
            //{
            //    Console.WriteLine($"Siz {Average(arr)} balnan tesufki mezun ola bilmediniz! :( ");
            //}
            #endregion
        }
        static int FindCharIndex(string text,char element)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == element)
                {
                    return i;
                }
                
            }
            return 1;
        }

        static bool IsPrime(int number)
        {
            bool check = true;
            for (int i = 2; i <number/2; i++)
            {
                if (number % 2 == 0)
                {
                    check=false;
                    break;
                }
            }
            return check;
        }
        static int[] FillArray()
        {

            Console.WriteLine("Arrayin uzunlugunu daxil edin");
            int length;
            int.TryParse(Console.ReadLine(), out length);
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr[i]);

            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            return arr;
        }
        static double Average(int[] arr) // FillArray() ??
        {
            double average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                average += arr[i];
            }

            return average / arr.Length;
        }


    }
}
