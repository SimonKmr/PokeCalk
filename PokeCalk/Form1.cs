using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokeCalk.PokemonEntity;
using PokeCalk.PokemonTypeTable;
using PokeCalk.Tables;
using Newtonsoft.Json;

namespace PokeCalk
{
    public partial class FormMain : Form
    {
        PokemonTable pokemons = new PokemonTable();
        public FormMain()
        {
            pokemons.LoadList();
            InitializeComponent();
            
            InitializeTypeSelectors();
        }
        private void btnCalk_Click(object sender, EventArgs e)
        {
            
            //Creates a pokemon clears a table and add rows with damage multiplyer values
            PokemonClass[] PkmnTeam = GetPokemonTeam();

            var rowsType = Prep4Dgv.Types2DGV(PkmnTeam);
            dgvTypes.Rows.Clear();
            foreach(string[] row in rowsType)
                dgvTypes.Rows.Add(row);

            var rowsStats = Prep4Dgv.Stats2DGV(PkmnTeam);
            dgvStats.Rows.Clear();
            foreach (string[] row in rowsStats)
                dgvStats.Rows.Add(row);

        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeTypeSelectors();
            dgvTypes.Rows.Clear();
        }


        private PokemonClass[] GetPokemonTeam()
        {
            //creates a pokemonTeam with the values from the ComboBoxes
            PokemonClass[] PkmnTeam = new PokemonClass[6];
            PkmnTeam[0] = pokemons.GetPokemon(cmbP0.SelectedIndex + 1, 0);
            PkmnTeam[1] = pokemons.GetPokemon(cmbP1.SelectedIndex + 1, 0);
            PkmnTeam[2] = pokemons.GetPokemon(cmbP2.SelectedIndex + 1, 0);
            PkmnTeam[3] = pokemons.GetPokemon(cmbP3.SelectedIndex + 1, 0);
            PkmnTeam[4] = pokemons.GetPokemon(cmbP4.SelectedIndex + 1, 0);
            PkmnTeam[5] = pokemons.GetPokemon(cmbP5.SelectedIndex + 1, 0);

            return PkmnTeam;
        }
        private void InitializeTypeSelectors()
        {
            //sets the values of the ComboBoxes
            cmbP0.DataSource = pokemons.GetNames();
            cmbP1.DataSource = pokemons.GetNames();
            cmbP2.DataSource = pokemons.GetNames();
            cmbP3.DataSource = pokemons.GetNames();
            cmbP4.DataSource = pokemons.GetNames();
            cmbP5.DataSource = pokemons.GetNames();
            cmbP0.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbP5.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTeam.ShowDialog();
            PokemonSave TeamCmbIndexes = new PokemonSave
            {
                teamIDs = new int[]
                {
                    cmbP0.SelectedIndex,
                    cmbP1.SelectedIndex,
                    cmbP2.SelectedIndex,
                    cmbP3.SelectedIndex,
                    cmbP4.SelectedIndex,
                    cmbP5.SelectedIndex
                }
            };

            string path = saveTeam.FileName;

            if (path.Equals(String.Empty))
                return;

            var json = JsonConvert.SerializeObject(TeamCmbIndexes);

            using (StreamWriter sw = new StreamWriter(path+".json"))
            {
                sw.WriteLine(json);
            }
        }
        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PokemonSave team = new PokemonSave();
            openTeam.ShowDialog();
            string path = openTeam.FileName;
            if (path.Equals(String.Empty))
                return;
            PokemonSave Team;
            using (StreamReader sr = new StreamReader(path))
            {
                Team = JsonConvert.DeserializeObject<PokemonSave>(sr.ReadToEnd());
            }

            cmbP0.SelectedIndex = Team.teamIDs[0];
            cmbP1.SelectedIndex = Team.teamIDs[1];
            cmbP2.SelectedIndex = Team.teamIDs[2];
            cmbP3.SelectedIndex = Team.teamIDs[3];
            cmbP4.SelectedIndex = Team.teamIDs[4];
            cmbP5.SelectedIndex = Team.teamIDs[5];
        }
        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.office.com/Pages/ResponsePage.aspx?id=DQSIkWdsW0yxEjajBLZtrQAAAAAAAAAAAANAAdQYfntUM0lFMlI2MTBSNEFQVkxNWjFVUDFCR0NVNi4u");
        }

        private void cmbP0_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = cmbP0.SelectedIndex + 1; 
            picBoxPkmn1.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxPkmn1.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/"+ number + ".png";
        }

        private void cmbP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = cmbP1.SelectedIndex + 1;
            picBoxPkmn2.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxPkmn2.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + number + ".png";
        }

        private void cmbP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = cmbP2.SelectedIndex + 1;
            picBoxPkmn3.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxPkmn3.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + number + ".png";
        }

        private void cmbP3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = cmbP3.SelectedIndex + 1;
            picBoxPkmn4.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxPkmn4.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + number + ".png";
        }

        private void cmbP4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = cmbP4.SelectedIndex + 1;
            picBoxPkmn5.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxPkmn5.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + number + ".png";
        }

        private void cmbP5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number = cmbP5.SelectedIndex + 1;
            picBoxPkmn6.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxPkmn6.ImageLocation = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + number + ".png";
        }
    }
}
