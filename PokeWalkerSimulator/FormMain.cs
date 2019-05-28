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
        List<PKM> inventoryPokemon = new List<PKM>();
        public int steps;
        public int watts;
        public Course[] courses = new Course[1];

        public FormMain() {

            

            InitializeComponent();

            steps = 0;
            watts = StepsToWatts(steps);

            InitializeCourses();
            
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
            if (WinFormsUtil.OpenSAVPKMDialog(main.C_SAV.SAV.PKMExtensions, out string path)) {
                main.OpenQuick(path);
                Console.WriteLine(path);
            }
            strollPokemon = main.PKME_Tabs.pkm;
        }

        private void BtnAddSteps_Click(object sender, EventArgs e) {
            Console.WriteLine("Adding 1000 steps");
            courses[0].stepsTaken += 1000;
            steps += courses[0].stepsTaken;
            watts = StepsToWatts(courses[0].stepsTaken);

            Console.WriteLine("New steps: " + courses[0].stepsTaken);
            courses[0].UpdateEncounterRates();
            courses[0].Write();
        }

        private void BtnPokeRadar_Click(object sender, EventArgs e) {
            StartPokeRadar();
        }

        /// <summary>
        /// PokeRadar method
        /// </summary>
        public void StartPokeRadar() {
            Random random = new Random();
            int pokeRadarSelection = random.Next(0, 100);
            Console.WriteLine("Random: " + pokeRadarSelection);

            for (int i = 0; i < courses[0].groups.Length; i++) {
                if (pokeRadarSelection < courses[0].groups[i].GetSelectedGroupPokemon().encounterRate) {
                    Console.WriteLine("Encountered pokemon " + courses[0].groups[i].GetSelectedGroupPokemon().ToString());
                    inventoryPokemon.Add(courses[0].groups[i].GetSelectedGroupPokemon());
                }
            }
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
    }
}
