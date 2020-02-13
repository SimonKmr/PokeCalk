using PokeCalk.PokemonEntity;
using PokeCalk.PokemonTypeTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCalk.Tables
{
    class Prep4Dgv
    {
        public static object[] Stats2DGV(PokemonClass[] PkmnTeam)
        {
            //creates arrays with Strings that contain the values of Pokemon DamageMultiplyers
            object[] result = new object[PkmnTeam.Length];
            //gets every type of a Matchup with a certain Ability
            String[] rowHp = new String[8];
            String[] rowAtk = new String[8];
            String[] rowDef = new String[8];
            String[] rowSpAtk = new String[8];
            String[] rowSpDef = new String[8];
            String[] rowSpeed = new String[8];

            double HpAvr = 0;
            double AtkAvr = 0;
            double DefAvr = 0;
            double SpAtkAvr = 0;
            double SpDefAvr = 0;
            double SpdAvr = 0;



            rowHp[0] = "Hp";
            rowAtk[0] = "Atk";
            rowDef[0] = "Def";
            rowSpAtk[0] = "SpAtk";
            rowSpDef[0] = "SpDef";
            rowSpeed[0] = "Speed";

            for (int i = 0; i < PkmnTeam.Length; i++)
            {
                rowHp[i + 1] = PkmnTeam[i].Stats.Hp.ToString();
                rowAtk[i + 1] = PkmnTeam[i].Stats.Atk.ToString();
                rowDef[i + 1] = PkmnTeam[i].Stats.Def.ToString();
                rowSpAtk[i + 1] = PkmnTeam[i].Stats.SpAtk.ToString();
                rowSpDef[i + 1] = PkmnTeam[i].Stats.SpDef.ToString();
                rowSpeed[i + 1] = PkmnTeam[i].Stats.Speed.ToString();

                HpAvr += PkmnTeam[i].Stats.Hp;
                AtkAvr += PkmnTeam[i].Stats.Atk;
                DefAvr += PkmnTeam[i].Stats.Def;
                SpAtkAvr += PkmnTeam[i].Stats.SpAtk;
                SpDefAvr += PkmnTeam[i].Stats.SpDef;
                SpdAvr += PkmnTeam[i].Stats.Speed;
            }

            AtkAvr = Math.Round(AtkAvr /= PkmnTeam.Length, 2);
            HpAvr = Math.Round(HpAvr /= PkmnTeam.Length, 2);
            DefAvr = Math.Round(DefAvr /= PkmnTeam.Length, 2);
            SpAtkAvr = Math.Round(SpAtkAvr /= PkmnTeam.Length, 2);
            SpDefAvr = Math.Round(SpDefAvr /= PkmnTeam.Length, 2);
            SpdAvr = Math.Round(SpdAvr /= PkmnTeam.Length, 2);

            rowHp[7] = HpAvr.ToString();
            rowAtk[7] = AtkAvr.ToString();
            rowDef[7] = DefAvr.ToString();
            rowSpAtk[7] = SpAtkAvr.ToString();
            rowSpDef[7] = SpDefAvr.ToString();
            rowSpeed[7] = SpdAvr.ToString();

            result[0] = rowHp;
            result[1] = rowAtk;
            result[2] = rowDef;
            result[3] = rowSpAtk;
            result[4] = rowSpDef;
            result[5] = rowSpeed;

            return result;
        }
        
        public static object[] Types2DGV(PokemonClass[] PkmnTeam)
        {
            //creates arrays with Strings that contain the values of Pokemon DamageMultiplyers
            object[] result = new object[PokemonTypes.TypeCount];
            PokemonTypes types = new PokemonTypes();
            //gets every type of a Matchup with a certain Ability
            for (int i = 0; i < PokemonTypes.TypeCount; i++)
            {
                double typeScore = 0;
                String[] row = new String[8];
                row[0] = ((PokemonTypes.Type)i + 1).ToString();
                for (int j = 0; j < PkmnTeam.Length; j++)
                    row[j + 1] = types.GetPokemonDmgMultiplire((i + 1), PkmnTeam[j].TypeIDs[0], PkmnTeam[j].TypeIDs[1], PkmnTeam[j].AbilityIDs.ToArray()).ToString();
                result[i] = row;

                //ges team

                for (int j = 0; j < PkmnTeam.Length; j++)
                    typeScore += types.GetPokemonDmgMultiplire((i + 1), PkmnTeam[j].TypeIDs[0], PkmnTeam[j].TypeIDs[1], PkmnTeam[j].AbilityIDs.ToArray());

                typeScore /= PkmnTeam.Length;
                typeScore = Math.Round(typeScore, 2);
                row[7] = typeScore.ToString();
                result[i] = row;
            }
            return result;
        }
    }
}
