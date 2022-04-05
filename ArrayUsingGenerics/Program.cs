
using System.Threading.Tasks.Dataflow;

namespace ArrayUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // double[] doubleArray = { 1.0, 1.1, 1.2, 1.3, 1.4, 1.5 };
            // int[] intArray = { 1, 2, 3, 4, 5, 6 };
            // char[] charArray = { 'V', 'I', 'V', 'E', 'K' };
            //  
            // ArrayDemo arrayDemo = new ArrayDemo();
            // 
            // arrayDemo.toPrint<double>(doubleArray);
            // arrayDemo.toPrint<int>(intArray);
            // arrayDemo.toPrint<char>(charArray);

            int maxInt = GenMax.MaxInteger(11, 13, 12);             //passing values as a parameter to method
            Console.WriteLine($"Maximum Value: {maxInt}");          // printing maximum integer value
            float maxFloat = GenMax.MaxFloat(1.1f, 3.4f, 2.1f);     //passing float values as parameters
            Console.WriteLine($"Maximum Value: {maxFloat}");        //print maximum float
            string maxString = GenMax.MaxString("Banana","Apple","Strawberry");
            Console.WriteLine($"Maximum Value: {maxString}");
        }
    }
}