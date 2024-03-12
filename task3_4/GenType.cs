using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal class GenType
    {
        object[] _genArray;

        public object[] GenArray { get { return _genArray; } set { _genArray = value; } }

        public GenType(Type type, int size) 
        {
            _genArray = new object[size];
            Console.WriteLine("Тип массива：" + type.FullName);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"элемент № {i}");
                if (type == typeof(int))
                    _genArray[i] =  int.Parse(Console.ReadLine());
                else if (type == typeof(double))
                    _genArray[i] = double.Parse(Console.ReadLine());
                else if (type == typeof(bool))
                    _genArray[i] = bool.Parse(Console.ReadLine());
                else
                    _genArray[i] = Console.ReadLine();
            }
        }
    }
}
