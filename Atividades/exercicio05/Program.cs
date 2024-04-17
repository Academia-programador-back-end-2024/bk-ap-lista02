namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.

            int[,] matriz = new int[4, 4];

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }

            }
            Console.WriteLine("Matriz gerada:");
            for (int i = 0;i < 4; i++)
            {
                for(int j = 0;j < 4; j++) 
                {
                    Console.Write(matriz[i, j] + "\t"); 
                }
            }
            int maiorvalor = EncontrarMaiorValor(matriz);
            Console.WriteLine($"\nO maior valor na matriz é: {maiorvalor}");


        }
        static int EncontrarMaiorValor(int[,] matriz)
        {
            int maior = matriz[0, 0];
            foreach (int valor in matriz)
            {
                if (valor > maior)
                {
                    maior = valor;
                }
            }
            return maior;
        }
    }
}
