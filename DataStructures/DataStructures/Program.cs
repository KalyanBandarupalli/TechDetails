using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 10, 11, 15, 20, 22, 25 };
            int[] result = new int[Arr.Length];
            ArrayClass AC = new ArrayClass();
            AC.ShowArray();
            result=AC.ShowArray(Arr, Arr.Length);
            Console.WriteLine();
            Console.WriteLine("The new array is");
            foreach (var item in result)
            {
                Console.Write(item+"\t");
            }
            Console.ReadKey();
        }
    }
}
