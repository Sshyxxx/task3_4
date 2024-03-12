using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal class OneDArray<T>: BaseArray<T>
    {
        private T[] _array;

        public T[] Array { 
            get { return _array; }
            set {
                _array = value;
            } 
        }

        public int Length {  get { return _array.Length; } }

        public OneDArray(int size, bool isUser = false)
        {
            _array = new T[size];

            if (!isUser)
            {
                GetRandomValues();
            }
            else
            {
                GetValues(new GenType(typeof(T), _array.Length));
            }
        }


        public override int[] GetRandomValues()
        {
            Random random = new Random();
            int[] int_array = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                int_array[i] = random.Next(0, 255);
            }
            return int_array;
        }
        
        //public bool[] NewRandomValues()
        //{
        //    return RandomBool.GetRandomBoolArray(_array.Length);
        //}

        public override double AverageValue()
        {
            throw new NotImplementedException();
        }

        public override void GetValues(GenType genType)
        {
            genType = new GenType(typeof(T), _array.Length);
        }

        public override void Print()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }


    }
}
