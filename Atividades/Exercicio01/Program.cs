using System;

namespace exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.
            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {

                Console.WriteLine("digite um numero inteiro");
                if (int.TryParse(Console.ReadLine(), out int ValorInteiro))
                {
                    vector[i] = ValorInteiro;
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                    i--;
                }
            }
        }

        }
    }











