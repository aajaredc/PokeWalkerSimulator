using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWalkerSimulator {
    public class Group {

        public GroupPokemon[] pokemon = new GroupPokemon[2];
        public int groupNumber = 0; // c = 2, b = 1, a = 0
        public bool pokemonFound = false;


        public Group(int groupNumber, int[] pokemonRequiredSteps) {

            this.groupNumber = groupNumber;

            pokemon[0] = new GroupPokemon() {
                pokemonNumber = 0,
                group = this.groupNumber
            };
            switch (this.groupNumber) {
                case 0:
                    pokemon[0].requiredSteps = pokemonRequiredSteps[0];
                    break;
                case 1:
                    pokemon[0].requiredSteps = pokemonRequiredSteps[2];
                    break;
                case 2:
                    pokemon[0].requiredSteps = pokemonRequiredSteps[4];
                    break;
            }

            pokemon[1] = new GroupPokemon() {
                pokemonNumber = 1,
                group = this.groupNumber
            };
            switch (this.groupNumber) {
                case 0:
                    pokemon[1].requiredSteps = pokemonRequiredSteps[1];
                    break;
                case 1:
                    pokemon[1].requiredSteps = pokemonRequiredSteps[3];
                    break;
                case 2:
                    pokemon[1].requiredSteps = pokemonRequiredSteps[5];
                    break;
            }


        }

        public GroupPokemon GetSelectedGroupPokemon() {
            if (pokemon[0].isSelected) { return pokemon[0]; }
            else if (pokemon[1].isSelected) { return pokemon[1]; }
            else {
                Console.WriteLine("GetSelectedGroupPokemon: No pokemon selected");
                return pokemon[0];
            }

        }

        /// <summary>
        /// Writes information of the group to the console
        /// </summary>
        public void Write() {
            Console.WriteLine("Group " + groupNumber);
            Console.WriteLine(pokemon[0].ToString());
            Console.WriteLine(pokemon[1].ToString());
        }
    }
}
