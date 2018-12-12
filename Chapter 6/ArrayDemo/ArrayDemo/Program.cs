using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int userChoice;
            string userString;
            int anotherChoice;
            
            for (int i = 0; i < arr.Length; ++i)
            {
                Write("Please enter a number ");
                userString = ReadLine();
                arr[i] = Convert.ToInt32(userString);

            }
            WriteLine("Which order do you want to see?");
            WriteLine("1 for in order, 2 for decending order, and 3 for a specific position");
            userString = ReadLine();
            anotherChoice = Convert.ToInt32(userString);

            if (anotherChoice == 1)
            {
                for (int h = 0; h < 8; ++h)
                {
                    WriteLine(arr[h]);
                }
            }
            
            if (anotherChoice == 2)
            {
                Array.Reverse(arr);
                for (int j = 0; j < 8; ++j)
                {
                    WriteLine(arr[j]);
                }
            }

            if (anotherChoice == 3)
            {
                WriteLine("Choose a number from the list >>>");
                userString = ReadLine();
                userChoice = Convert.ToInt32(userString);
                for (int z = 0; z <= 8; ++z)
                {
                    if (userChoice == arr[z])
                    {
                        Write("That number is available");
                    }
                    else
                        Write("Error");
                }
            }
        }
    }
}
