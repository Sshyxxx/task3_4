using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal abstract class BaseArray<T> : IArray<T>, IPrinter<T>
    {
        /// <summary>
        /// Заполнение массива целыми числами
        /// </summary>     
        public abstract void GetValues();


        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>     
        public abstract int[] GetRandomValues();

        /// <summary>
        /// Выводит на экран массив
        /// </summary>    
        public abstract void Print();


        /// <summary>
        /// Считает среднее значение массива
        /// </summary>
        /// <returns>Дробное число, сумма, поделенная на количество элементов</returns>
        public abstract double AverageValue();

    }
}
