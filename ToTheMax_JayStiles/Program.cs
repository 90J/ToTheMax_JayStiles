using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax_JayStiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input for array size
            Console.Write("Enter a number for how large you want the array to be: ");
            int arraySize = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Array size is {arraySize}");

            //user input to add numbers into the array
            List<int> theArray = new List<int>();
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Enter a number to add to the Array: ");
                int numForArray = int.Parse(Console.ReadLine());
                theArray.Add(numForArray);


            }
            //Print out the array
            //foreach (var i in theArray)
            //Console.WriteLine($"The Array is holding: {i}");


            
            int largest = theArray.Max();
            Console.WriteLine($"The largest number in the array is: {largest}");

        }
    }
}

