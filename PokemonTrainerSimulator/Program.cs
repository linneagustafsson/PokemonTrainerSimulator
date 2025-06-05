using PokemonTrainerSimulator;
//skapar attacker 
var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
var ember = new Attack("Ember", ElementType.Fire, 6);

var waterGun = new Attack("Water Gun", ElementType.Water, 10);
var bubble = new Attack("Bubble", ElementType.Water, 5);

var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 15);
var spark = new Attack("Spark", ElementType.Electric, 8);

//skapar pokemon
var charmander = new Charmander(5, new List<Attack> { flamethrower, ember });
var squirtle = new Squirtle(7, new List<Attack> { waterGun, bubble });
var pikachu = new Pikachu(10, new List<Attack> { thunderbolt, spark });


List<Pokemon> trainerPokemons = new List<Pokemon>{ charmander, squirtle, pikachu };

foreach (var pokemon in trainerPokemons)
{
    pokemon.RaiseLevel();
    pokemon.RandomAttack();

    if(pokemon is IEvolvable evolvablePokemon) 
    {
        evolvablePokemon.Evolve();
    }
    Console.ReadKey();
}

    