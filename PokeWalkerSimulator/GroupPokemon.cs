using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;

namespace PokeWalkerSimulator {
    public class GroupPokemon : PK4 {

        public int requiredSteps = 0;
        public double encounterRate = 0;
        public bool isSelected = false;
        public int group = 4;
        public int pokemonNumber = 3;

        public GroupPokemon() {
            
        }

        public override string ToString() {
            return ("Group: " + group + " | Pokemon: " + pokemonNumber
                + " | Encounter Rate: " + encounterRate + " | Required Steps: " + requiredSteps
                + " | Selected: " + isSelected);
        }

    }
}
