namespace PokeWalkerSimulator {
    partial class FormMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokeWalkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginStrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endStrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStrollPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steps100 = new System.Windows.Forms.ToolStripMenuItem();
            this.steps500 = new System.Windows.Forms.ToolStripMenuItem();
            this.steps1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeStrollPKMIVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPK4InformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePokeRadarImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPokeRadar = new System.Windows.Forms.Button();
            this.btnExportStrollPokemon = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabInventory = new System.Windows.Forms.TabPage();
            inventory = new PokeWalkerSimulator.Controls.Inventory();
            this.tabPokeRadar = new System.Windows.Forms.TabPage();
            this.tabDowsingMachine = new System.Windows.Forms.TabPage();
            pokeradar = new PokeWalkerSimulator.Controls.PokeRadar();
            this.menuMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabPokeRadar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.pokeWalkerToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(636, 28);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuMain";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSaveFileToolStripMenuItem,
            this.exportSaveFileToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // selectSaveFileToolStripMenuItem
            // 
            this.selectSaveFileToolStripMenuItem.Name = "selectSaveFileToolStripMenuItem";
            this.selectSaveFileToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.selectSaveFileToolStripMenuItem.Text = "Select Save File";
            this.selectSaveFileToolStripMenuItem.Click += new System.EventHandler(this.SelectSaveFileToolStripMenuItem_Click);
            // 
            // exportSaveFileToolStripMenuItem
            // 
            this.exportSaveFileToolStripMenuItem.Enabled = false;
            this.exportSaveFileToolStripMenuItem.Name = "exportSaveFileToolStripMenuItem";
            this.exportSaveFileToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.exportSaveFileToolStripMenuItem.Text = "Export Save File";
            this.exportSaveFileToolStripMenuItem.Click += new System.EventHandler(this.ExportSaveFileToolStripMenuItem_Click);
            // 
            // pokeWalkerToolStripMenuItem
            // 
            this.pokeWalkerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginStrollToolStripMenuItem,
            this.setStrollPokemonToolStripMenuItem,
            this.stepsToolStripMenuItem});
            this.pokeWalkerToolStripMenuItem.Name = "pokeWalkerToolStripMenuItem";
            this.pokeWalkerToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.pokeWalkerToolStripMenuItem.Text = "PokeWalker";
            // 
            // beginStrollToolStripMenuItem
            // 
            this.beginStrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStrollToolStripMenuItem,
            this.endStrollToolStripMenuItem});
            this.beginStrollToolStripMenuItem.Name = "beginStrollToolStripMenuItem";
            this.beginStrollToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.beginStrollToolStripMenuItem.Text = "Stroll";
            // 
            // startStrollToolStripMenuItem
            // 
            this.startStrollToolStripMenuItem.Enabled = false;
            this.startStrollToolStripMenuItem.Name = "startStrollToolStripMenuItem";
            this.startStrollToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.startStrollToolStripMenuItem.Text = "Start Stroll";
            // 
            // endStrollToolStripMenuItem
            // 
            this.endStrollToolStripMenuItem.Enabled = false;
            this.endStrollToolStripMenuItem.Name = "endStrollToolStripMenuItem";
            this.endStrollToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.endStrollToolStripMenuItem.Text = "End Stroll";
            // 
            // setStrollPokemonToolStripMenuItem
            // 
            this.setStrollPokemonToolStripMenuItem.Name = "setStrollPokemonToolStripMenuItem";
            this.setStrollPokemonToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.setStrollPokemonToolStripMenuItem.Text = "Set Stroll Pokemon";
            this.setStrollPokemonToolStripMenuItem.Click += new System.EventHandler(this.SetStrollPokemonToolStripMenuItem_Click);
            // 
            // stepsToolStripMenuItem
            // 
            this.stepsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steps100,
            this.steps500,
            this.steps1000});
            this.stepsToolStripMenuItem.Name = "stepsToolStripMenuItem";
            this.stepsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.stepsToolStripMenuItem.Text = "Steps";
            // 
            // steps100
            // 
            this.steps100.Enabled = false;
            this.steps100.Name = "steps100";
            this.steps100.Size = new System.Drawing.Size(164, 26);
            this.steps100.Text = "100 Steps";
            this.steps100.Click += new System.EventHandler(this.Steps100_Click);
            // 
            // steps500
            // 
            this.steps500.Enabled = false;
            this.steps500.Name = "steps500";
            this.steps500.Size = new System.Drawing.Size(164, 26);
            this.steps500.Text = "500 Steps";
            this.steps500.Click += new System.EventHandler(this.Steps500_Click);
            // 
            // steps1000
            // 
            this.steps1000.Enabled = false;
            this.steps1000.Name = "steps1000";
            this.steps1000.Size = new System.Drawing.Size(164, 26);
            this.steps1000.Text = "1000 Steps";
            this.steps1000.Click += new System.EventHandler(this.Steps1000_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeStrollPKMIVsToolStripMenuItem,
            this.viewPK4InformationToolStripMenuItem,
            this.viewTrainerInformationToolStripMenuItem,
            this.changePokeRadarImagesToolStripMenuItem,
            this.updateInventoryToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // randomizeStrollPKMIVsToolStripMenuItem
            // 
            this.randomizeStrollPKMIVsToolStripMenuItem.Name = "randomizeStrollPKMIVsToolStripMenuItem";
            this.randomizeStrollPKMIVsToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.randomizeStrollPKMIVsToolStripMenuItem.Text = "Randomize Stroll PKM IVs";
            this.randomizeStrollPKMIVsToolStripMenuItem.Click += new System.EventHandler(this.RandomizeStrollPKMIVsToolStripMenuItem_Click);
            // 
            // viewPK4InformationToolStripMenuItem
            // 
            this.viewPK4InformationToolStripMenuItem.Name = "viewPK4InformationToolStripMenuItem";
            this.viewPK4InformationToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.viewPK4InformationToolStripMenuItem.Text = "View PK4 Information";
            this.viewPK4InformationToolStripMenuItem.Click += new System.EventHandler(this.ViewPK4InformationToolStripMenuItem_Click);
            // 
            // viewTrainerInformationToolStripMenuItem
            // 
            this.viewTrainerInformationToolStripMenuItem.Name = "viewTrainerInformationToolStripMenuItem";
            this.viewTrainerInformationToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.viewTrainerInformationToolStripMenuItem.Text = "View Trainer Information";
            this.viewTrainerInformationToolStripMenuItem.Click += new System.EventHandler(this.ViewTrainerInformationToolStripMenuItem_Click);
            // 
            // changePokeRadarImagesToolStripMenuItem
            // 
            this.changePokeRadarImagesToolStripMenuItem.Name = "changePokeRadarImagesToolStripMenuItem";
            this.changePokeRadarImagesToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.changePokeRadarImagesToolStripMenuItem.Text = "Change PokeRadar Images";
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.updateInventoryToolStripMenuItem.Text = "Update Inventory";
            this.updateInventoryToolStripMenuItem.Click += new System.EventHandler(this.UpdateInventoryToolStripMenuItem_Click);
            // 
            // btnPokeRadar
            // 
            this.btnPokeRadar.Location = new System.Drawing.Point(470, 56);
            this.btnPokeRadar.Name = "btnPokeRadar";
            this.btnPokeRadar.Size = new System.Drawing.Size(156, 48);
            this.btnPokeRadar.TabIndex = 2;
            this.btnPokeRadar.Text = "Start PokeRadar";
            this.btnPokeRadar.UseVisualStyleBackColor = true;
            this.btnPokeRadar.Click += new System.EventHandler(this.BtnPokeRadar_Click);
            // 
            // btnExportStrollPokemon
            // 
            this.btnExportStrollPokemon.Location = new System.Drawing.Point(470, 110);
            this.btnExportStrollPokemon.Name = "btnExportStrollPokemon";
            this.btnExportStrollPokemon.Size = new System.Drawing.Size(156, 48);
            this.btnExportStrollPokemon.TabIndex = 5;
            this.btnExportStrollPokemon.Text = "Export Stroll Pokemon";
            this.btnExportStrollPokemon.UseVisualStyleBackColor = true;
            this.btnExportStrollPokemon.Click += new System.EventHandler(this.BtnExportStrollPokemon_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabInventory);
            this.tabControlMain.Controls.Add(this.tabPokeRadar);
            this.tabControlMain.Controls.Add(this.tabDowsingMachine);
            this.tabControlMain.Location = new System.Drawing.Point(12, 31);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(452, 407);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(inventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 25);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(444, 378);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // inventory
            // 
            inventory.Location = new System.Drawing.Point(7, 7);
            inventory.Name = "inventory";
            inventory.Size = new System.Drawing.Size(431, 365);
            inventory.TabIndex = 0;
            // 
            // tabPokeRadar
            // 
            this.tabPokeRadar.Controls.Add(pokeradar);
            this.tabPokeRadar.Location = new System.Drawing.Point(4, 25);
            this.tabPokeRadar.Name = "tabPokeRadar";
            this.tabPokeRadar.Size = new System.Drawing.Size(444, 378);
            this.tabPokeRadar.TabIndex = 2;
            this.tabPokeRadar.Text = "PokeRadar";
            this.tabPokeRadar.UseVisualStyleBackColor = true;
            // 
            // tabDowsingMachine
            // 
            this.tabDowsingMachine.Location = new System.Drawing.Point(4, 25);
            this.tabDowsingMachine.Name = "tabDowsingMachine";
            this.tabDowsingMachine.Padding = new System.Windows.Forms.Padding(3);
            this.tabDowsingMachine.Size = new System.Drawing.Size(444, 378);
            this.tabDowsingMachine.TabIndex = 1;
            this.tabDowsingMachine.Text = "Dowsing Machine";
            this.tabDowsingMachine.UseVisualStyleBackColor = true;
            // 
            // pokeradar
            // 
            pokeradar.Location = new System.Drawing.Point(4, 4);
            pokeradar.Name = "pokeradar";
            pokeradar.Size = new System.Drawing.Size(431, 365);
            pokeradar.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.btnExportStrollPokemon);
            this.Controls.Add(this.btnPokeRadar);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.Text = "PokeWalker Simulator";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.tabPokeRadar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem pokeWalkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setStrollPokemonToolStripMenuItem;
        private System.Windows.Forms.Button btnPokeRadar;
        private System.Windows.Forms.Button btnExportStrollPokemon;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginStrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endStrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steps100;
        private System.Windows.Forms.ToolStripMenuItem steps500;
        private System.Windows.Forms.ToolStripMenuItem steps1000;
        private System.Windows.Forms.ToolStripMenuItem randomizeStrollPKMIVsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPK4InformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainerInformationToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabDowsingMachine;
        private System.Windows.Forms.TabPage tabPokeRadar;
        private System.Windows.Forms.ToolStripMenuItem changePokeRadarImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
        public static Controls.PokeRadar pokeradar;
        public static Controls.Inventory inventory;
    }
}

