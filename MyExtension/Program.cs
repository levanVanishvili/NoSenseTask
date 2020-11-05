using System;
using System.Linq;

namespace MyExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by commas");
            try
            {
                string input = Console.ReadLine();

                int[] intArray = Array.ConvertAll(input.Split(","), i => int.Parse(i));                
                
                var outPut = intArray.ThisDoesntMakeAnySense(i => i.Equals(10),  i => Console.WriteLine("matching number {0}", i));

                if (intArray.Length == outPut.Count())
                {
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        Console.WriteLine("entered number is {0}", intArray[i]);
                    }
                }
            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex.Message);
            }
        }
    }
}
