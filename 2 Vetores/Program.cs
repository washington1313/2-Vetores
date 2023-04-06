using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosPares = new int[10];
            int[] numerosImpares = new int[10];

            int numero;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o Número:");
                numero = int.Parse(Console.ReadLine());
                Console.Clear();

                if (numero % 2 == 0)
                {
                    numerosPares[i] = numero;
                }

                else if (numero % 2 == 1)
                {
                    numerosImpares[i] = numero;
                }
            }

            Console.WriteLine("Números Pares: ");
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(numerosPares[i]);
            }

            Console.WriteLine("Números Ímpares");
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(numerosImpares[i]);
            }
            
            Console.ReadKey();

        }
    }
}
