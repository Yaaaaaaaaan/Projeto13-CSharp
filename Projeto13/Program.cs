using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue){
                Console.WriteLine(x.Value);
            }
            else{
                Console.WriteLine("X é nulo.");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é nulo.");
            }
            Console.ReadLine();
        }
    }
}
