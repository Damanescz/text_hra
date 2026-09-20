namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej ve hře!");
            Console.WriteLine("chcete načíst nebo vytvořit novou postavu?");
            while (true)
            {
                string choice = Console.ReadLine();
                if (choice.ToLower() == "načíst" || choice.ToLower() == "nacist")
                {
                    Console.WriteLine("nacitani");
                    Load();
                }
                else if (choice.ToLower() == "vytvořit" || choice.ToLower() == "vytvorit")
                {
                    Console.WriteLine("Vytvařeno");

                }
                else
                {
                    Console.WriteLine("Nerozumím");
                }
            }
        }

        static void Load()
        {
            
        }
    }
}
