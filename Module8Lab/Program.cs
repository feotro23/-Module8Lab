using System;
using System.Collections.Generic;
using System.Linq;

class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Level { get; set; }
}

class PokemonLINQLab
{
    static void Main()
    {
        // Sample data: list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15 },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10 },
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22 },
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25 }
        };

        // LINQ Query: find Pokemon ready to evolve (level 16 for first evolution)
        var readyToEvolve = from p in pokemons
                            where p.Level >= 16
                            orderby p.Level
                            select p;

        // Execute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve:");
        foreach (var p in readyToEvolve)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }
        
        Console.WriteLine("\n-----------------------------------\n");

        // NEW LINQ Query: find Water type Pokemon
        var waterPokemon = from p in pokemons
                           where p.Type == "Water"
                           select p;

        /* Alternatively, you can use Method Syntax:
           var waterPokemon = pokemons.Where(p => p.Type == "Water"); 
        */

        // Execute the query and display the results
        Console.WriteLine("Water Type Pokemon:");
        foreach (var p in waterPokemon)
        {
            Console.WriteLine($"Name: {p.Name}, Level: {p.Level}");
        }
    }
}

