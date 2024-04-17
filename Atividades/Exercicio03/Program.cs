namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

            int[,] matriz = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz informada:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}