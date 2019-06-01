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
using PKHeX.WinForms;

namespace PokeWalkerSimulator.Controls {
    public partial class Inventory : UserControl {

        public List<PKM> inventoryPokemon = new List<PKM>();
        public List<PictureBox> inventoryPokemonPictureBoxes;

        public Inventory() {
            InitializeComponent();

            inventoryPokemonPictureBoxes = new List<PictureBox> {
                picInventoryPokemon0, picInventoryPokemon1, picInventoryPokemon2
            };

            foreach (var pb in inventoryPokemonPictureBoxes) {
                pb.MouseClick += picInventoryPokemon_MouseClick;
                pb.MouseEnter += picInventoryPokemon_MouseEnter;
                pb.MouseLeave += picInventoryPokemon_MouseLeave;
            }
        }

        /// <summary>
        /// Updates the images for the picture boxes
        /// </summary>
        public void UpdateImages() {
            // Pokemon
            for (int p = 0; p < inventoryPokemonPictureBoxes.Count; p++) {
                try {
                    inventoryPokemonPictureBoxes[p].Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/" + inventoryPokemon[p].Species + ".png");
                }
                catch (Exception) {
                    Console.WriteLine("Inventory Pokemon image" + p + " not found");
                    try {
                        inventoryPokemonPictureBoxes[p].Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/_.png");
                    }
                    catch (Exception) {
                        Console.WriteLine("Inventory Pokemon image" + p + " not found");
                    }
                }
            }

            // Items
        }

        /// <summary>
        /// Adds the PKM to the inventory, while applying according properties
        /// </summary>
        /// <param name="pk"></param>
        public void AddPokemonToInventory(PKM pk) {
            pk.TID = FormMain.main.C_SAV.SAV.TID;
            pk.SID = FormMain.main.C_SAV.SAV.SID;
            pk.OT_Name = FormMain.main.C_SAV.SAV.OT;
            pk.OT_Gender = FormMain.main.C_SAV.SAV.Gender;
            pk.MetDate = DateTime.Today;
            pk.SetRandomIVs();

            pk.SetRandomPIDNature();
            PIDGenerator.SetRandomWildPID(pk, 4, pk.Nature, pk.Ability, pk.Gender, PIDType.Pokewalker);

            FormMain.main.PKME_Tabs.PopulateFields(pk);

            inventoryPokemon.Add(pk);
        }

        private int GetSelectedInventoryPokemon(PictureBox sender) => inventoryPokemonPictureBoxes.IndexOf(WinFormsUtil.GetUnderlyingControl(sender) as PictureBox);

        private void picInventoryPokemon_MouseClick(object sender, EventArgs e) {

            // Load the Pokemon in to PKHeX
            Console.WriteLine("Loading Inventory Pokemon " + GetSelectedInventoryPokemon((PictureBox)sender));
            try {
                FormMain.main.PKME_Tabs.PopulateFields(inventoryPokemon[GetSelectedInventoryPokemon((PictureBox)sender)]);
            }
            catch (Exception) {
                Console.WriteLine("Error: Inventory Pokemon is null");
            }
        }

        private void picInventoryPokemon_MouseEnter(object sender, EventArgs e) {
            var pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void picInventoryPokemon_MouseLeave(object sender, EventArgs e) {
            var pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
