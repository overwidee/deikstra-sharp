using deikstra_sharp.Models;
using System;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var deikstra = new Deikstra();

            var mas = new decimal[4, 4]
            {
                { 0, 2, 5, 3 },
                { 3, 0, 5, 2 }, 
                { 3, 0, 0, 4 },
                { 3, 0, 0, 0 }, 
            };

            deikstra.QuantityVertex = 4;
            deikstra.Matrix = mas;

            var result = deikstra.Start(0);
            Console.ReadKey();
        }
    }
}
