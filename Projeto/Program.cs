using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Program
    {
        static int[] numeros;
        static Random rnd;
        static void Main(string[] args)
        {
            numeros = new int[10];
            rnd = new Random();
            //preenchimento com numeros aleatorios
            Preencher();

            //imprimir sem ordenacao
            Console.WriteLine(" ----- ondem inicial ----- ");
            imprimir();
           
            //imprimir em ordem crescente
            Console.WriteLine(" ----- ondem crescente ----- ");
            OrdenarCrescente();
            imprimir();
            
            //imprimir em ordem decrescente
            Console.WriteLine(" ----- ondem decrescente ----- ");
            OrdenarDecrescente();
            imprimir();
            Console.WriteLine();
        }

        private static void Preencher()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 100);
            }
        }

        private static void OrdenarDecrescente()
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
        }
        private static void OrdenarCrescente()
        {
            for (int i = 0; i < numeros.Length -1; i++)
            {
                for (int j = i+1 ; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;    
                    }
                }
            }
        }
        private static void imprimir() 
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("posiçao:" + i + "\tValor:" + numeros[i]);
            }
            Console.WriteLine();
            
        }
    }
}
