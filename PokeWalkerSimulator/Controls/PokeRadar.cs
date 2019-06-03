using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKHeX.Core;

namespace PokeWalkerSimulator.Controls {
    public partial class PokeRadar : UserControl {

        public PKM wildEncounter;
        public Course[] courses = new Course[1];

        public PokeRadar() {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the courses
        /// </summary>
        public void InitializeCourses() {

            string path;

            // Course 0 - Refreshing Field
            int[] steps = { 2000, 3000, 500, 500, 0, 0 };
            courses[0] = new Course(steps);
            courses[0].name = "Refreshing Field";

            for (int groupIndex = 0; groupIndex < courses[0].groups.Length; groupIndex++) {
                for (int groupPokemonIndex = 0; groupPokemonIndex < courses[0].groups[groupIndex].pokemon.Length; groupPokemonIndex++) {
                    path = "../../PK4/0/" + groupIndex + groupPokemonIndex + ".pk4";

                    FormMain.main.OpenQuick(path);
                    Console.WriteLine(path);

                    courses[0].groups[groupIndex].pokemon[groupPokemonIndex].pk = FormMain.main.PKME_Tabs.pkm;
                }
            }

            courses[0].SetSelectedPokemon();
            courses[0].UpdateEncounterRates();
            courses[0].Write();

        }

        /// <summary>
        /// Encounter a Pokemon with the PokeRadar
        /// </summary>
        public void PokeRadarEncounter() {
            Random random = new Random();
            int pokeRadarSelection = random.Next(0, 100);
            double cumulativeRandom = 0;
            Console.WriteLine("Random: " + pokeRadarSelection);

            for (int i = 0; i < courses[0].groups.Length; i++) {

                cumulativeRandom += courses[0].groups[i].GetSelectedGroupPokemon().encounterRate;

                if (pokeRadarSelection < cumulativeRandom) {
                    Console.WriteLine("Encountered pokemon " + courses[0].groups[i].GetSelectedGroupPokemon().ToString());
                    wildEncounter = courses[0].groups[i].GetSelectedGroupPokemon().pk;

                    InitializePokeRadarBattle();

                    return;
                }
            }
        }

        /// <summary>
        /// Initializes the battle for the PokeRadar
        /// </summary>
        public void InitializePokeRadarBattle() {
            // Reset the images
            picPokeRadarUser.Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/" + FormMain.strollPokemon.Species + ".png");
            picWildEncounter.Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/" + wildEncounter.Species + ".png");

            // Enable the buttons
            btnAttack.Enabled = true;
            btnEvade.Enabled = true;
            btnCatch.Enabled = true;
        }

        private void BtnCatch_Click(object sender, EventArgs e) {
            Console.WriteLine("Catch successful");
            picWildEncounter.Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/item/item_4.png");
            FormMain.inventory.AddPokemonToInventory(wildEncounter);
            FormMain.inventory.UpdateImages();
        }
    }
}
