using deikstra_sharp.Models;
using System;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var deikstra = new Deikstra();

            deikstra.Matrix = new decimal[4, 4]
            {
                { 0, 2, 5, 3 },
                { 3, 0, 5, 2 },
                { 3, 0, 0, 4 },
                { 3, 0, 0, 0 },
            };

            var result = deikstra.Start(0);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Weight from 0 to {i} = {result[i]}");
            }
            Console.ReadKey();
        }
    }
}
