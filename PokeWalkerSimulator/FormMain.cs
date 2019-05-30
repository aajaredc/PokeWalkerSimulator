using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PKHeX.Core;
using PKHeX.WinForms;
using PKHeX.WinForms.Controls;
using PKHeX.WinForms.Properties;
using static PKHeX.Core.MessageStrings;

namespace PokeWalkerSimulator {
    public partial class FormMain : Form {
        public PKHeX.WinForms.Main main = new PKHeX.WinForms.Main();
        public PKM strollPokemon;
        public PKM wildEncounter;
        public int steps;
        public int watts;
        public Course[] courses = new Course[1];

        public FormMain() {

            

            InitializeComponent();

            steps = 0;
            watts = StepsToWatts(steps);

            InitializeCourses();
            UpdateInventory();
            
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

                    main.OpenQuick(path);
                    Console.WriteLine(path);

                    courses[0].groups[groupIndex].pokemon[groupPokemonIndex].pk = main.PKME_Tabs.pkm;
                }
            }

            courses[0].SetSelectedPokemon();
            courses[0].UpdateEncounterRates();
            courses[0].Write();

        }

        /// <summary>
        /// Converts steps to watts (20 steps = 1 watt)
        /// </summary>
        /// <param name="steps">Number of steps</param>
        /// <returns>Watts (rounded to whole number)</returns>
        public int StepsToWatts(int steps) {
            Console.WriteLine("Converting steps to watts...");
            double watts = steps / 20;
            watts = Math.Round(watts, 0);

            Console.WriteLine("Returning new watts (" + watts + ")");
            return (int) watts;
        }

        public void SetStrollPokemonToolStripMenuItem_Click(object sender, EventArgs e) {
            // Select the Pokemon
            if (WinFormsUtil.OpenSAVPKMDialog(main.C_SAV.SAV.PKMExtensions, out string path)) {
                main.OpenQuick(path);
                Console.WriteLine(path);
            }

            // Set the Pokemon
            strollPokemon = main.PKME_Tabs.pkm;

            // Enable the buttons
            steps100.Enabled = true;
            steps500.Enabled = true;
            steps1000.Enabled = true;
        }

        private void BtnPokeRadar_Click(object sender, EventArgs e) {
            PokeRadarEncounter();
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
            picPokeRadarUser.Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/" + strollPokemon.Species + ".png");
            picWildEncounter.Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/" + wildEncounter.Species + ".png");

            // Enable the buttons
            btnAttack.Enabled = true;
            btnEvade.Enabled = true;
            btnCatch.Enabled = true;
        }

        private void BtnCatch_Click(object sender, EventArgs e) {
            Console.WriteLine("Catch successful");
            inventory.inventoryPokemon.Add(wildEncounter);
        }


        /// <summary>
        /// Updates the inventory accordingly
        /// </summary>
        public void UpdateInventory() {
            Console.WriteLine("Updating inventory...");

            inventory.UpdateImages();
            
        }


        private void BtnExportStrollPokemon_Click(object sender, EventArgs e) {
            if (!main.PKME_Tabs.EditsComplete)
                return;
            PKM pk = main.PreparePKM();
            WinFormsUtil.SavePKMDialog(pk);
        }

        private void SelectSaveFileToolStripMenuItem_Click(object sender, EventArgs e) {
            if (WinFormsUtil.OpenSAVPKMDialog(main.C_SAV.SAV.PKMExtensions, out string path))
                main.OpenQuick(path);
        }

        private void ExportSaveFileToolStripMenuItem_Click(object sender, EventArgs e) {
            main.C_SAV.ExportSaveFile();
        }

        private void RandomizeStrollPKMIVsToolStripMenuItem_Click(object sender, EventArgs e) {
            strollPokemon.SetRandomIVs();
        }

        private void ViewPK4InformationToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void ViewTrainerInformationToolStripMenuItem_Click(object sender, EventArgs e) {
            PKMConverter.Trainer.ApplyToPKM(strollPokemon);
            Console.WriteLine(strollPokemon.TID);
        }


        /// <summary>
        /// Adds steps
        /// </summary>
        /// <param name="stepsToAdd">Steps to add</param>
        private void AddSteps(int stepsToAdd) {
            Console.WriteLine("Adding 1000 steps");
            courses[0].stepsTaken += stepsToAdd;
            steps += courses[0].stepsTaken;
            watts = StepsToWatts(courses[0].stepsTaken);

            Console.WriteLine("New steps: " + courses[0].stepsTaken);
            courses[0].UpdateEncounterRates();
            courses[0].Write();
        }

        private void Steps100_Click(object sender, EventArgs e) {
            AddSteps(100);
        }

        private void Steps500_Click(object sender, EventArgs e) {
            AddSteps(500);
        }

        private void Steps1000_Click(object sender, EventArgs e) {
            AddSteps(1000);
        }

        private void ChangePokeRadarImagesToolStripMenuItem_Click(object sender, EventArgs e) {
            picPokeRadarUser.Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/" + strollPokemon.Species + ".png");
        }

        private void UpdateInventoryToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateInventory();
        }
    }
}
