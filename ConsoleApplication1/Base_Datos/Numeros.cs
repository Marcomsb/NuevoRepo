using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Datos
{
    public class Numeros
    {
        private List<int> Nums = new List<int>();
        public int Agregar(int numrecibido)
        {
            Nums.Add(numrecibido);
            
            return 0;
        }
        public int ObtenerCantidad()
        {
            int Cantidad = 0;
            foreach (int obj in Nums)
            {
                

                ++Cantidad;

        }
            return Nums.Count; 
            //return Cantidad;
    }
 }
}
