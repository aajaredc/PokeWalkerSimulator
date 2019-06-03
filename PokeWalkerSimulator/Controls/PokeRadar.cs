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
        public Course[] courses = new Course[3];
        public Course selectedCourse;
        public Inventory inventory;
        
        public PokeRadar() {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the courses
        /// </summary>
        public void InitializeCourses() {

            // Course names
            string[] courseNames = {
                "Refreshing Field", // refreshing field
                "Noisy Forest", // noisy forest
                "Rugged Road" // rugged road
            };

            // Course descriptions
            string[] courseDescriptions = {
                "A wonderfully refreshing field for a Stroll. You can meet many kinds of Pokémon here.", // refreshing field
                "A large natural forest that has been allowed to grow. Many Pokémon live deep in the forest.", // noisy forest
                "A hilly, rugged mountain road. The view from atop the mountain is very beautiful." // rugged road
            };

            // Required steps
            int[][] courseSteps = {
                new int[] { 2000, 3000, 500, 500, 0, 0 }, // refreshing field
                new int[] { 3000, 4000, 700, 700, 0, 0 }, // noisy forest
                new int[] { 4000, 5000, 1000, 1000, 0, 0 } // rugged road
            };

            // Course names
            int[] encounterCalculationTypes = {
                0, // refreshing field
                0, // noisy forest
                0 // rugged road
            };

            // Encounter probabilities
            double[][] encounterProbabilities = {
                // refreshing field
                new double[] {
                    0, 0, 70, //00
                    0, 0, 50, //01
                    0, 75, 22.5, 0, 75, 37.5, //10
                    0, 75, 22.5, 0, 75, 37.5, //11
                    100, 25, 7.5, 100, 25, 12.5, //20
                    100, 25, 7.5, 100, 25, 12.5  //21
                },
                // noisy forest
                new double[] {
                    0, 0, 70, //00
                    0, 0, 30, //01
                    0, 89, 26.7, 0, 89, 62.3, //10
                    0, 89, 26.7, 0, 89, 62.3, //11
                    100, 11, 3.3, 100, 11, 7.7, //20
                    100, 11, 3.3, 100, 11, 7.7  //21
                },
                // rugged road
                new double[] {
                    0, 0, 80, //00
                    0, 0, 50, //01
                    0, 92, 18.4, 0, 92, 46, //10
                    0, 92, 18.4, 0, 92, 46, //11
                    100, 8, 1.6, 100, 8, 4, //20
                    100, 8, 1.6, 100, 8, 4  //21
                }
            };

            // Create the courses
            for (int i = 0; i < courses.Length; i++) {
                courses[i] = new Course(courseSteps[i]) {
                    name = courseNames[i],
                    description = courseDescriptions[i],
                    courseNumber = i,
                    encounterCalculationType = encounterCalculationTypes[i],
                    encounterProbabilities = encounterProbabilities[i]
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
            selectedCourse = courses[2];
            selectedCourse.Write();
        }

        /// <summary>
        /// Encounter a Pokemon with the PokeRadar
        /// </summary>
        public void PokeRadarEncounter() {
            Random random = new Random();
            int pokeRadarSelection = random.Next(0, 100);
            double cumulativeRandom = 0;
            Console.WriteLine("Random: " + pokeRadarSelection);

            for (int i = 0; i < selectedCourse.groups.Length; i++) {

                cumulativeRandom += selectedCourse.groups[i].GetSelectedGroupPokemon().encounterRate;

                if (pokeRadarSelection < cumulativeRandom) {
                    Console.WriteLine("Encountered pokemon " + selectedCourse.groups[i].GetSelectedGroupPokemon().ToString());
                    wildEncounter = selectedCourse.groups[i].GetSelectedGroupPokemon().pk;

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
            inventory.AddPokemonToInventory(wildEncounter);
            inventory.UpdateImages();
        }
    }
}
