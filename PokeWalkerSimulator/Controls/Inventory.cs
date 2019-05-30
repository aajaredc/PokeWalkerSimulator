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
    public partial class Inventory : UserControl {

        List<PKM> inventoryPokemon = new List<PKM>();
        List<PictureBox> inventoryPokemonPictureBoxes;

        public Inventory() {
            InitializeComponent();

            inventoryPokemonPictureBoxes = new List<PictureBox> {
                picInventoryPokemon0, picInventoryPokemon1, picInventoryPokemon2
            };
        }

        public void UpdateImages() {
            for (int p = 0; p < inventoryPokemonPictureBoxes.Count; p++) {
                try {
                    inventoryPokemonPictureBoxes[p].Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/" + inventoryPokemon[0].Species + ".png");
                }
                catch (Exception) {
                    Console.WriteLine("Inventory Pokemon " + p + " not found");
                }
            }
        }
    }
}
