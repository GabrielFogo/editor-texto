
using System.Reflection;

namespace texteditor
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
                    Abrir();
                    break;
                case 2:
                    Editar();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
            }
        }

        public static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            VoltarMenu();
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
            Console.WriteLine("A");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Deseja Salvar ? (S - sim / N -Não)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
                Salvar(text);
            else
                Menu();

        }

        public static void Salvar(string text)
        {
            Console.WriteLine("Qual é o caminho para salvar o seu arquivo");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo em {path} com sucesso !");
            VoltarMenu();

        }

        public static void VoltarMenu()
        {
            Console.WriteLine("Prescione alguma tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

    }
}
