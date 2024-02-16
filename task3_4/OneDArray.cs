using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal class OneDArray<T> : BaseArray
    {
        private T[] _array;
        private int _size;

        public OneDArray(int size, bool isUser = false)
        {
            _size = size;
            _array = new T[_size];

            if (!isUser)
            {
                GetRandomValues();
            }
            else
            {
                //GetIntValues();
            }
        }

        public override double AverageValue()
        {
            throw new NotImplementedException();
        }

        public void GetIntValues<T>()
        {
                //Console.WriteLine("введите " + _size + " элементов ");
                //for (int i = 0; i < _array.Length; i++)
                //{
                //    Console.WriteLine($"элемент № {i}");
                //    //_array[i] = int.Parse(Console.ReadLine());
                //    _array[i] = Console.ReadLine();
                //}
        }


        public override void GetRandomValues()
        {
            Random random = new Random();
            for (int i = 0; i < _size; i++)
            {
               //_array[i] = random.Next(0, 255);
            }
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
