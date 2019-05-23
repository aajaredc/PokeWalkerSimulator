using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWalkerSimulator {
    public class Group {

        public GroupPokemon pokemon1;
        public GroupPokemon pokemon2;
        public int groupNumber; // c = 2, b = 1, a = 0


        public Group() {

            pokemon1 = new GroupPokemon();
            pokemon2 = new GroupPokemon();
   
        }
    }
}
