using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Character
    {
        //RASY TaDYYYYYYY
        private string[] races = { "Elf", "Dwarf", "Human", "Barbarian", "Goblin" };
        private string[] Classes = { "Mage", "Druid", "Fighter", "Rogue", "Ranger" };
        private string[] weapons = { "Meč", "Luk", "Palice", "Hůl", "kniha", "Štít", "Nožík" };
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
                    if (value.ToLower() == r.ToLower())
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
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Věk nemůže být záporný, zvolte znovu:");
                    Age = int.Parse(Console.ReadLine());
                }
                else
                {
                    age = value;
                }
            }
        }
        private string gender{ get; set; }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value.ToLower() == "muž" || value.ToLower() == "muz" || value.ToLower() == "žena" || value.ToLower() == "zena")
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Neplatné pohlaví, zvolte znovu:");
                    Gender = Console.ReadLine();
                }

            }
        }
        private string p_class { get; set; }
        public string p_Class
        {
            get
            {
                return p_class;
            }
            set
            {
                foreach (string r in Classes)
                {
                    if (value.ToLower() == r.ToLower())
                    {
                        p_class = value;
                        return;
                    }

                }

                Console.WriteLine("Neplatná třída, zvolte znovu:");
                p_Class = Console.ReadLine();

            }
        }
        private string weapon { get; set; }
        public string Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                foreach (string r in weapons)
                {
                    if (value.ToLower() == r.ToLower())
                    {
                        weapon = value;
                        return;
                    }

                }

                Console.WriteLine("Neplatná zbraň, zvolte znovu:");
                Weapon = Console.ReadLine();

            }
        }


        public void Load_Character()
        {
            StreamReader postavy = new StreamReader("Character.txt");
            if (postavy.ReadLine() == null)
            {
                Console.WriteLine("Nemáte žádnou postavu, musíte si vytvořit novou.");
                postavy.Close();
                Create_Character();
            }
            
            postavy.Open();
            while (postavy.ReadLine() != null)
            {
                Console.WriteLine("test2");
                string[] jmeno = postavy.ReadLine().Split(';');
                Console.WriteLine($"{jmeno[0]}");
                break;
             }
            Console.WriteLine("test3");

            // musis dodelat jak se vytvari postava
        }
        public void Create_Character()
        {
            // postav apotrebuje jmeno rasa vek  pohlavi tridu zbran // minulost udelame podle toho co si hrac vybere
            Console.WriteLine("Jak se chcete jmenovat?:");
            Name = Console.ReadLine();
            Console.WriteLine("Jaká je vaše rasa?:");
            foreach (string r in races)
            {
                Console.Write($"{r}, ");

            }
            Race = Console.ReadLine();
            Console.WriteLine("Jaký je váš věk?:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Jaké je vaše pohlaví?:");
            Gender = Console.ReadLine();
            Console.WriteLine("Jakou třídu si vyberete?:");
            foreach (string r in Classes)
            {
                Console.Write($"{r}, ");

            }
            p_Class = Console.ReadLine();
            Console.WriteLine("Jakou zbraň si vyberete?:");
            foreach (string r in weapons)
            {
                Console.Write($"{r}, ");

            }
            Weapon = Console.ReadLine();
            Console.WriteLine($"Vaše postava se jmenuje {Name}, je to {Race}, má {Age} let, je to {Gender}, je to {p_Class} a má zbraň {Weapon}.");
            StreamWriter postava = new StreamWriter("Character.txt");
            // 0xp a  potom vypoctano zbyvajici pocet zivotu ted dame 100 ale v budoucnu bude zalezet na rase, tride a věku
            postava.WriteLine($"{Name};{Race};{Age};{Gender};{p_Class};{Weapon};0;100");
            postava.Close();

        }
    }
}
