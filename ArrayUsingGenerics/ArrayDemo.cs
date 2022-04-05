using System;
using System.Security.AccessControl;

namespace ArrayUsingGenerics
{
    public class ArrayDemo
    {
        // double[] doubleArray = { 1.0, 1.1, 1.2, 1.3, 1.4, 1.5 };
        // Creating Generic Method to print elements in Array
        public void toPrint<T>(T[] inputArray)
        {
            Console.WriteLine(" ========== Array Result =========== ");
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(" ================================== ");
        }
    }

    internal class GenMax<T> where T : IComparable
    {
        public T frstVal, secVal,  thrdVal;
        public GenMax(T frstVal, T secVal, T thrdVal)       // Constructor for GenMaxClass
        {
            this.frstVal= frstVal;
            this.secVal =secVal;
            this.thrdVal = thrdVal;
        }
        public static T MaxVal(T frstVal, T secVal, T thrdVal)      // Generinc method for getting maximum values
        {
            if (frstVal.CompareTo(secVal) > 0 && frstVal.CompareTo(thrdVal) > 0 || frstVal.CompareTo(secVal) >= 0 && frstVal.CompareTo(thrdVal) > 0 || frstVal.CompareTo(secVal) > 0 && frstVal.CompareTo(thrdVal) >= 0)
            {
                return frstVal; // Retrun first value as maximum
            }

            if (secVal.CompareTo(frstVal) > 0 && secVal.CompareTo(thrdVal) > 0 || secVal.CompareTo(frstVal) >= 0 && secVal.CompareTo(thrdVal) > 0 || secVal.CompareTo(frstVal) > 0 && secVal.CompareTo(thrdVal) >= 0)
            {
                return secVal; // Retrun second value as maximum
            }

            if (thrdVal.CompareTo(frstVal) > 0 && thrdVal.CompareTo(secVal) > 0 || thrdVal.CompareTo(frstVal) >= 0 && thrdVal.CompareTo(secVal) > 0 || thrdVal.CompareTo(frstVal) > 0 && thrdVal.CompareTo(secVal) >= 0)
            {
                return thrdVal; // Retrun third as maximum
            }
            return frstVal;
        }    
    }
}