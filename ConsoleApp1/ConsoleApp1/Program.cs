namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej ve hře!");
            Console.WriteLine("chcete načíst nebo vytvořit novou postavu?");
            Character character = new Character();

            
            while (true)
            {
                string choice = Console.ReadLine();
                if (choice.ToLower() == "načíst" || choice.ToLower() == "nacist")
                {
                    Console.WriteLine("nacitani");
                    character.Load_Character();
                }
                else if (choice.ToLower() == "vytvořit" || choice.ToLower() == "vytvorit")
                {
                    Console.WriteLine("Vytvařeno");
                    character.Create_Character();

                }
                else
                {
                    Console.WriteLine("Nerozumím");
                }
            }
        }

        

         
    }
}
