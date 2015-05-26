using System;
using System.Collections;
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
            ArrayList ArrayFibo = new ArrayList();
            int[] numbers; //Aquí se crea el array de Integers
            numbers = new int[6]{4,6,20,1,11,25};  // Lleno el Array de 6 números
            /*System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(1));
            System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(2));
            System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(7));*/
            ArrayFibo.Add(4);
            ArrayFibo.Add(6);
            ArrayFibo.Add(20);
            ArrayFibo.Add(1);
            ArrayFibo.Add(11);
            ArrayFibo.Add(25);
            
            Console.WriteLine("Array Fibonacci");
            PrintValues(ArrayFibo);
            Console.WriteLine("Resultado de Fibonacci");
            PrintValues(n.calculaArray(ArrayFibo));
            PrintValues(n.calculaArray(numbers));
            

            System.Console.ReadKey();
            

        }
        public static void PrintValues(IEnumerable myList)
        {
            
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
