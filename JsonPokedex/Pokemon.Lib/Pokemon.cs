using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Pokedex.Lib
{
    public class Pokemon
    {
        int _id;
        string _num, _name, _img;
        List<string> _type;
        string _height, _weight, _candy;
        int _candy_count;
        string _egg;
        float _spawn_chance, _avg_spawn;
        string _spawn_time; 
        List<float> _multipliers;
        List<string> _weaknesses;

        Dictionary<string, string> _evolutions = new Dictionary<string, 
            string>
        {{"prev2", "None"},{"prev1", "None"},{"next1", "None"},{"next2", "None"}};

        public Pokemon(int i, string num, string name, string img,
            List<string> type, string height, string weight, string candy, dynamic candy_count,
            string egg, float spawn_chance, float avg_spawn, string spawn_time,
            List<float> multipliers, List<string> weaknesses)
        {
            _id = i;
            _num = num;
            _name = name;
            _img = img;
            _type = type;
            _height = height;
            _weight = weight;
            _candy = candy;  //name of its candy
            _candy_count = (candy_count == null) ? 0 : candy_count;
            _egg = egg;   //name of its egg
            _spawn_chance = spawn_chance;  //chance of spawning
            _avg_spawn = avg_spawn;    //chance of spawning in percentage 
            _spawn_time = spawn_time;   //time of day at which it spawns
            _multipliers = multipliers;
            _weaknesses = weaknesses;
        }

        public override string ToString()
        {
            return _name;
        }
        public int ID { get => _id; set => _id = value; }
        public string Num { get => _num; set => _num = value; }
        public string Name { get => _name; set => _name = value; }
        public string Image { get => _img; set => _img = value; }
        public List<string> Type { get => _type; set => _type = value; }
        public string TypeString //turns the list of types into a string for presentation
        {
            get
            {
                string str = string.Empty;
                foreach(string type in Type)
                {
                    str += $"{type}, ";
                }
                return str.Substring(0, str.Count() - 2);
            }
        }
        public string Height { get => _height; set => _height = value; }
        public string Weight { get => _weight; set => _weight = value; }
        public string CandyType { get => _candy; set => _candy = value; }
        public int CandyCount { get => _candy_count; set => _candy_count = value; }
        public string EggHatchDistance { get => _egg; set => _egg = value; }
        public float SpawnChance { get => _spawn_chance; set => _spawn_chance = value; }
        public float SpawnCPercent { get => _avg_spawn; set => _avg_spawn = value; }
        public string SpawnTime { get => _spawn_time; set => _spawn_time = value; }
        public List<float> Multipliers { get => _multipliers; set => _multipliers = value; }
        public List<string> Weaknesses { get => _weaknesses; set => _weaknesses = value; }
        public Dictionary<string, string> Evolutions{ get => _evolutions; set => _evolutions = value; }

        /// <summary>
        /// extract the previous and next evolutions of a pokemon from a json string,
        /// and then assign them to a dictionary if they exists
        /// </summary>
        /// <param name="row"></param>
        public void FindEvolutions(dynamic row) 
        {
            if(row.ContainsKey("next_evolution"))
            {
                int n = row.next_evolution.Count;
                for(int i = 1; i <= n ; ++i)
                {
                    dynamic relative = row.next_evolution[i - 1];
                    dynamic data = relative.num;
                    _evolutions[$"next{i}"] = (string)relative.name;
                }
            }
            if(row.ContainsKey("prev_evolution"))
            {
                int n = row.prev_evolution.Count;
                for (int i = 1; i <= n; ++i)
                {
                    dynamic relative = row.prev_evolution[n - i];
                    dynamic data = relative.num;
                    _evolutions[$"prev{i}"] = (string)relative.name;
                }
            }
        }

    }
}
