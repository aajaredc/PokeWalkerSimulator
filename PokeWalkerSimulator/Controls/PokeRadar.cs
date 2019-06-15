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
using System.Resources;

namespace PokeWalkerSimulator.Controls {
    public partial class PokeRadar : UserControl {

        public PKM wildEncounter;
        public Inventory inventory;
        
        public PokeRadar() {
            InitializeComponent();
        }

        /// <summary>
        /// Encounter a Pokemon with the PokeRadar
        /// </summary>
        public void PokeRadarEncounter() {
            Random random = new Random();
            int pokeRadarSelection = random.Next(0, 100);
            double cumulativeRandom = 0;
            Console.WriteLine("Random: " + pokeRadarSelection);

            for (int i = 0; i < FormMain.selectedCourse.groups.Length; i++) {

                cumulativeRandom += FormMain.selectedCourse.groups[i].GetSelectedGroupPokemon().encounterRate;

                if (FormMain.selectedCourse.groups[i].GetSelectedGroupPokemon().isSelected) {
                    if (pokeRadarSelection < cumulativeRandom) {
                        Console.WriteLine("Encountered pokemon " + FormMain.selectedCourse.groups[i].GetSelectedGroupPokemon().ToString());
                        wildEncounter = FormMain.selectedCourse.groups[i].GetSelectedGroupPokemon().pk;

                        InitializePokeRadarBattle();

                        return;
                    }
                }

            }
        }

        /// <summary>
        /// Initializes the battle for the PokeRadar
        /// </summary>
        public void InitializePokeRadarBattle() {
            // Resource management
            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));

            // Reset the images
            picPokeRadarUser.Image = (Image)rm.GetObject("_" + FormMain.strollPokemon.Species);
            picWildEncounter.Image = (Image)rm.GetObject("_" + wildEncounter.Species);
            picWildEncounter.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            // Enable the buttons
            btnAttack.Enabled = true;
            btnEvade.Enabled = true;
            btnCatch.Enabled = true;
        }

        private void BtnCatch_Click(object sender, EventArgs e) {
            Console.WriteLine("Catch successful");

            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));

            picWildEncounter.Image = (Image)rm.GetObject("item_4"); ;
            inventory.AddPokemonToInventory(wildEncounter);
        }

        private void BtnStartPokeRadar_Click(object sender, EventArgs e) {
            PokeRadarEncounter();
        }
    }
}
