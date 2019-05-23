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

        /// <summary>
        /// Decides which encounter type to be used
        /// </summary>
        /// Type 1 = Refreshing Field
        /// Type 2 = Suburban Area
        /// Type 3 = Scary Cave
        /// Type 4 = Resort
        /// (Check Serebii for more inforamation)
        public int encounterCalculationType = 0;

        public Course() {

            for (int groupIndex = 0; groupIndex < groups.Length; groupIndex++) {
                groups[groupIndex] = new Group();
            }
        }

        public void SetSelectedPokemon() {
            Random random = new Random();
            
            for (int groupIndex = 0; groupIndex < groups.Length; groupIndex++) {
                int pokemonSelection = random.Next(1, 3);
                Console.WriteLine("Selecting Pokemon " + pokemonSelection + " of Group " + groupIndex);
                if (pokemonSelection == 1) {
                    groups[groupIndex].pokemon1.isSelected = true;
                } else {
                    groups[groupIndex].pokemon1.isSelected = false;
                }
            }

        }

        /// <summary>
        /// Sets the encounter rates
        /// </summary>
        // TODO Make this data driven/dynamic?
        // TODO Add other encounter calculation types accordingly
        public void SetEncounterRates() { 
            if (encounterCalculationType == 0) {
                // Pokemon 1 of group a is selected
                if (groups[0].pokemon1.isSelected) {
                    // Pokemon 1 of group b is selected
                    if (groups[1].pokemon1.isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon1.isSelected) {
                            // 1a 1b 1c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 0;
                                groups[2].pokemon1.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 75;
                                groups[2].pokemon1.encounterRate = 25;
                            }
                            else if (stepsTaken >= groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 70;
                                groups[1].pokemon1.encounterRate = 22.5;
                                groups[2].pokemon1.encounterRate = 7.5;
                            }
                            // No Kangaskhan
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon2.isSelected) {
                            // 1a 1b 2c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 0;
                                groups[2].pokemon2.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 75;
                                groups[2].pokemon2.encounterRate = 25;
                            }
                            else if (stepsTaken >= groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 70;
                                groups[1].pokemon1.encounterRate = 22.5;
                                groups[2].pokemon2.encounterRate = 7.5;
                            }
                            // No Kangaskhan
                        }
                    } 
                    // Pokemon 2 of group b is selected
                    else if (groups[1].pokemon2.isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon1.isSelected) {
                            // 1a 2b 1c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon2.encounterRate = 0;
                                groups[2].pokemon1.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon2.encounterRate = 75;
                                groups[2].pokemon1.encounterRate = 25;
                            }
                            else if (stepsTaken >= groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 70;
                                groups[1].pokemon2.encounterRate = 22.5;
                                groups[2].pokemon1.encounterRate = 7.5;
                            }
                            // No Kangaskhan
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon2.isSelected) {
                            // 1a 2b 2c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon2.encounterRate = 0;
                                groups[2].pokemon2.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 0;
                                groups[1].pokemon2.encounterRate = 75;
                                groups[2].pokemon2.encounterRate = 25;
                            }
                            else if (stepsTaken >= groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon1.encounterRate = 70;
                                groups[1].pokemon2.encounterRate = 22.5;
                                groups[2].pokemon2.encounterRate = 7.5;
                            }
                            // No Kangaskhan
                        }
                    }
                }

                // Pokemon 2 of group a is selected
                else if (groups[0].pokemon2.isSelected) {
                    // Pokemon 1 of group b is selected
                    if (groups[1].pokemon1.isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon1.isSelected) {
                            // 2a 1b 1c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 0;
                                groups[2].pokemon1.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 75;
                                groups[2].pokemon1.encounterRate = 25;
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 50;
                                groups[1].pokemon1.encounterRate = 37.5;
                                groups[2].pokemon1.encounterRate = 12.5;
                            }
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon2.isSelected) {
                            // 2a 1b 2c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 0;
                                groups[2].pokemon1.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 75;
                                groups[2].pokemon1.encounterRate = 25;
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 50;
                                groups[1].pokemon1.encounterRate = 37.5;
                                groups[2].pokemon1.encounterRate = 12.5;
                            }
                        }
                    }
                    // Pokemon 2 of group b is selected
                    else if (groups[1].pokemon2.isSelected) {
                        // Pokemon 1 of group c is selected
                        if (groups[2].pokemon1.isSelected) {
                            // 2a 2b 1c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 0;
                                groups[2].pokemon1.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 75;
                                groups[2].pokemon1.encounterRate = 25;
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 50;
                                groups[1].pokemon1.encounterRate = 37.5;
                                groups[2].pokemon1.encounterRate = 12.5;
                            }
                        }
                        // Pokemon 2 of group c is selected
                        else if (groups[2].pokemon2.isSelected) {
                            // 2a 2b 2c
                            if (stepsTaken < groups[1].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 0;
                                groups[2].pokemon1.encounterRate = 100;
                            }
                            else if (stepsTaken >= groups[1].pokemon2.requiredSteps && stepsTaken < groups[0].pokemon1.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 0;
                                groups[1].pokemon1.encounterRate = 75;
                                groups[2].pokemon1.encounterRate = 25;
                            }
                            // No Doduo, but there is a Kangaskhan
                            else if (stepsTaken >= groups[0].pokemon2.requiredSteps) {
                                groups[0].pokemon2.encounterRate = 50;
                                groups[1].pokemon1.encounterRate = 37.5;
                                groups[2].pokemon1.encounterRate = 12.5;
                            }
                        }
                    }
                }
            }
        }
    }
}
