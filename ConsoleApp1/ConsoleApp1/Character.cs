using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Character
    {
        //RASY TaDYYYYYYY
        private string[] races = { "Elf", "Dwarf", "Human", "Barbarian", "Goblin" };
        private string name{ get;  set; }
        public string Name 
        {
            get
            {
                return name;
            }
            set 
            {
                name = value;
            } 
        }
        private string race { get; set; }
        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                foreach (string r in races)
                {
                    if (value == r)
                    {
                        race = value;
                        return;
                    }
                    
                }
                
                    Console.WriteLine("Neplatná rasa, zvolte znovu:");
                    Race = Console.ReadLine();
                
            }
        }
        private int age{ get; set; }
        public int Age { get; private set; }
        private string gender{ get; set; }
        public string Gender { get; private set; }
        private string p_class { get; set; }
        public string p_Class { get; private set; }
        private string weapon { get; set; }
        public string Weapon { get; private set; }


        public void Load()
        {
            StreamReader postava = new StreamReader("Character.txt");
            if (postava.ReadLine() == null)
            {
                Console.WriteLine("Nemáte žádnou postavu, musíte si vytvořit novou.");
                Create_Character();
            }
            // musis dodelat jak se vytvari postava
        }
        public void Create_Character()
        {
            // postav apotrebuje jmeno rasa vek  pohlavi tridu zbran // minulost udelame podle toho co si hrac vybere
            Console.WriteLine("Jak se chcete jmenovat?:");
            Name = Console.ReadLine();
            Console.WriteLine("Jaká je vaše rasa?:");
            Race = Console.ReadLine();
            Console.WriteLine("Jaký je váš věk?:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Jaké je vaše pohlaví?:");
            Gender = Console.ReadLine();
            Console.WriteLine("Jakou třídu si vyberete?:");
            p_Class = Console.ReadLine();
            Console.WriteLine("Jakou zbraň si vyberete?:");
            Weapon = Console.ReadLine();
            

        }
    }
}
