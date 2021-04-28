using Newtonsoft.Json;
using Pokedex.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexForm.App
{
    public partial class Form1 : Form
    {
        private int i = 0;
        public List<Pokemon> pokedex;
        public Form1()
        {
            InitializeComponent();
            pokedex = PokemonUtils.GeneratePokedex();
            Load_PokemonInfo();
            Load_PokemonMenu();
        }

        private void NextPokemon_Click(object sender, EventArgs e)
        {
            //when the "Next Pokemon" button is clicked show the next pokemon along the list
            i += 1;
            Load_PokemonInfo();
        }
        private void PrevPokemon_Click(object sender, EventArgs e)
        {
            if (i > 0) // go to the previous pokemon unless index is invalid
            {
                i -= 1;
                Load_PokemonInfo();
            }
        }

        private void Load_PokemonInfo()//load the information of a pokemon on some labels
        {
            pokemonIMG.ImageLocation = pokedex[i].Image;
            pokemonIMG.Load();

            NumLabel.Text = $"ID : {pokedex[i].Num}";
            NameLabel.Text = $"Name : {pokedex[i].Name}";
            TypeLabel.Text = $"Types : {pokedex[i].TypeString}";
            HeightLabel.Text = $"Height : {pokedex[i].Height}";
            WeightLabel.Text = $"Weight : {pokedex[i].Weight}";
            SpawnChanceLabel.Text = $"Spawn Chance : {pokedex[i].SpawnChance}";
            SpawnTimeLabel.Text = $"Spawn Time : {pokedex[i].SpawnTime}";
            PrevEvoLabel.Text = $"Previous Evolution : {pokedex[i].Evolutions["prev1"]}";
            NextEvoLabel.Text = $"Next Evolution : {pokedex[i].Evolutions["next1"]}";
        }

        private void Load_PokemonMenu()  //load all pokemons into a combo box for quick access
        {
            PokemonMenu.Items.Clear();  
            foreach (Pokemon pokemon in pokedex)
            {
                PokemonMenu.Items.Add($"{pokemon.Num}: {pokemon.Name}");
            }
        }
        /// <summary>
        /// Given how to sort a pokedex, load the new required pokedex when options are changed
        /// </summary>
        /// <param name="option"></param>
        /// <param name="order"></param>
        private void Load_Pokedex(string option, string order)
        {
            i = 0; //resets current index
            switch (option)
            {
                case "ID":
                    pokedex = PokemonUtils.Pokedex;
                    break;
                case "Spawn Time":
                    pokedex = PokemonUtils.PokedexBySpawnTime;
                    break;
                case "Rarity":
                    pokedex = PokemonUtils.PokedexByRarity;
                    break;
            }

            switch (order)
            {
                case "Ascending":
                    break;
                case "Descending":
                    pokedex.Reverse();
                    break;
            }

            Load_PokemonMenu();
            Load_PokemonInfo();
        }
        private void SortByCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Pokedex(SortByCombo.Text, OrderByCombo.Text);
        }
        private void OrderByCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Pokedex(SortByCombo.Text, OrderByCombo.Text);
        }
        private void PokemonMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This loads the information of a pokemon selected via the combobox
            i = PokemonMenu.Items.IndexOf(PokemonMenu.Text);
            Load_PokemonInfo();
        }


    }
}
