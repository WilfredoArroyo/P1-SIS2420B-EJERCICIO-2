using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._2_PRACTICA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----DIGITE UN NUMERO----");
            int numero =Convert.ToInt32(Console.ReadLine());

            string Resultado = Nnumero.Numeros(numero);
            Console.WriteLine(Resultado);
            Console.ReadKey();
        }

        public static class Nnumero
        {
            
            public static string Numeros(int numero)
            {
               int[] Arrays= new int[numero];
                string letra = "";
                string letra1 = "";
                string letraR = "";
                int n;
                int s=1;
                int p = 1;
                for (int i = 1; i <= numero; i++)
                {

                    p *= i;
                    if(i< numero)
                    letra += p+",";
                    if (i == numero)
                        letra += p;

                    n = (int) Math.Pow(2,i);

                    if(i < numero)
                    letra1 += n + ",";
                    if (i == numero)
                        letra1 += n;
                    s++;
                }
                letraR ="Serie 1:"+ letra+"\nSerie 2:"+letra1;
                return letraR;
            }
        }
    }
}
