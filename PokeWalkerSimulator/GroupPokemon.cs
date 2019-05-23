using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;

namespace PokeWalkerSimulator {
    public class GroupPokemon : PK4 {

        public int requiredSteps;
        public double encounterRate;
        public bool isSelected;
        

        public GroupPokemon() {
            encounterRate = 0;
            requiredSteps = 0;
            isSelected = false;
        }

    }
}
