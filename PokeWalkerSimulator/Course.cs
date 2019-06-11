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

        public int[] itemNumbers;
        public int[] itemRequiredSteps;
        public double[,] itemProbabilities;

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

            else if (encounterCalculationType == 1) {
                if (groups[2].pokemon[0].isSelected) {
                    // (Magnemite A & B) 0 0 0
                    if (groups[0].pokemon[0].isSelected && groups[1].pokemon[0].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[6]; // 0
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[18]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[7]; // 85
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[19]; // 15
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 45
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[8]; // 51
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[20]; // 9
                        }
                    }
                    // (Magnemite / Murkrow) 0 1 0
                    else if (groups[0].pokemon[0].isSelected && groups[1].pokemon[1].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[12]; // 0
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[21]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[13]; // 45
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[22]; // 55
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 40
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[14]; // 27
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[23]; // 33
                        }
                    }
                    // (Elekid / Magnemite) 1 0 0
                    else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[0].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[9]; // 0
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[24]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[10]; // 85
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[25]; // 15
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 15
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[11]; // 72.25
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[26]; // 12.75 
                        }
                    }
                    // (Elekid / Murkrow) 1 1 0
                    else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[1].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[15]; // 0
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[28]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[16]; // 45
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[29]; // 55
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 15
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[17]; // 38.25
                            groups[2].pokemon[0].encounterRate = encounterProbabilities[30]; // 47.75
                        }
                    }
                }
                else if (groups[2].pokemon[1].isSelected) {
                    // (Magnemite A & B) 0 0 1
                    if (groups[0].pokemon[0].isSelected && groups[1].pokemon[0].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[6]; // 0
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[30]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[7]; // 85
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[31]; // 15
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 40
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[8]; // 51
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[32]; // 9
                        }
                    }
                    // (Magnemite / Murkrow) 0 1 1
                    else if (groups[0].pokemon[0].isSelected && groups[1].pokemon[1].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[0]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[12]; // 0
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[33]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[1]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[13]; // 45
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[34]; // 55
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[0].encounterRate = encounterProbabilities[2]; // 40
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[14]; // 27
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[35]; // 33
                        }
                    }
                    // (Elekid / Magnemite) 1 0 1
                    else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[0].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[9]; // 0
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[36]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[10]; // 85
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[37]; // 15
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 15
                            groups[1].pokemon[0].encounterRate = encounterProbabilities[11]; // 72.25
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[38]; // 12.75
                        }
                    }
                    // (Elekid / Murkrow) 1 1 1
                    else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[1].isSelected) {
                        if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[3]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[15]; // 0
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[40]; // 100
                        }
                        else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[4]; // 0
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[16]; // 45
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[41]; // 55
                        }
                        else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                            groups[0].pokemon[1].encounterRate = encounterProbabilities[5]; // 15
                            groups[1].pokemon[1].encounterRate = encounterProbabilities[17]; // 38.25
                            groups[2].pokemon[1].encounterRate = encounterProbabilities[42]; // 47.75
                        }
                    }
                }
            }

            // Encounter type 2 (Scary Cave)
            else if (encounterCalculationType == 2) {
                Console.WriteLine("Encounter type 2");
                // 0 0 0
                if (groups[0].pokemon[0].isSelected && groups[1].pokemon[0].isSelected && groups[2].pokemon[0].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[0]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[6]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[12]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[1]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[7]; // 65
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[13]; // 35
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[2]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[8]; // 35.75
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[14]; // 19.25
                    }
                }
                // 0 0 1
                else if (groups[0].pokemon[0].isSelected && groups[1].pokemon[0].isSelected && groups[2].pokemon[1].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[0]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[6]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[18]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[1]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[7]; // 65
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[19]; // 35
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[2]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[8]; // 35.75
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[20]; // 19.25
                    }
                }
                // 0 1 1
                else if (groups[0].pokemon[0].isSelected && groups[1].pokemon[1].isSelected && groups[2].pokemon[1].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[0]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[9]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[21]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[1]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[10]; // 55
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[22]; // 45
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[2]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[11]; // 30.25
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[23]; // 24.75
                    }
                }
                // 0 1 0
                else if (groups[0].pokemon[0].isSelected && groups[1].pokemon[1].isSelected && groups[2].pokemon[0].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[0]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[9]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[15]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[1]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[10]; // 55
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[16]; // 45
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[2]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[11]; // 30.25
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[17]; // 24.75
                    }
                }
                // -------- //
                // 1 0 0
                else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[0].isSelected && groups[2].pokemon[0].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[3]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[6]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[12]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[4]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[7]; // 65
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[13]; // 35
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[5]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[8]; // 35.75
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[14]; // 19.25
                    }
                }
                // 1 0 1
                else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[0].isSelected && groups[2].pokemon[1].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[3]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[6]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[18]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[4]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[7]; // 65
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[19]; // 35
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[5]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[8]; // 35.75
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[20]; // 19.25
                    }
                }
                // 1 1 1
                else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[1].isSelected && groups[2].pokemon[1].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[3]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[9]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[21]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[4]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[10]; // 55
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[22]; // 45
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[5]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[11]; // 30.25
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[23]; // 24.75
                    }
                }
                // 1 1 0
                else if (groups[0].pokemon[1].isSelected && groups[1].pokemon[1].isSelected && groups[2].pokemon[0].isSelected) {
                    if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[0]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[9]; // 0
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[15]; // 100
                    }
                    else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[1]; // 0
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[10]; // 55
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[16]; // 45
                    }
                    else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                        groups[0].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[2]; // 45
                        groups[1].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[11]; // 30.25
                        groups[2].GetSelectedGroupPokemon().encounterRate = encounterProbabilities[17]; // 24.75
                    }
                }
            }

            // Type 4 (Resort)
            else if (encounterCalculationType == 3) {
                if (stepsTaken < groups[1].GetSelectedGroupPokemon().requiredSteps) {
                    groups[0].pokemon[0].encounterRate = encounterProbabilities[3]; // 100
                    groups[0].pokemon[1].encounterRate = encounterProbabilities[0]; // 100
                    groups[1].pokemon[0].encounterRate = encounterProbabilities[9]; // 0
                    groups[1].pokemon[1].encounterRate = encounterProbabilities[6]; // 0
                    groups[2].pokemon[0].encounterRate = encounterProbabilities[15]; // 0
                    groups[2].pokemon[1].encounterRate = encounterProbabilities[12]; // 0
                }
                else if (stepsTaken >= groups[1].GetSelectedGroupPokemon().requiredSteps && stepsTaken < groups[0].GetSelectedGroupPokemon().requiredSteps) {
                    groups[0].pokemon[0].encounterRate = encounterProbabilities[4]; // 45
                    groups[0].pokemon[1].encounterRate = encounterProbabilities[1]; // 45
                    groups[1].pokemon[0].encounterRate = encounterProbabilities[10]; // 55
                    groups[1].pokemon[1].encounterRate = encounterProbabilities[7]; // 55
                    groups[2].pokemon[0].encounterRate = encounterProbabilities[16]; // 0
                    groups[2].pokemon[1].encounterRate = encounterProbabilities[13]; // 0
                }
                else if (stepsTaken >= groups[0].GetSelectedGroupPokemon().requiredSteps) {
                    groups[0].pokemon[0].encounterRate = encounterProbabilities[5]; // 24.75
                    groups[0].pokemon[1].encounterRate = encounterProbabilities[2]; // 24.75
                    groups[1].pokemon[0].encounterRate = encounterProbabilities[11]; // 30.25
                    groups[1].pokemon[1].encounterRate = encounterProbabilities[8]; // 30.25
                    groups[2].pokemon[0].encounterRate = encounterProbabilities[17]; // 45
                    groups[2].pokemon[1].encounterRate = encounterProbabilities[14]; // 45
                }

                for (int g = 0; g < groups.Length; g++) {
                    for (int p = 0; p < 2; p++) {
                        if (!groups[g].pokemon[p].isSelected) { groups[g].pokemon[p].encounterRate = -1; }
                    }
                }
            }
        }

        private void ApplyEncounterRates() {

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
