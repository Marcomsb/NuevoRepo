using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Fibonacci
    {
        private int control = 0;
        private int Maximo = 0;
        public int calcular(int entero)
        {

            if (entero == 1 || entero == 2)
            {

                return 1;
            }
            else
            {
                return calcular(entero - 2) + calcular(entero - 1);
            }

            return 0;


        }
        public ArrayList calculaArray(IEnumerable myList)
        {
            ArrayList result = new ArrayList();
            foreach (int obj in myList)
            {

                result.Add(calcular(obj));
               
            } return result;
        }
 
        
    
    public int AdivinandoElMaximoFibonacciQuePuedopCalcular(int entero){
        try{
            
    //♥♥♥ muaaaaaa....
            while (control != 1)
            {
                ++Maximo;
                return calcular(entero - 2) + calcular(entero - 1);
                
            }
            }
           
        catch(Exception ex){
            control = 0;
            
            Console.WriteLine(ex.Message);
}
        finally{
            Console.WriteLine(Maximo);
        }
        return Maximo;
    }
   }


