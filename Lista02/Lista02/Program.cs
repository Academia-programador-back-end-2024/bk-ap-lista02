

using System.Drawing;

namespace Lista02
{
    internal class Program
    {
        /*
         * - 
- Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.
- Busca de Dados em uma Matriz de Animais
  Suponha que você tenha uma matriz que representa uma lista de animais, onde cada linha contém as seguintes propriedades de um animal:
    Nome
    Espécie
    Idade
    Peso
  Escreva um programa em C# que permita ao usuário buscar animais por uma determinada propriedade (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca.
  // Matriz de animais [Nome, Espécie, Idade, Peso]
        string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
        };
*/
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();

            Exercicio04();
        }

        private static void Exercicio04()
        {
            //- Escreva um programa que declare dois vetores de mesmo tamanho
            //e calcule a soma dos elementos correspondentes de ambos os vetores,
            //armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante.
            int tamanhoDoVector = 0;

            Console.WriteLine("Entre com o tamanho do vector");
            if (int.TryParse(Console.ReadLine(), out tamanhoDoVector))
            {
                int[] vector = new int[tamanhoDoVector];
                int[] vector2 = new int[tamanhoDoVector];
                int[] vectorResultante = new int[tamanhoDoVector];
                PreenchimentoVector(vector);
                PreenchimentoVector(vector2);
                for (int i = 0; i < vector.Length; i++)
                {
                    vectorResultante[i] = vector[i] + vector2[i];
                }
                ImprimirVector(vectorResultante);
            }

            static void PreenchimentoVector(int[] vector)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.WriteLine("Entre com um número inteiro:");
                    if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                    {
                        vector[i] = valorInteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        i--;
                    }
                }
            }
        }

        private static void Exercicio03()
        {
            //- Crie um programa que preencha uma matriz 3x3 com valores inteiros
            //informados pelo usuário e depois exiba essa matriz na tela.
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.WriteLine("Entre com um número inteiro:");
                    if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                    {
                        matriz[i, j] = valorInteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        i--;
                    }
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void Exercicio02()
        {
            //
            //-Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e,
            //em seguida, mostre o maior e menor valor.
            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Entre com um número inteiro:");
                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    vector[i] = valorInteiro;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    i--;
                }
            }

            int maior = vector.Max();
            int menor = vector.Min();
            Console.WriteLine($@" 
Maior número é {maior}
Menor é {menor}");
        }

        private static void Exercicio01()
        {
            //-
            //Escreva um programa que declare e inicialize um vetor com
            //5 elementos inteiros e, em seguida, exiba esses elementos na tela.
            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Entre com um número inteiro:");
                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    vector[i] = valorInteiro;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    i--;
                }
            }
            ImprimirVector(vector);



        }
        static void ImprimirVector(int[] vector)
        {
            foreach (int valorInteiro in vector)
            {
                Console.WriteLine($"Valor : {valorInteiro}");
            }
        }
    }
}
