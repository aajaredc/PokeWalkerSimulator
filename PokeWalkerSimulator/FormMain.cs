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
            watts = stepsToWatts(steps);

            InitializeCourses();
        }

        public void SetStrollPokemonToolStripMenuItem_Click(object sender, EventArgs e) {
            if (WinFormsUtil.OpenSAVPKMDialog(main.C_SAV.SAV.PKMExtensions, out string path)) {
                main.OpenQuick(path);
            }
            strollPokemon = main.PKME_Tabs.pkm;
        }

        /// <summary>
        /// Initializes the courses
        /// </summary>
        public void InitializeCourses() {
            // Course 1 - Refreshing Field
            courses[0] = new Course();
            courses[0].name = "Refreshing Field";
            courses[0].SetSelectedPokemon();
            courses[0].SetEncounterRates();

        }

        /// <summary>
        /// Converts steps to watts (20 steps = 1 watt)
        /// </summary>
        /// <param name="steps">Number of steps</param>
        /// <returns>Watts (rounded to whole number)</returns>
        public int stepsToWatts(int steps) {
            Console.WriteLine("Converting steps to watts...");
            double watts = steps / 20;
            watts = Math.Round(watts, 0);

            Console.WriteLine("Returning new watts (" + watts + ")");
            return (int) watts;
        }

        private void BtnAddSteps_Click(object sender, EventArgs e) {
            Console.WriteLine("Adding 100 steps");
            courses[0].stepsTaken += 100;
            steps += courses[0].stepsTaken;
            watts = stepsToWatts(courses[0].stepsTaken);

        }
    }
}
