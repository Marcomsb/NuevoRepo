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
            Fibonacci CalculaFibonacci = new Fibonacci();
            ArrayList ArrayFibo = new ArrayList();
            int[] numbers; //Aquí se crea el array de Integers
            numbers = new int[6]{4,6,20,1,11,25};  // Lleno el Array de 6 números
            /*System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(1));
            System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(2));
            System.Console.WriteLine("El número de Fibonacci 1 es: " + n.calcular(7));*/
            
            //Ejemplo de Base de Datos
            Base_Datos.Numeros Base = new Base_Datos.Numeros();
            Base.Agregar(1);
            Base.Agregar(2);
            Base.Agregar(4);
            Base.Agregar(4);
            int cantidad = Base.ObtenerCantidad();
            Console.WriteLine("La Cantidad en la Base es de: "+cantidad + " elementos");
            int maximo = CalculaFibonacci.AdivinandoElMaximoFibonacciQuePuedopCalcular(1);
            Console.WriteLine("El número máximo del Fibo es: " + cantidad + " elementos");
            //Ejemplo de Fibonacci
            ArrayFibo.Add(4);
            ArrayFibo.Add(6);
            ArrayFibo.Add(20);
            ArrayFibo.Add(1);
            ArrayFibo.Add(11);
            ArrayFibo.Add(25);
            
            
            Console.WriteLine("Array Fibonacci");
            PrintValues(ArrayFibo);
            Console.WriteLine("Resultado de Fibonacci");
            PrintValues(CalculaFibonacci.calculaArray(ArrayFibo));
            PrintValues(CalculaFibonacci.calculaArray(numbers));
            PrintValues(CalculaFibonacci.calculaArray(ArrayFibo));

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
