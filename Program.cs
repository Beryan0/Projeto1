// See https://aka.ms/new-console-template for more information
namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name???");
            {
                var name = Console.ReadLine();
                while (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name) || name.NumberVerification() == true)
                {
                    Console.Out.WriteLine("Entrada inválida, tente novamente");
                    name = Console.ReadLine();
                }
                {
                    var datadehoje = DateTime.Now;
                    Console.WriteLine($"Hello, {name}, on {datadehoje:d} at {datadehoje:t}!!!");
                    Console.Write($"{Environment.NewLine} Press any key to exit...");
                    Console.ReadKey(true);
                }
            }
        }
    }
}