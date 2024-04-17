using System.Net;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes de ambos os vetores,
            //armazenando o resultado em um terceiro vetor.Em seguida, exiba o vetor resultante.
            int tamanho = 1;
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];
            int[] resultado = new int[tamanho];


            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o valor do primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());

                Console.Write($"Digite o valor do segundo vetor: ");
                vetor2[i] = int.Parse(Console.ReadLine());
                resultado[i] = vetor1[i] + vetor2[i];
            }
            Console.WriteLine("Vetor resultante:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(resultado[i]);
            }
        }
    }
}
