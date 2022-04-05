
using System.Threading.Tasks.Dataflow;

namespace ArrayUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxInt = GenMax<int>.MaxVal(11, 13, 12);             //passing values as a parameter to method
            Console.WriteLine($"Maximum Value: {maxInt}");          // printing maximum integer value
            float maxFloat = GenMax<float>.MaxVal(1.1f, 3.4f, 2.1f);     //passing float values as parameters
            Console.WriteLine($"Maximum Value: {maxFloat}");        //print maximum float
            string maxString = GenMax<string>.MaxVal("Banana","Apple","Strawberry");       //passing values as a parameter to method
            Console.WriteLine($"Maximum Value: {maxString}");        // printing maximum string length value
        }
    }
}