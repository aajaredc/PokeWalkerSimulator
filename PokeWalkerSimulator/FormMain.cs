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
            // Course 1 - Refreshing Field
            int[] steps = { 2000, 3000, 500, 500, 0, 0 };
            courses[0] = new Course(steps);
            courses[0].name = "Refreshing Field";
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
                }
            }
        }

        private void GetPK4Info_Click(object sender, EventArgs e) {
            Console.WriteLine("Loaded Pokemon Information: ");
        }

        private void BtnRandomIVs_Click(object sender, EventArgs e) {
            strollPokemon.SetRandomIVs();
        }

        private void BtnExportStrollPokemon_Click(object sender, EventArgs e) {
            if (!main.PKME_Tabs.EditsComplete)
                return;
            PKM pk = main.PreparePKM();
            WinFormsUtil.SavePKMDialog(pk);
        }
    }
}
