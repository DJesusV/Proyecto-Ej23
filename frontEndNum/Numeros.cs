using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontEndNum
{
    public class Numeros
    {
        public LinkedList<int> listaNum = new LinkedList<int>();

        public void AgregarNumeros(int nuevoNum)
        {

            listaNum.AddLast(nuevoNum);
             
            
        }


        public void OrdenarNumeros()
        {

            listaNum = new LinkedList<int>(listaNum.OrderBy(num =>num));
            
        }

        public void ObtenerNumerosFaltantes()
        {
           var listaLlena = new LinkedList<int>();

           int listaNoLlena = listaNum.First.Value;
           foreach (int num in listaNum)
            {
                while (listaNoLlena < num)
                {
                    listaLlena.AddLast(listaNoLlena);
                    listaNoLlena++;
                }
            listaLlena.AddLast(num);
            listaNoLlena++;
            }

            listaNum = listaLlena;
        }
        public LinkedList<int> ObtenerNumeros()
        {
            return listaNum;
        }
    }
}
