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
                    Create();

                }
                else
                {
                    Console.WriteLine("Nerozumím");
                }
            }
        }

        static void Load()
        {
            StreamReader postava = new StreamReader("Character.txt");
            if (postava.ReadLine() == null)
            {
                Console.WriteLine("Nemáte žádnou postavu, musíte si vytvořit novou.");
                Create();
            }
            // musis dodelat jak se vytvari postava
        }

        static void Create()
        {
            // postav apotrebuje jmeno rasa vek  pohlavi tridu zbran // minulost udelame podle toho co si hrac vybere
            Console.WriteLine("Jak se chcete jmenovat?:");
            string name = Console.ReadLine();
            Console.WriteLine("Jaký je váš věk?:");
            int age = int.Parse(Console.ReadLine());
            // dodelej věk aby se zpracoval
            do
            {
                
            } while (age < 0);
            


        }
        public int 
    }
}
