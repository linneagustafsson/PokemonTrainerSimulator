using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    internal class Ponyta : FirePokemon, IEvolvable
    {
        public Ponyta (int level, List<Attack> attacks) : base("Ponyta", level, attacks)
        {
        }
        public void Evolve()
        {
            Name = "Rapidash";
            Level += 10;
            Console.WriteLine("Ponyta är på väg att utvecklas...");
            Console.WriteLine($"Nu är det {Name}! Level {Level}!");
        }
    }
}
