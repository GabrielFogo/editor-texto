using System.Buffers;

namespace Cronometro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer ?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("3 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Editar();
                    break;
                // case 2:
                //     Criar();
                //     break;
                case 3:
                    System.Environment.Exit(0);
                    break;
            }
        }

        public static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("----------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(text);
        }

    }
}
