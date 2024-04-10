using System.Net;
using System.Runtime.Intrinsics.X86;

namespace Lista02
{
    //# Exercícios    
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio01();
            Exercicio02();
            Exercicio03();
            Exercicio04();
            Exercicio05();
        }

        private static void Exercicio01()
        {
            Console.WriteLine("//- Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.\r\n");
            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Entre com um número inteiro");
                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    vector[i] = valorInteiro;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, insira um valor inteiro.");
                    i--; // Volta para a mesma posição para pedir o valor novamente
                }
            }
            foreach (int valorInteiroDoVetor in vector)
            {
                Console.WriteLine(valorInteiroDoVetor);
            }
            Console.ReadLine();
        }

        //- Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.
        private static void Exercicio02()
        {
            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Entre com um número inteiro");
                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    vector[i] = valorInteiro;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, insira um valor inteiro.");
                    i--; // Volta para a mesma posição para pedir o valor novamente
                }
            }
            int maior = vector[0];
            int menor = vector[0];
            foreach (int valorInteiroDoVetor in vector)
            {
                if (maior < valorInteiroDoVetor)
                {
                    maior = valorInteiroDoVetor;
                }
                if (menor > valorInteiroDoVetor)
                {
                    menor = valorInteiroDoVetor;
                }
            }
            Console.WriteLine($"Maior {maior} Menor {menor}");
        }

        //- Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

        private static void Exercicio03()
        {
            int[,] matriz = new int[3, 3];

            // Preenchendo a matriz com valores informados pelo usuário
            Console.WriteLine("Preencha a matriz 3x3 com valores inteiros:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                    {
                        matriz[i, j] = valorInteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Por favor, insira um valor inteiro.");
                        j--; // Volta para a mesma posição para pedir o valor novamente
                    }
                }
            }

            // Exibindo a matriz na tela
            Console.WriteLine("\nMatriz 3x3:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //- Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes de ambos os vetores, armazenando o resultado em um terceiro vetor.Em seguida, exiba o vetor resultante.
        private static void Exercicio04()
        {
            Console.WriteLine("Entre com o tamanho do vetor");
            if (int.TryParse(Console.ReadLine(), out int tamanhoVector))
            {

                int[] vector = new int[tamanhoVector];
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.WriteLine("Entre com um número inteiro");
                    if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                    {
                        vector[i] = valorInteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Por favor, insira um valor inteiro.");
                        i--; // Volta para a mesma posição para pedir o valor novamente
                    }
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, insira um valor inteiro.");
                Exercicio04();
            }
        }

        //- Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.      
        private static void Exercicio05()
        {
            int[,] matriz = new int[3, 3];

            // Preenchendo a matriz com valores informados pelo usuário
            Console.WriteLine("Preencha a matriz 3x3 com valores inteiros:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                    {
                        matriz[i, j] = valorInteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Por favor, insira um valor inteiro.");
                        j--; // Volta para a mesma posição para pedir o valor novamente
                    }
                }
            }

            // Encontrando o maior valor presente na matriz
            int maiorValor = matriz[0, 0];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    if (matriz[i, j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                    }
                }
            }

            // Exibindo a matriz e o maior valor encontrado
            Console.WriteLine("Matriz 4x4 de números inteiros aleatórios:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLongLength(0); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"O maior valor presente na matriz é: {maiorValor}");
        }

        //- Busca de Dados em uma Matriz de Animais
        //  Suponha que você tenha uma matriz que representa uma lista de animais, onde cada linha contém as seguintes propriedades de um animal:
        //    Nome
        //    Espécie
        //    Idade
        //    Peso
        //  Escreva um programa em C# que permita ao usuário buscar animais por uma determinada propriedade (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca.
        //  // Matriz de animais [Nome, Espécie, Idade, Peso]
        //        string[,] animais = {
        //        { "Fido", "Cachorro", "5", "10kg" },
        //            { "Whiskers", "Gato", "5", "5kg" },
        //            { "Buddy", "Cachorro", "3", "8kg" },
        //            { "Fluffy", "Gato", "2", "4kg" },
        //            { "Spot", "Cachorro", "4", "12kg" }
        //    };
        private static void Exercicio06()
        {
            // Matriz de animais [Nome, Espécie, Idade, Peso]
            string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
        };

            Console.WriteLine("Digite a propriedade pela qual deseja buscar (nome, espécie, idade ou peso):");
            string propriedade = Console.ReadLine();

            Console.WriteLine("Digite o valor da propriedade:");
            string valorBusca = Console.ReadLine();
            int indicePropriedade = -1;
            switch (propriedade)
            {
                case "nome":
                    indicePropriedade = 0;
                    break;
                case "espécie":
                    indicePropriedade = 1;
                    break;
                case "idade":
                    indicePropriedade = 2;
                    break;
                case "peso":
                    indicePropriedade = 3;
                    break;
                default:
                    Console.WriteLine("Propriedade inválida.");
                    return;
            }

            bool encontrado = false;
            for (int i = 0; i < animais.GetLength(0); i++)
            {
                if (animais[i, indicePropriedade].ToLowerInvariant() == valorBusca.ToLowerInvariant())
                {
                    string nome = animais[i, 0];
                    string especie = animais[i, 1];
                    string idade = animais[i, 2];
                    string peso = animais[i, 3];

                    Console.WriteLine($"Animal encontrado: {nome} ({especie}), Idade: {idade}, Peso: {peso}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nenhum animal encontrado com essa propriedade.");
            }
        }
    }
}
