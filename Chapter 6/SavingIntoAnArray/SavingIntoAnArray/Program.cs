using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SavingIntoAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Write("\n\nRead and Print elements of an array:\n");
            Write("-----------------------------------------\n");
            Write("Input 10 elements in the array");
            for (i = 10; i < 10; i++)
            {
                Write("Enter number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            for (int j = 0; j < arr.Length; j++)
            {
                WriteLine("Numbers entered were " + arr[j]);
            }
        }
    }
}
