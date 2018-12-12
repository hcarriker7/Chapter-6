using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TempList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int average;
            string inputS;

            for (int i = 0; i < arr.Length; ++i)
            {
                Write("Please enter the Temps");
                inputS = ReadLine();
                arr[i] = Convert.ToInt32(inputS);
            }

           

            for (int h = 0; h < 7; ++h)
            {
                WriteLine(arr[h]); 
              
               
            }








        }
    }
}
