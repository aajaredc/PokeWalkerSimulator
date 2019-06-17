namespace PokeWalkerSimulator.Controls {
    partial class Inventory {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnTransferItems = new System.Windows.Forms.Button();
            this.InventoryTabs = new System.Windows.Forms.TabControl();
            this.tabPokemon = new System.Windows.Forms.TabPage();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.grdPokemon = new System.Windows.Forms.DataGridView();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.columnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnPopulatePKHeX = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InventoryTabs.SuspendLayout();
            this.tabPokemon.SuspendLayout();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransferItems
            // 
            this.btnTransferItems.Location = new System.Drawing.Point(297, 56);
            this.btnTransferItems.Name = "btnTransferItems";
            this.btnTransferItems.Size = new System.Drawing.Size(113, 43);
            this.btnTransferItems.TabIndex = 12;
            this.btnTransferItems.Text = "Open SAV";
            this.btnTransferItems.UseVisualStyleBackColor = true;
            this.btnTransferItems.Click += new System.EventHandler(this.BtnTransferItems_Click);
            // 
            // InventoryTabs
            // 
            this.InventoryTabs.Controls.Add(this.tabPokemon);
            this.InventoryTabs.Controls.Add(this.tabItems);
            this.InventoryTabs.Location = new System.Drawing.Point(4, 4);
            this.InventoryTabs.Name = "InventoryTabs";
            this.InventoryTabs.SelectedIndex = 0;
            this.InventoryTabs.Size = new System.Drawing.Size(424, 358);
            this.InventoryTabs.TabIndex = 13;
            // 
            // tabPokemon
            // 
            this.tabPokemon.Controls.Add(this.grdPokemon);
            this.tabPokemon.Location = new System.Drawing.Point(4, 25);
            this.tabPokemon.Name = "tabPokemon";
            this.tabPokemon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPokemon.Size = new System.Drawing.Size(416, 329);
            this.tabPokemon.TabIndex = 0;
            this.tabPokemon.Text = "Pokemon";
            this.tabPokemon.UseVisualStyleBackColor = true;
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.btnClearItems);
            this.tabItems.Controls.Add(this.grdItems);
            this.tabItems.Controls.Add(this.btnTransferItems);
            this.tabItems.Location = new System.Drawing.Point(4, 25);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(416, 329);
            this.tabItems.TabIndex = 1;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // grdItems
            // 
            this.grdItems.AllowUserToAddRows = false;
            this.grdItems.AllowUserToDeleteRows = false;
            this.grdItems.AllowUserToResizeColumns = false;
            this.grdItems.AllowUserToResizeRows = false;
            this.grdItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnImage,
            this.columnName,
            this.columnSelect});
            this.grdItems.Location = new System.Drawing.Point(4, 7);
            this.grdItems.Name = "grdItems";
            this.grdItems.RowHeadersVisible = false;
            this.grdItems.RowHeadersWidth = 51;
            this.grdItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdItems.RowTemplate.Height = 24;
            this.grdItems.Size = new System.Drawing.Size(287, 316);
            this.grdItems.TabIndex = 13;
            // 
            // grdPokemon
            // 
            this.grdPokemon.AllowUserToAddRows = false;
            this.grdPokemon.AllowUserToDeleteRows = false;
            this.grdPokemon.AllowUserToResizeColumns = false;
            this.grdPokemon.AllowUserToResizeRows = false;
            this.grdPokemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grdPokemon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPokemon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.Selected,
            this.columnPopulatePKHeX});
            this.grdPokemon.Location = new System.Drawing.Point(6, 7);
            this.grdPokemon.Name = "grdPokemon";
            this.grdPokemon.RowHeadersVisible = false;
            this.grdPokemon.RowHeadersWidth = 51;
            this.grdPokemon.RowTemplate.Height = 24;
            this.grdPokemon.Size = new System.Drawing.Size(287, 316);
            this.grdPokemon.TabIndex = 0;
            this.grdPokemon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPokemon_CellContentClick);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Location = new System.Drawing.Point(297, 7);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(113, 43);
            this.btnClearItems.TabIndex = 14;
            this.btnClearItems.Text = "Clear All";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.BtnClearItems_Click);
            // 
            // columnImage
            // 
            this.columnImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnImage.HeaderText = "Image";
            this.columnImage.MinimumWidth = 6;
            this.columnImage.Name = "columnImage";
            this.columnImage.Width = 52;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.HeaderText = "Name";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            // 
            // columnSelect
            // 
            this.columnSelect.HeaderText = "Selected";
            this.columnSelect.MinimumWidth = 6;
            this.columnSelect.Name = "columnSelect";
            this.columnSelect.Width = 69;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Width = 69;
            // 
            // columnPopulatePKHeX
            // 
            this.columnPopulatePKHeX.HeaderText = "PKHeX";
            this.columnPopulatePKHeX.MinimumWidth = 6;
            this.columnPopulatePKHeX.Name = "columnPopulatePKHeX";
            this.columnPopulatePKHeX.Width = 59;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventoryTabs);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(431, 365);
            this.InventoryTabs.ResumeLayout(false);
            this.tabPokemon.ResumeLayout(false);
            this.tabItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTransferItems;
        private System.Windows.Forms.TabControl InventoryTabs;
        private System.Windows.Forms.TabPage tabPokemon;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.DataGridView grdPokemon;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.DataGridViewImageColumn columnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnSelect;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewButtonColumn columnPopulatePKHeX;
    }
}
