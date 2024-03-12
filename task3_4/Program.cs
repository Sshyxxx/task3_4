using System;

namespace task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDArray<int> oneInt = new OneDArray<int>(5);
            oneInt.Print();
            oneInt.Array = oneInt.GetRandomValues();
            oneInt.Print();
            oneInt = new OneDArray<int>(5, true);
            oneInt.Print();

            OneDArray<double> twoDouble = new OneDArray<double>(5);
            twoDouble.Array = RandomDouble.GetRandomDoubleArray(twoDouble.Length);
            twoDouble.Print();
            twoDouble = new OneDArray<double>(5, true);
            twoDouble.Print();

            OneDArray<bool> threeBool = new OneDArray<bool>(5);
            threeBool.Array = RandomBool.GetRandomBoolArray(threeBool.Length);
            threeBool.Print();
            threeBool = new OneDArray<bool>(5, true);
            threeBool.Print();

            OneDArray<string> fourString = new OneDArray<string>(5);
            fourString.Array = RandomString.GetRandomStringArray(fourString.Length);
            fourString.Print();
            fourString = new OneDArray<string>(5, true);
            fourString.Print();

            

        }
    }
}
