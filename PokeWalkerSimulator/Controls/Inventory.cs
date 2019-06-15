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
using System.Resources;

namespace PokeWalkerSimulator.Controls {
    public partial class Inventory : UserControl {

        public List<PKM> inventoryPokemon = new List<PKM>();
        public List<PictureBox> inventoryPokemonPictureBoxes;
        public List<int> inventoryItems = new List<int>();
        public List<PictureBox> inventoryItemPictureBoxes;
        public int lastSelectedInventoryPokemon;
        public int lastSelectedInventoryItem;
        public ContextMenuStrip inventoryPokemonContextMenu = new ContextMenuStrip();
        public ContextMenuStrip inventoryItemContextMenu = new ContextMenuStrip();
        ToolStripItem populatePKHeX;
        ToolStripItem discardPokemon;
        ToolStripItem discardItem;


        public Inventory() {
            InitializeComponent();

            populatePKHeX = inventoryPokemonContextMenu.Items.Add("Populate PKHeX");
            discardPokemon = inventoryPokemonContextMenu.Items.Add("Remove");
            inventoryPokemonContextMenu.ItemClicked += new ToolStripItemClickedEventHandler(inventoryPokemonContextMenu_ItemClicked);

            inventoryPokemonPictureBoxes = new List<PictureBox> {
                picInventoryPokemon0, picInventoryPokemon1, picInventoryPokemon2
            };

            inventoryItemPictureBoxes = new List<PictureBox> {
                picItem0, picItem1, picItem2
            };

            foreach (var pb in inventoryPokemonPictureBoxes) {
                pb.MouseClick += picInventoryPokemon_MouseClick;
                pb.MouseEnter += inventory_MouseEnter;
                pb.MouseLeave += inventory_MouseLeave;
            }

            foreach (var pb in inventoryItemPictureBoxes) {
                pb.MouseEnter += inventory_MouseEnter;
                pb.MouseLeave += inventory_MouseLeave;
            }
        }

        /// <summary>
        /// Updates the images for the picture boxes
        /// </summary>
        public void UpdateImages() {
            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));
            string resourceName;

            // Pokemon
            for (int p = 0; p < inventoryPokemonPictureBoxes.Count; p++) {
                try {
                    resourceName = "_" + inventoryPokemon[p].Species;
                    inventoryPokemonPictureBoxes[p].Image = (Image)rm.GetObject(resourceName);
                }
                catch (Exception) {
                    Console.WriteLine("Inventory Pokemon" + p + " not found");
                }
            }

            // Items
            for (int p = 0; p < inventoryItemPictureBoxes.Count; p++) {
                try {
                    resourceName = "item_" + inventoryItems[p];
                    inventoryItemPictureBoxes[p].Image = (Image)rm.GetObject(resourceName); ;
                }
                catch (Exception) {
                    Console.WriteLine("Inventory Item" + p + " not found");
                }
            }
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
            UpdateImages();
        }

        /// <summary>
        /// Adds an item to the inventory
        /// </summary>
        /// <param name="item"></param>
        public void AddItemToInventory(int item) {
            inventoryItems.Add(item);
            UpdateImages();
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
            if (e.ClickedItem == discardPokemon) {
                try {
                    inventoryPokemon.RemoveAt(lastSelectedInventoryPokemon);
                } catch (Exception) {
                    Console.WriteLine("Error discarding from inventory: Pokemon is null");
                    return;
                }

                UpdateImages();
            }
        }

        private void inventory_MouseEnter(object sender, EventArgs e) {
            var pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void inventory_MouseLeave(object sender, EventArgs e) {
            var pb = (PictureBox)sender;
            pb.BackColor = System.Drawing.Color.Transparent;
        }

        private void BtnTransferItems_Click(object sender, EventArgs e) => new SAV_Inventory(FormMain.main.C_SAV.SAV, inventoryItems).ShowDialog();
    }
}
