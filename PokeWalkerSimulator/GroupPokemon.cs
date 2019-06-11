using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;

namespace PokeWalkerSimulator {
    public class GroupPokemon {

        // PokeWalker related
        public int requiredSteps = -1;
        public double encounterRate = -1;
        public bool isSelected = false;
        public int group = -1;
        public int groupPokemonIndex = -1;

        // Pokemon related
        public PKM pk;

        public GroupPokemon() {
            
        }

        public override string ToString() {
            return ("Group: " + group + " | Pokemon: " + groupPokemonIndex
                + " | Encounter Rate: " + encounterRate + " | Required Steps: " + requiredSteps
                + " | Selected: " + isSelected);
        }

    }
}
