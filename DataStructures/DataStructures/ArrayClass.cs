using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class ArrayClass
    {
        public void ShowArray()
        {
            int[] StrArray = new int[10];
            int j = 0;
            for (int i = 0; i < StrArray.Length; i++)
            {
                Console.Write("StrArray [{0}]:", i);
                StrArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of array are:");
            foreach (var item in StrArray)
            {

                Console.Write("StrArray [{0}]:", j);
                Console.WriteLine(item);
                j++;
            }
        }
        public int[] ShowArray(int[] IntArray,int size)
        {
            int[] NewArray=new int[size];
            for (int i = 0; i < IntArray.Length; i++)
            {
                NewArray[i] = IntArray[i] + 100;
                
            }
            return NewArray;
        }
    }
}
