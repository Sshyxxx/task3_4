using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal class RandomString
    {
        Random r;

        internal RandomString()
        {
            r = new Random();
        }
        public string[] GetRandomStringArray(int size)
        {
            string[] rand_array = new string[size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < r.Next(1,20); j++)
                {
                    rand_array[i]+= (char)r.Next(0x0410, 0x44F);
                }
            }
            return rand_array;
        }
    }
}
