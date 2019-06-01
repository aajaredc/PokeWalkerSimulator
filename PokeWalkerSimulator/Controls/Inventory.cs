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
        public int lastSelectedInventoryPokemon;
        public ContextMenuStrip inventoryPokemonContextMenu = new ContextMenuStrip();
        ToolStripItem populatePKHeX;
        ToolStripItem discard;


        public Inventory() {
            InitializeComponent();

            populatePKHeX = inventoryPokemonContextMenu.Items.Add("Populate PKHeX");
            discard = inventoryPokemonContextMenu.Items.Add("Remove");
            inventoryPokemonContextMenu.ItemClicked += new ToolStripItemClickedEventHandler(inventoryPokemonContextMenu_ItemClicked);

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
                    Console.WriteLine("Inventory Pokemon" + p + " not found");
                    try {
                        inventoryPokemonPictureBoxes[p].Image = Image.FromFile("../../../PKHeX.WinForms/Resources/img/Pokemon Sprites/_.png");
                    }
                    catch (Exception) {
                        Console.WriteLine("Inventory Pokemon" + p + " not found");
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

        private void picInventoryPokemon_MouseClick(object sender, MouseEventArgs e) {

            lastSelectedInventoryPokemon = GetSelectedInventoryPokemon((PictureBox)sender);

            // Right click, open context menu strip
            if (e.Button == MouseButtons.Right) {
                inventoryPokemonContextMenu.Show(Cursor.Position);
            }
        }

        private void inventoryPokemonContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            // Populate PKHeX with the selected inventory pokemon
            if (e.ClickedItem == populatePKHeX) {
                Console.WriteLine("Loading Inventory Pokemon " + lastSelectedInventoryPokemon);
                try {
                    FormMain.main.PKME_Tabs.PopulateFields(inventoryPokemon[lastSelectedInventoryPokemon]);
                }
                catch (Exception) {
                    Console.WriteLine("Error populating PKHeX: Inventory Pokemon is null");
                    return;
                }
                Console.WriteLine("Inventory Pokemon loaded in PKHeX");
            }

            // Remove the pokemon from the inventory
            if (e.ClickedItem == discard) {
                try {
                    inventoryPokemon.RemoveAt(lastSelectedInventoryPokemon);
                } catch (Exception) {
                    Console.WriteLine("Error discarding from inventory: Pokemon is null");
                    return;
                }

                UpdateImages();
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
