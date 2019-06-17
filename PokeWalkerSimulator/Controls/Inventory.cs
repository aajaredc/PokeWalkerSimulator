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
        public List<int> inventoryItems = new List<int>();
        private readonly string[] itemlist;

        public Inventory() {
            InitializeComponent();

            itemlist = GameInfo.Strings.GetItemStrings(FormMain.main.C_SAV.SAV.Generation, FormMain.main.C_SAV.SAV.Version).ToArray();

            for (int i = 0; i < itemlist.Length; i++) {
                if (string.IsNullOrEmpty(itemlist[i]))
                    itemlist[i] = $"(Item #{i:000})";
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

            // Add the pokemon to the dgv
            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));
            string resourceName = "_" + pk.Species;
            Species name = (Species)pk.Species;
            grdPokemon.Rows.Add((Image)rm.GetObject(resourceName), name.ToString());
        }

        /// <summary>
        /// Adds an item to the inventory
        /// </summary>
        /// <param name="item"></param>
        public void AddItemToInventory(int item) {
            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));
            string resourceName = "item_" + item;

            grdItems.Rows.Add((Image)rm.GetObject(resourceName), itemlist[item]);
            inventoryItems.Add(item);
        }

        private void BtnTransferItems_Click(object sender, EventArgs e) => new SAV_Inventory(FormMain.main.C_SAV.SAV, inventoryItems).ShowDialog();

        public void UpdateInventoryGrid() {

        }

        private void BtnClearItems_Click(object sender, EventArgs e) {
            inventoryItems.Clear();
            grdItems.Rows.Clear();
        }

        private void GrdPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                FormMain.main.PKME_Tabs.PopulateFields(inventoryPokemon[e.RowIndex]);
            }
        }
    }
}
