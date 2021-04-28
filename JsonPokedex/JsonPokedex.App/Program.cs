using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pokedex.Lib;

namespace JsonPokedex.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokedex = PokemonUtils.Pokedex;
            List<Pokemon> pokedexBySpawnTime = PokemonUtils.PokedexBySpawnTime;
            List<Pokemon> pokedexByRarity = PokemonUtils.PokedexByRarity;

            Console.ReadKey();
        }
    }
}
