namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor
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

            int maior = vector[0];
            int menor = vector[0];
            foreach (int ValorInteiro in vector)
            {
                if (maior < ValorInteiro)
                {
                    maior = ValorInteiro;
                }

                if (menor > ValorInteiro)
                {
                    menor = ValorInteiro;
                }

            }
            Console.WriteLine($@"O maior numero é {maior} e o menor numero é {menor}");
        }
    }
}


        