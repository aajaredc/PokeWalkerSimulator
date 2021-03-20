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
            this.steps5000 = new System.Windows.Forms.ToolStripMenuItem();
            this.enterStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPK4InformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInventoryGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.setup = new PokeWalkerSimulator.Controls.Setup();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.inventory = new PokeWalkerSimulator.Controls.Inventory();
            this.tabPokeRadar = new System.Windows.Forms.TabPage();
            this.pokeradar = new PokeWalkerSimulator.Controls.PokeRadar();
            this.tabDowsingMachine = new System.Windows.Forms.TabPage();
            this.dowsingmachine = new PokeWalkerSimulator.Controls.DowsingMachine();
            this.convertPK4ToPokeWalkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabPokeRadar.SuspendLayout();
            this.tabDowsingMachine.SuspendLayout();
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
            this.menuMain.Size = new System.Drawing.Size(478, 28);
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
            this.steps1000,
            this.steps5000,
            this.enterStepsToolStripMenuItem});
            this.stepsToolStripMenuItem.Name = "stepsToolStripMenuItem";
            this.stepsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.stepsToolStripMenuItem.Text = "Steps";
            // 
            // steps100
            // 
            this.steps100.Enabled = false;
            this.steps100.Name = "steps100";
            this.steps100.Size = new System.Drawing.Size(166, 26);
            this.steps100.Text = "100 Steps";
            this.steps100.Click += new System.EventHandler(this.Steps100_Click);
            // 
            // steps500
            // 
            this.steps500.Enabled = false;
            this.steps500.Name = "steps500";
            this.steps500.Size = new System.Drawing.Size(166, 26);
            this.steps500.Text = "500 Steps";
            this.steps500.Click += new System.EventHandler(this.Steps500_Click);
            // 
            // steps1000
            // 
            this.steps1000.Name = "steps1000";
            this.steps1000.Size = new System.Drawing.Size(166, 26);
            this.steps1000.Text = "1000 Steps";
            this.steps1000.Click += new System.EventHandler(this.Steps1000_Click);
            // 
            // steps5000
            // 
            this.steps5000.Name = "steps5000";
            this.steps5000.Size = new System.Drawing.Size(166, 26);
            this.steps5000.Text = "5000 Steps";
            this.steps5000.Click += new System.EventHandler(this.Steps5000_Click);
            // 
            // enterStepsToolStripMenuItem
            // 
            this.enterStepsToolStripMenuItem.Name = "enterStepsToolStripMenuItem";
            this.enterStepsToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.enterStepsToolStripMenuItem.Text = "Enter Steps";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPK4InformationToolStripMenuItem,
            this.viewTrainerInformationToolStripMenuItem,
            this.getItemToolStripMenuItem,
            this.updateInventoryGridToolStripMenuItem,
            this.convertPK4ToPokeWalkerToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // viewPK4InformationToolStripMenuItem
            // 
            this.viewPK4InformationToolStripMenuItem.Name = "viewPK4InformationToolStripMenuItem";
            this.viewPK4InformationToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.viewPK4InformationToolStripMenuItem.Text = "View PK4 Information";
            this.viewPK4InformationToolStripMenuItem.Click += new System.EventHandler(this.ViewPK4InformationToolStripMenuItem_Click);
            // 
            // viewTrainerInformationToolStripMenuItem
            // 
            this.viewTrainerInformationToolStripMenuItem.Name = "viewTrainerInformationToolStripMenuItem";
            this.viewTrainerInformationToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.viewTrainerInformationToolStripMenuItem.Text = "View Trainer Information";
            this.viewTrainerInformationToolStripMenuItem.Click += new System.EventHandler(this.ViewTrainerInformationToolStripMenuItem_Click);
            // 
            // getItemToolStripMenuItem
            // 
            this.getItemToolStripMenuItem.Name = "getItemToolStripMenuItem";
            this.getItemToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.getItemToolStripMenuItem.Text = "Get item?";
            this.getItemToolStripMenuItem.Click += new System.EventHandler(this.GetItemToolStripMenuItem_Click);
            // 
            // updateInventoryGridToolStripMenuItem
            // 
            this.updateInventoryGridToolStripMenuItem.Name = "updateInventoryGridToolStripMenuItem";
            this.updateInventoryGridToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.updateInventoryGridToolStripMenuItem.Text = "Update InventoryGrid";
            this.updateInventoryGridToolStripMenuItem.Click += new System.EventHandler(this.UpdateInventoryGridToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabSetup);
            this.tabControlMain.Controls.Add(this.tabInventory);
            this.tabControlMain.Controls.Add(this.tabPokeRadar);
            this.tabControlMain.Controls.Add(this.tabDowsingMachine);
            this.tabControlMain.Location = new System.Drawing.Point(12, 31);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(452, 407);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.setup);
            this.tabSetup.Location = new System.Drawing.Point(4, 25);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(444, 378);
            this.tabSetup.TabIndex = 3;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // setup
            // 
            this.setup.Location = new System.Drawing.Point(7, 6);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(431, 365);
            this.setup.TabIndex = 0;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.inventory);
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
            this.inventory.Location = new System.Drawing.Point(7, 7);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(431, 365);
            this.inventory.TabIndex = 0;
            // 
            // tabPokeRadar
            // 
            this.tabPokeRadar.Controls.Add(this.pokeradar);
            this.tabPokeRadar.Location = new System.Drawing.Point(4, 25);
            this.tabPokeRadar.Name = "tabPokeRadar";
            this.tabPokeRadar.Size = new System.Drawing.Size(444, 378);
            this.tabPokeRadar.TabIndex = 2;
            this.tabPokeRadar.Text = "PokeRadar";
            this.tabPokeRadar.UseVisualStyleBackColor = true;
            // 
            // pokeradar
            // 
            this.pokeradar.Location = new System.Drawing.Point(4, 4);
            this.pokeradar.Name = "pokeradar";
            this.pokeradar.Size = new System.Drawing.Size(431, 365);
            this.pokeradar.TabIndex = 0;
            // 
            // tabDowsingMachine
            // 
            this.tabDowsingMachine.Controls.Add(this.dowsingmachine);
            this.tabDowsingMachine.Location = new System.Drawing.Point(4, 25);
            this.tabDowsingMachine.Name = "tabDowsingMachine";
            this.tabDowsingMachine.Padding = new System.Windows.Forms.Padding(3);
            this.tabDowsingMachine.Size = new System.Drawing.Size(444, 378);
            this.tabDowsingMachine.TabIndex = 1;
            this.tabDowsingMachine.Text = "Dowsing Machine";
            this.tabDowsingMachine.UseVisualStyleBackColor = true;
            // 
            // dowsingmachine
            // 
            this.dowsingmachine.Location = new System.Drawing.Point(7, 7);
            this.dowsingmachine.Name = "dowsingmachine";
            this.dowsingmachine.Size = new System.Drawing.Size(431, 365);
            this.dowsingmachine.TabIndex = 0;
            // 
            // convertPK4ToPokeWalkerToolStripMenuItem
            // 
            this.convertPK4ToPokeWalkerToolStripMenuItem.Name = "convertPK4ToPokeWalkerToolStripMenuItem";
            this.convertPK4ToPokeWalkerToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.convertPK4ToPokeWalkerToolStripMenuItem.Text = "Convert PK4 to PokeWalker";
            this.convertPK4ToPokeWalkerToolStripMenuItem.Click += new System.EventHandler(this.convertPK4ToPokeWalkerToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.Text = "PokeWalker Simulator";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.tabPokeRadar.ResumeLayout(false);
            this.tabDowsingMachine.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem pokeWalkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setStrollPokemonToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem viewPK4InformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainerInformationToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabDowsingMachine;
        private System.Windows.Forms.TabPage tabPokeRadar;
        public Controls.PokeRadar pokeradar;
        public Controls.Inventory inventory;
        private System.Windows.Forms.ToolStripMenuItem getItemToolStripMenuItem;
        private Controls.DowsingMachine dowsingmachine;
        private System.Windows.Forms.ToolStripMenuItem enterStepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steps5000;
        private System.Windows.Forms.TabPage tabSetup;
        private Controls.Setup setup;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertPK4ToPokeWalkerToolStripMenuItem;
    }
}

