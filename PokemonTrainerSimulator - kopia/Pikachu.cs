using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(int level, List<Attack> attacks): base("Pikachu", level, attacks)
        {
        }

        public void Evolve()
        {
            Name = "Raichu";
            Level += 10;
            Console.WriteLine("PiKachu är på väg att utvecklas...");
            Console.WriteLine($"Nu är det {Name}! Level {Level}!");
        }
    }
}
