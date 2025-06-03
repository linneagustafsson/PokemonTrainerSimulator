﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainerSimulator
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, List<Attack> attacks)
        : base(name, level, ElementType.Fire, attacks)
        {
        }

    }
}
