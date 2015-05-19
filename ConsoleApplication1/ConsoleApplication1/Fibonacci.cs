using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibonacci
    {
        public int calcular(int entero)
        {
          
            if (entero == 1 || entero == 2)
            {
               
                return 1;
            }
            else {
                return calcular(entero - 2) + calcular(entero - 1); 
            }

            return 0;
            
            
            }
    }
}
