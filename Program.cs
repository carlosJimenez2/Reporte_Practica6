using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosUnidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int i;

                int[] Precios = new int[] { 100, 150, 200, 250, 300 };
                int[] Precios2 = new int[] { 65, 789, 132, 315, 454 };
                int[] Consumototal = new int[] { 0, 0, 0, 0, 0 };
                int[] ConsumoSemanal = new int[] { 0, 0, 0, 0, 0 };

                string[] Compradores = new string[] { "Comprador 1", "Comprador 2", "Comprador 3", "Comprador 4" };


                for ( i = 0; i < Precios.Length; i++)
                {
                    Consumototal[i] = Precios[i] + Precios2[i];
                    ConsumoSemanal[i] = Consumototal[i] / 0;
                }

                for (i = 0; i < Precios.Length; i++)
                {
                    Console.WriteLine("El consumo semanal es {0}", ConsumoSemanal[i]);
                }
            }


            catch(DivideByZeroException)
            {
                Console.WriteLine("Operacion invalida");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Valor fuera de rango");
            }

            Console.ReadKey();
        }
    }
}
