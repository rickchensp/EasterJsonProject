using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Lib
{
    public class PokemonUtils
    {
        static List<Pokemon> _pokedex = GeneratePokedex();

        public static List<Pokemon> Pokedex { get => _pokedex;}
        public static List<Pokemon> GeneratePokedex()
        {
            string JsonDownload;
            using (var wc = new WebClient())  //download pokedex Json data 
            {
                JsonDownload = wc.DownloadString("https://raw.githubusercontent.com/Biuni/PokemonGO-Pokedex/master/pokedex.json");
            }

            JObject j = JObject.Parse(JsonDownload);
            List<Pokemon> pokedex = new List<Pokemon> { };

            foreach (dynamic row in j["pokemon"])   //loop through each pokemon
            {
                //some values are converted into list
                List<string> type = row.type.ToObject<List<string>>();
                List<float> multipliers = row.multipliers.ToObject<List<float>>();
                List<string> weaknesses = row.weaknesses.ToObject<List<string>>();
                
                //new pokemon generated
                Pokemon newPokemon = new Pokemon((int)row.id, (string)row.num,
                    (string)row.name, (string)row.img, type, (string)row.height,
                    (string)row.weight, (string)row.candy, row.candy_count,
                    (string)row.egg, (float)row.spawn_chance, (float)row.avg_spawns,
                    (string)row.spawn_time, multipliers, weaknesses);
                
                //the evolutions of a pokemon need more processing
                newPokemon.FindEvolutions(row);
                pokedex.Add(newPokemon);
            }

            return pokedex;
        }

        public static Pokemon IDtoPokemon(int id)
        {
            return _pokedex[id - 1];
        }

        //different ways to sort the pokedex
        public static List<Pokemon> PokedexByRarity
        {
            get => _pokedex.OrderBy(x => x.SpawnCPercent).ToList();
        }
        public static List<Pokemon> PokedexBySpawnTime
        {
            get => _pokedex.OrderBy(x => x.SpawnTime).ToList();
        }
    }
}
