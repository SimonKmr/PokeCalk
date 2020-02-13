using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCalk.PokemonEntity
{
    class PokemonClass
    {
        public int ID { get; set; }
        public int RegionID { get; set; }
        public String Name { get; set; }
        public int GenderID { get; set; }
        public int[] TypeIDs { get; set; }
        public List<int> AbilityIDs { get; set; }
        public List<int> MoveSetIDs { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public PokemonStats Stats { get; set; }
    }

    public class PokemonStats
    {
        enum Stats { Hp, Atk, Def, SpAtk, SpDef, Speed}
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int SpAtk { get; set; }
        public int SpDef { get; set; }
        public int Speed { get; set; }
    }
}
