using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task3_4
{
    internal class RandomBool
    {
        Random r;

        internal RandomBool() 
        {
            r = new Random();
        } 
        public bool[] GetRandomBoolArray(int size)
        {
            bool[] rand_array = new bool[size]; 
            for (int i = 0; i<size; i++)
            {
                if (r.Next(0,255)%2==0) rand_array[i] = true;
                else rand_array[i] = false;
            }
            return rand_array; 
        }
    }
}
