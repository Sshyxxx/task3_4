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

        public OneDArray(int size, bool isUser = false)
        {
           
            _array = new T[size];

            if (!isUser)
            {
                GetRandomValues();
            }
            else
            {
                //GetIntValues();
            }
        }


        public override void GetRandomValues()
        {
            if (typeof(T) == typeof(int))
            {
                RandomBool randomBool = new RandomBool();
                randomBool.GetRandomBoolArray(_array.Length);
            }
            else if (typeof(T) == typeof(string))
            {
                RandomString randomString = new RandomString();
                randomString.GetRandomStringArray(_array.Length);
            }
        } 

        public override double AverageValue()
        {
            throw new NotImplementedException();
        }

        public override void GetIntValues()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }


    }
}
