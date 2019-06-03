using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWalkerSimulator {
    public class Course {

        public Group[] groups = new Group[3];
        public string name = "Refreshing Field";
        public string description = "A wonderfully refreshing field for a Stroll. " +
            "You can meet many kinds of Pokémon here. ";
        public int stepsTaken;
        public int courseNumber;
        public double[] encounterProbabilities;

        /// <summary>
        /// Decides which encounter type to be used
        /// </summary>
        /// Type 0 = Refreshing Field
        /// Type 1 = Suburban Area
        /// Type 2 = Scary Cave
        /// Type 3 = Resort
        /// (Check Serebii for more inforamation)
        public int encounterCalculationType;

        public Course(int[] pokemonRequiredSteps) {

            for (int groupIndex = 0; groupIndex < groups.Length; groupIndex++) {
                groups[groupIndex] = new Group(groupIndex, pokemonRequiredSteps);
            }
        }

        public void SetSelectedPokemon() {
            Random random = new Random();
            
            for (int g = 0; g < groups.Length; g++) {
                int pokemonSelection = random.Next(0, 2);
                if (pokemonSelection == 1) {
                    groups[g].pokemon[0].isSelected = true;
                } else {
                    groups[g].pokemon[1].isSelected = true;
                }
                Console.WriteLine("Selected " + groups[g].GetSelectedGroupPokemon().ToString());
            }

        }

        /// <summary>
        /// Sets the encounter rates
        /// </summary>
        // TODO Make this data driven/dynamic?
        // TODO Add other encounter calculation types accordingly
        public void UpdateEncounterRates() {

            // Set the encounter rates of selected pokemon, depending on encounter type
            if (encounterCalculationType == 0) {
                // Pokemon 1 of group a is selected
                if (groups[0].pokemon[0].isSelected) {
                    // Pokemon 1 of group b is selected
                    if (groups[1].pokemon[0].isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon[0].isSelected) {
                            // 1a 1b 1c
                            Console.WriteLine("1a 1b 1c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[6]; // 0
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[18]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[7]; // 75
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[19]; // 25
                            }
                            else if (stepsTaken >= groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 70
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[8]; // 22.5
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[20]; // 7.5
                            }
                            // No Kangaskhan
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon[1].isSelected) {
                            // 1a 1b 2c
                            Console.WriteLine("1a 1b 2c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[6]; // 0
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[24]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[7]; // 75
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[25]; // 25
                            }
                            else if (stepsTaken >= groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 70
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[8]; // 22.5
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[26]; // 7.5
                            }
                            // No Kangaskhan
                        }
                    }
                    // Pokemon 2 of group b is selected
                    else if (groups[1].pokemon[1].isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon[0].isSelected) {
                            // 1a 2b 1c
                            Console.WriteLine("1a 2b 1c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[12]; // 0
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[18]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[13]; // 75
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[19]; // 25
                            }
                            else if (stepsTaken >= groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 70
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[14]; // 22.5
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[20]; // 7.5
                            }
                            // No Kangaskhan
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon[1].isSelected) {
                            // 1a 2b 2c
                            Console.WriteLine("1a 2b 2c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[12]; // 0
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[24]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[13]; // 75
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[25]; // 25
                            }
                            else if (stepsTaken >= groups[0].pokemon[0].requiredSteps) {
                                groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 75
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[14]; // 22.5
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[26]; // 7.5
                            }
                            // No Kangaskhan
                        }
                    }
                }

                // ------------------------------------------------------------

                // Pokemon 2 of group a is selected
                else if (groups[0].pokemon[1].isSelected) {
                    // Pokemon 1 of group b is selected
                    if (groups[1].pokemon[0].isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon[0].isSelected) {
                            // 2a 1b 1c
                            Console.WriteLine("2a 1b 1c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[9]; // 0
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[21]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[10]; // 75
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[22]; // 25
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 50
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[11]; // 37.5
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[23]; // 12.5
                            }
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon[1].isSelected) {
                            // 2a 1b 2c
                            Console.WriteLine("2a 1b 2c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[9]; // 0
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[27]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[10]; // 75
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[28]; // 25
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 50
                                groups[1].pokemon[0].encounterRate = encounterProbabilities[11]; // 37.5
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[29]; // 12.5
                            }
                        }
                    }
                    // Pokemon 2 of group b is selected
                    else if (groups[1].pokemon[1].isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon[0].isSelected) {
                            // 2a 2b 1c
                            Console.WriteLine("2a 2b 1c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[15]; // 0
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[21]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[16]; // 75
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[22]; // 25
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 50
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[17]; // 37.5
                                groups[2].pokemon[0].encounterRate = encounterProbabilities[23]; // 12.5
                            }
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon[1].isSelected) {
                            // 2a 2b 2c
                            Console.WriteLine("2a 2b 2c");
                            if (stepsTaken < groups[1].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[15]; // 0
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[27]; // 100
                            }
                            else if (stepsTaken >= groups[1].pokemon[1].requiredSteps && stepsTaken < groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[16]; // 75
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[28]; // 25
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon[1].requiredSteps) {
                                groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 50
                                groups[1].pokemon[1].encounterRate = encounterProbabilities[17]; // 37.5
                                groups[2].pokemon[1].encounterRate = encounterProbabilities[29]; // 12.5
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Writes information of the course to the console
        /// </summary>
        public void Write() {
            Console.WriteLine("");
            groups[0].Write();
            Console.WriteLine("----------");
            groups[1].Write();
            Console.WriteLine("----------");
            groups[2].Write();
        }
    }
}
