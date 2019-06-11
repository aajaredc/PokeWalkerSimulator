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
        public static PKHeX.WinForms.Main main = new PKHeX.WinForms.Main();
        public static PKM strollPokemon;
        public int steps;
        public int tid = 09268;
        public int sid = 62879;
        public int watts;

        public static Course[] courses = new Course[19];
        public static Course selectedCourse;

        public FormMain() {

            InitializeComponent();

            steps = 0;
            watts = StepsToWatts(steps);

            InitializeCourses();
            pokeradar.inventory = inventory;

            UpdateInventory();
            
        }

        /// <summary>
        /// Initializes the courses
        /// </summary>
        public void InitializeCourses() {

            Console.WriteLine("rrrr: " + CourseInformation.itemProbabilities[0][0, 9]);

            // Create the courses
            for (int i = 0; i < courses.Length; i++) {
                courses[i] = new Course(CourseInformation.coursePokemonSteps[i]) {
                    name = CourseInformation.courseNames[i],
                    description = CourseInformation.courseDescriptions[i],
                    courseNumber = i,
                    encounterCalculationType = CourseInformation.pokemonEncounterCalculationTypes[i],
                    encounterProbabilities = CourseInformation.pokemonEncounterProbabilties[i]
                };
            }

            // Set the PKM for the courses
            string path;
            for (int courseIndex = 0; courseIndex < courses.Length; courseIndex++) {
                for (int groupIndex = 0; groupIndex < courses[courseIndex].groups.Length; groupIndex++) {
                    for (int groupPokemonIndex = 0; groupPokemonIndex < courses[courseIndex].groups[groupIndex].pokemon.Length; groupPokemonIndex++) {
                        path = "../../PK4/" + courseIndex + "/" + groupIndex + groupPokemonIndex + ".pk4";

                        FormMain.main.OpenQuick(path);
                        Console.WriteLine(path);

                        courses[courseIndex].groups[groupIndex].pokemon[groupPokemonIndex].pk = FormMain.main.PKME_Tabs.pkm;
                    }
                }
            }
            for (int i = 0; i < courses.Length; i++) {
                courses[i].SetSelectedPokemon();
                courses[i].UpdateEncounterRates();
                //courses[i].Write();
            }

            // Set default course, for testing purposes
            selectedCourse = courses[18];
            selectedCourse.Write();
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
            pokeradar.PokeRadarEncounter();
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
            Console.WriteLine(strollPokemon.Nature);
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
            selectedCourse.stepsTaken += stepsToAdd;
            steps += selectedCourse.stepsTaken;
            watts = StepsToWatts(selectedCourse.stepsTaken);

            Console.WriteLine("New steps: " + selectedCourse.stepsTaken);
            selectedCourse.UpdateEncounterRates();
            selectedCourse.Write();
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

        private void UpdateInventoryToolStripMenuItem_Click(object sender, EventArgs e) {
            UpdateInventory();
        }

        private void GetItemToolStripMenuItem_Click(object sender, EventArgs e) {
            PKM pk = main.PreparePKM();
            Console.WriteLine(pk.HeldItem);
        }
    }
}
