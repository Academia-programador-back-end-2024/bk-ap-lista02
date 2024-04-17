namespace exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
        };

            Console.WriteLine("Buscar por:");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Espécie");
            Console.WriteLine("3 - Idade");
            Console.WriteLine("4 - Peso");
            Console.Write("Escolha uma opção: ");

            int opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor para buscar: ");
            string valorBusca = Console.ReadLine();

       
            for (int i = 0; i < animais.GetLength(0); i++)
            {
                if (animais[i, opcao - 1].Equals(valorBusca, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Nome: {animais[i, 0]}, Espécie: {animais[i, 1]}, Idade: {animais[i, 2]}, Peso: {animais[i, 3]}");
                }
            }
        }
    }
}