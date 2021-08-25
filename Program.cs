using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1; string cadena;
            int contaprimos = 0; int secuencia = 1;
            Console.WriteLine("Escriba Cuantos primos desea");
            cadena = Console.ReadLine();
            i = Convert.ToInt32(cadena);
            while (contaprimos <i)
            {
             if (esprimo(secuencia))
                        {
                            Console.WriteLine((contaprimos+1).ToString() +"- " + secuencia+ "el numero es primo");
                            Console.WriteLine("Que bonita es esta linea");
                    contaprimos++;
                        }
                //else
                //{
                //    Console.WriteLine(i+ "El numero no es primo");
                //}
                secuencia++;
            }
           
            Console.ReadLine();
            int j = 10;
            while (j<100)
            {
                Console.WriteLine("Ayudame a escribir codigo correcto!");
                j++;
            }
        }

        public static bool esprimo(int numero)
        {
            int ciclo = 1;
            
            int divisores=0 ;
            while (ciclo<=numero)
            {
                if (numero % ciclo==0)
                {
                    divisores++;
                }
                ciclo++;
            }
            if (divisores <= 2) return true;
            else  return false;
        }
    }
}
