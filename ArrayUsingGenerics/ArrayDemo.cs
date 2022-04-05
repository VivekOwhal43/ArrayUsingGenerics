using System;
using System.Diagnostics;
using System.Security.AccessControl;

namespace ArrayUsingGenerics
{
    public class GenMax<T> where T : IComparable
    {
        public T[] value;

        public GenMax(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sortedValues = Sort(values);
            return sortedValues[^1];
        }

        public T maxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum Value is :" + max);
        }
    }
}