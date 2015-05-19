using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static int num = 1 + 1;   
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hola Mundo!");
            System.Console.WriteLine(""+ num);
            Fibonacci n = new Fibonacci();
            System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(1));
            System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(2));
            System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(7));
            System.Console.ReadKey();
            

        }
    }
}
