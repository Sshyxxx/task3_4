using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal class RandomDouble
    {

        internal RandomDouble() 
        { 

        }

        public static double[] GetRandomDoubleArray(int size)
        {
            Random r = new Random();
            double[] rand_array = new double[size];
            for (int i = 0; i < size; i++)
            {
                rand_array[i] = r.Next(0,255) + r.NextDouble();
            }
            return rand_array;
        }

        //protected static double[] GetDoubleValues()
        //{
        //    Console.WriteLine("введите " + _size + " элементов ");
        //    for (int i = 0; i < _arrayO.Length; i++)
        //    {
        //        Console.WriteLine($"элемент № {i}");
        //        _arrayO[i] = int.Parse(Console.ReadLine());
        //    }
        //}
    }
}
