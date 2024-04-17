namespace Lista02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();

            ExercicioPets();
        }

        static void ExercicioPets()
        {
            /*- Busca de Dados em uma Matriz de Animais
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
        };*/

            string[,] animais = { // 5x4
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
            };

            foreach (var item in animais)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Pesquisa de pets");
            MenuDeOpcoes(out string operacao);//Função para verificar as opções

            if (operacao.Equals("exit"))//Verificar se deve encerrar
            {
                return;
            }
            Console.WriteLine("Entre com o valor da pesquisa:");
            var valorParaPesquisar = Console.ReadLine();

            for (int i = 0; i < animais.GetLength(0); i++)
            {
                if (valorParaPesquisar.Equals(animais[i, int.Parse(operacao)]))
                {
                    Console.WriteLine($"Encontrado {ImprimirAnimal(animais, i)}");
                }
            }
        }

        static string ImprimirAnimal(string[,] animais, int indiceAnimal)
        {
            const int indiceNome = 0;
            const int indiceEspecie = 1;
            const int indiceIdade = 2;
            const int indicePeso = 3;
            string animal = $"nome: {animais[indiceAnimal, indiceNome]}, especie: {animais[indiceAnimal, indiceEspecie]}";
            return animal;
        }

        static void MenuDeOpcoes(out string operacao)
        {
            Console.Clear();//Limpar a tela
            Console.WriteLine(@"
            Para buscar por nome digite 0 
            Para buscar por especie digite 1 
            Para buscar por idade digite 2 
            Para buscar por peso digite 3 
            Para sair, digite 'exit'");

            operacao = Console.ReadLine().ToLower();
            operacao = operacao == null ? string.Empty : operacao.Trim();
        }


        static void Exercicio05()
        {
            //-Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.

            int[,] numerosInteiros = new int[4, 4];

            Random random = new Random();

            for (int i = 0; i < numerosInteiros.GetLength(0); i++)
            {
                for (int j = 0; j < numerosInteiros.GetLongLength(0); j++)
                {
                    numerosInteiros[i, j] = random.Next(int.MinValue, int.MaxValue);
                }
            }
            int maior = numerosInteiros[0, 0];

            for (int i = 0; i < numerosInteiros.GetLength(0); i++)
            {
                for (int j = 0; j < numerosInteiros.GetLongLength(0); j++)
                {
                    if (numerosInteiros[i, j] > maior)
                    {
                        maior = numerosInteiros[i, j];
                    }
                }
            }

            Console.WriteLine($"Maior número da matriz {maior}");
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
            PreenchimentoVector(vector);

            int maior = vector.Max();
            int menor = vector.Min();
            Console.WriteLine($" Maior número é {maior} \r\n Menor é {menor}");
        }

        private static void Exercicio01()
        {
            //-
            //Escreva um programa que declare e inicialize um vetor com
            //5 elementos inteiros e, em seguida, exiba esses elementos na tela.
            int[] vector = new int[5];
            PreenchimentoVector(vector);
            ImprimirVector(vector);
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

        static void ImprimirVector(int[] vector)
        {
            foreach (int valorInteiro in vector)
            {
                Console.WriteLine($"Valor : {valorInteiro}");
            }
        }
    }
}
