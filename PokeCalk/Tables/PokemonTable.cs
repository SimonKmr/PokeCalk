using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeCalk.PokemonEntity;
using PokeCalk.PokemonTypeTable;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace PokeCalk
{
    class PokemonTable
    {
        // this class is responsible for calculating damage modifires based on pokemon types
        List<PokemonClass> pokemons { get; set; } = new List<PokemonClass>();

        public void LoadList()
        {
            //loads the typeTable
            string[] files = Directory.GetFiles(new FileInfo(Assembly.GetEntryAssembly().Location).Directory.ToString()+@"\PokemonTables");
            List<string> pokemonListPaths = new List<string>();
            foreach(var file in files)
            {
                if (file.EndsWith(".json"))
                    pokemonListPaths.Add(file);
            }

            foreach(var pokemonListPath in pokemonListPaths)
            {
                List<PokemonClass> temp = new List<PokemonClass>();
                string json = string.Empty;
                using (StreamReader sr = new StreamReader(pokemonListPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        json += line;
                    }
                    temp = JsonConvert.DeserializeObject<List<PokemonClass>>(json);
                }
                foreach(var pokemon in temp)
                {
                    pokemons.Add(pokemon);
                }
            }
        }
        public void ClearList()
        {
            pokemons.Clear();
        }
        public bool IsEmpty()
        {
            if (pokemons.Count == 0)
                return true;
            else
                return false;
        }

        public List<string> GetNames()
        {
            List<string> result = new List<string>();
            foreach(var pokemon in pokemons)
            {
                result.Add(pokemon.Name);
            }
            return result;
        }


        public PokemonClass GetPokemon(int iD, int regionID)
        {
            for (int i = 0; i < pokemons.Count; i++)
                if (pokemons[i].ID == iD && pokemons[i].RegionID == regionID)
                    return pokemons[i];
            return new PokemonClass();
        }

        public PokemonClass getPokemon(string Name)
        {
            for (int i = 0; i < pokemons.Count; i++)
                if (pokemons[i].Name == Name)
                    return pokemons[i];
            return new PokemonClass();
        }

        public PokemonTypes.Type[] getTypes(PokemonClass pokemon)
        {
            return new PokemonTypes.Type[] { (PokemonTypes.Type)pokemon.TypeIDs[0], (PokemonTypes.Type)pokemon.TypeIDs[1] };
        }
    }
}
