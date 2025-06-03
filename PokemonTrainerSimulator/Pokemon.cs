using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public abstract class Pokemon
    {
        private string name;
        private int level;
        public ElementType Type { get; }
        public List<Attack> Attacks { get; } 

        public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = attacks ?? new List<Attack>(); // Säkerställer att listan aldrig är null
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2 || value.Length > 15)
                {
                    throw new ArgumentException("Namnet måste vara mellan 2 och 15 tecken långt.");
                }
                name = value;
            }
        }

        public int Level
                    {
            get { return level; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Level måste vara 1 eller högre.");
                }

                level = value;
            }
        }

        public void RandomAttack() 
        {
            if (Attacks.Count > 0)// Kontrollera att det finns attacker att använda
            {
                var random = new Random();
                int index = random.Next(Attacks.Count);
                Attacks[index].Use(Level); 
            }
            else
            {
                Console.WriteLine($"{Name} har inga attacker att använda!");
            }
        }

        public void Attack() 
        {
            Console.WriteLine($"{Name}, välj en attack: ");

            for (int i = 0; i < Attacks.Count; i++)//skriver ut lista över attacker att välja
            {
                Console.WriteLine($"{i + 1}: {Attacks[i].Name}"); 
            }
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= Attacks.Count)//kontrollerar att användaren väljer en giltig attack
            { 
                Attacks[choice - 1].Use(Level); //choice -1 för att matcha listindexering som börjar på 0
            }
            else
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
                //Attack(); // Anropa metoden igen för att låta användaren göra ett nytt val
            }
        }

        public void RaiseLevel()
        {
            level++; 
            Console.WriteLine($"{Name} har nått level {level}!");
        }
    }
}
