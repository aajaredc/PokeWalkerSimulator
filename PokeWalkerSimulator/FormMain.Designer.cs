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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            this.btnPokeRadar = new System.Windows.Forms.Button();
            this.btnExportStrollPokemon = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPokeRadar = new System.Windows.Forms.TabPage();
            this.lblPokeRadarFeedback = new System.Windows.Forms.Label();
            this.btnCatch = new System.Windows.Forms.Button();
            this.btnEvade = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.picPokeRadarUser = new System.Windows.Forms.PictureBox();
            this.picWildEncounter = new System.Windows.Forms.PictureBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabDowsingMachine = new System.Windows.Forms.TabPage();
            this.picInventoryPokemon0 = new System.Windows.Forms.PictureBox();
            this.picInventoryPokemon1 = new System.Windows.Forms.PictureBox();
            this.picInventoryPokemon2 = new System.Windows.Forms.PictureBox();
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPokeRadar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPokeRadarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWildEncounter)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon2)).BeginInit();
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // selectSaveFileToolStripMenuItem
            // 
            this.selectSaveFileToolStripMenuItem.Name = "selectSaveFileToolStripMenuItem";
            this.selectSaveFileToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.selectSaveFileToolStripMenuItem.Text = "Select Save File";
            this.selectSaveFileToolStripMenuItem.Click += new System.EventHandler(this.SelectSaveFileToolStripMenuItem_Click);
            // 
            // exportSaveFileToolStripMenuItem
            // 
            this.exportSaveFileToolStripMenuItem.Enabled = false;
            this.exportSaveFileToolStripMenuItem.Name = "exportSaveFileToolStripMenuItem";
            this.exportSaveFileToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
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
            this.pokeWalkerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.pokeWalkerToolStripMenuItem.Text = "PokeWalker";
            // 
            // beginStrollToolStripMenuItem
            // 
            this.beginStrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStrollToolStripMenuItem,
            this.endStrollToolStripMenuItem});
            this.beginStrollToolStripMenuItem.Name = "beginStrollToolStripMenuItem";
            this.beginStrollToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.beginStrollToolStripMenuItem.Text = "Stroll";
            // 
            // startStrollToolStripMenuItem
            // 
            this.startStrollToolStripMenuItem.Enabled = false;
            this.startStrollToolStripMenuItem.Name = "startStrollToolStripMenuItem";
            this.startStrollToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.startStrollToolStripMenuItem.Text = "Start Stroll";
            // 
            // endStrollToolStripMenuItem
            // 
            this.endStrollToolStripMenuItem.Enabled = false;
            this.endStrollToolStripMenuItem.Name = "endStrollToolStripMenuItem";
            this.endStrollToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.endStrollToolStripMenuItem.Text = "End Stroll";
            // 
            // setStrollPokemonToolStripMenuItem
            // 
            this.setStrollPokemonToolStripMenuItem.Name = "setStrollPokemonToolStripMenuItem";
            this.setStrollPokemonToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
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
            this.stepsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.stepsToolStripMenuItem.Text = "Steps";
            // 
            // steps100
            // 
            this.steps100.Enabled = false;
            this.steps100.Name = "steps100";
            this.steps100.Size = new System.Drawing.Size(156, 26);
            this.steps100.Text = "100 Steps";
            this.steps100.Click += new System.EventHandler(this.Steps100_Click);
            // 
            // steps500
            // 
            this.steps500.Enabled = false;
            this.steps500.Name = "steps500";
            this.steps500.Size = new System.Drawing.Size(156, 26);
            this.steps500.Text = "500 Steps";
            this.steps500.Click += new System.EventHandler(this.Steps500_Click);
            // 
            // steps1000
            // 
            this.steps1000.Enabled = false;
            this.steps1000.Name = "steps1000";
            this.steps1000.Size = new System.Drawing.Size(156, 26);
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
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // randomizeStrollPKMIVsToolStripMenuItem
            // 
            this.randomizeStrollPKMIVsToolStripMenuItem.Name = "randomizeStrollPKMIVsToolStripMenuItem";
            this.randomizeStrollPKMIVsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.randomizeStrollPKMIVsToolStripMenuItem.Text = "Randomize Stroll PKM IVs";
            this.randomizeStrollPKMIVsToolStripMenuItem.Click += new System.EventHandler(this.RandomizeStrollPKMIVsToolStripMenuItem_Click);
            // 
            // viewPK4InformationToolStripMenuItem
            // 
            this.viewPK4InformationToolStripMenuItem.Name = "viewPK4InformationToolStripMenuItem";
            this.viewPK4InformationToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.viewPK4InformationToolStripMenuItem.Text = "View PK4 Information";
            this.viewPK4InformationToolStripMenuItem.Click += new System.EventHandler(this.ViewPK4InformationToolStripMenuItem_Click);
            // 
            // viewTrainerInformationToolStripMenuItem
            // 
            this.viewTrainerInformationToolStripMenuItem.Name = "viewTrainerInformationToolStripMenuItem";
            this.viewTrainerInformationToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.viewTrainerInformationToolStripMenuItem.Text = "View Trainer Information";
            this.viewTrainerInformationToolStripMenuItem.Click += new System.EventHandler(this.ViewTrainerInformationToolStripMenuItem_Click);
            // 
            // changePokeRadarImagesToolStripMenuItem
            // 
            this.changePokeRadarImagesToolStripMenuItem.Name = "changePokeRadarImagesToolStripMenuItem";
            this.changePokeRadarImagesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.changePokeRadarImagesToolStripMenuItem.Text = "Change PokeRadar Images";
            this.changePokeRadarImagesToolStripMenuItem.Click += new System.EventHandler(this.ChangePokeRadarImagesToolStripMenuItem_Click);
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
            // tabPokeRadar
            // 
            this.tabPokeRadar.Controls.Add(this.lblPokeRadarFeedback);
            this.tabPokeRadar.Controls.Add(this.btnCatch);
            this.tabPokeRadar.Controls.Add(this.btnEvade);
            this.tabPokeRadar.Controls.Add(this.btnAttack);
            this.tabPokeRadar.Controls.Add(this.picPokeRadarUser);
            this.tabPokeRadar.Controls.Add(this.picWildEncounter);
            this.tabPokeRadar.Location = new System.Drawing.Point(4, 25);
            this.tabPokeRadar.Name = "tabPokeRadar";
            this.tabPokeRadar.Size = new System.Drawing.Size(444, 378);
            this.tabPokeRadar.TabIndex = 2;
            this.tabPokeRadar.Text = "PokeRadar";
            this.tabPokeRadar.UseVisualStyleBackColor = true;
            // 
            // lblPokeRadarFeedback
            // 
            this.lblPokeRadarFeedback.AutoSize = true;
            this.lblPokeRadarFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokeRadarFeedback.Location = new System.Drawing.Point(33, 281);
            this.lblPokeRadarFeedback.Name = "lblPokeRadarFeedback";
            this.lblPokeRadarFeedback.Size = new System.Drawing.Size(26, 31);
            this.lblPokeRadarFeedback.TabIndex = 5;
            this.lblPokeRadarFeedback.Text = "ll";
            // 
            // btnCatch
            // 
            this.btnCatch.Enabled = false;
            this.btnCatch.Location = new System.Drawing.Point(285, 221);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(113, 43);
            this.btnCatch.TabIndex = 4;
            this.btnCatch.Text = "Catch";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.BtnCatch_Click);
            // 
            // btnEvade
            // 
            this.btnEvade.Enabled = false;
            this.btnEvade.Location = new System.Drawing.Point(166, 221);
            this.btnEvade.Name = "btnEvade";
            this.btnEvade.Size = new System.Drawing.Size(113, 43);
            this.btnEvade.TabIndex = 3;
            this.btnEvade.Text = "Evade";
            this.btnEvade.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Enabled = false;
            this.btnAttack.Location = new System.Drawing.Point(47, 221);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(113, 43);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // picPokeRadarUser
            // 
            this.picPokeRadarUser.Image = ((System.Drawing.Image)(resources.GetObject("picPokeRadarUser.Image")));
            this.picPokeRadarUser.Location = new System.Drawing.Point(329, 103);
            this.picPokeRadarUser.Name = "picPokeRadarUser";
            this.picPokeRadarUser.Size = new System.Drawing.Size(80, 60);
            this.picPokeRadarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPokeRadarUser.TabIndex = 1;
            this.picPokeRadarUser.TabStop = false;
            // 
            // picWildEncounter
            // 
            this.picWildEncounter.Image = ((System.Drawing.Image)(resources.GetObject("picWildEncounter.Image")));
            this.picWildEncounter.Location = new System.Drawing.Point(33, 33);
            this.picWildEncounter.Name = "picWildEncounter";
            this.picWildEncounter.Size = new System.Drawing.Size(80, 60);
            this.picWildEncounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWildEncounter.TabIndex = 0;
            this.picWildEncounter.TabStop = false;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.picInventoryPokemon2);
            this.tabInventory.Controls.Add(this.picInventoryPokemon1);
            this.tabInventory.Controls.Add(this.picInventoryPokemon0);
            this.tabInventory.Location = new System.Drawing.Point(4, 25);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(444, 378);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
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
            // picInventoryPokemon0
            // 
            this.picInventoryPokemon0.Location = new System.Drawing.Point(7, 7);
            this.picInventoryPokemon0.Name = "picInventoryPokemon0";
            this.picInventoryPokemon0.Size = new System.Drawing.Size(80, 60);
            this.picInventoryPokemon0.TabIndex = 0;
            this.picInventoryPokemon0.TabStop = false;
            // 
            // picInventoryPokemon1
            // 
            this.picInventoryPokemon1.Location = new System.Drawing.Point(93, 7);
            this.picInventoryPokemon1.Name = "picInventoryPokemon1";
            this.picInventoryPokemon1.Size = new System.Drawing.Size(80, 60);
            this.picInventoryPokemon1.TabIndex = 1;
            this.picInventoryPokemon1.TabStop = false;
            // 
            // picInventoryPokemon2
            // 
            this.picInventoryPokemon2.Location = new System.Drawing.Point(179, 7);
            this.picInventoryPokemon2.Name = "picInventoryPokemon2";
            this.picInventoryPokemon2.Size = new System.Drawing.Size(80, 60);
            this.picInventoryPokemon2.TabIndex = 2;
            this.picInventoryPokemon2.TabStop = false;
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.updateInventoryToolStripMenuItem.Text = "Update Inventory";
            this.updateInventoryToolStripMenuItem.Click += new System.EventHandler(this.UpdateInventoryToolStripMenuItem_Click);
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
            this.tabPokeRadar.ResumeLayout(false);
            this.tabPokeRadar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPokeRadarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWildEncounter)).EndInit();
            this.tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon2)).EndInit();
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
        private System.Windows.Forms.PictureBox picWildEncounter;
        private System.Windows.Forms.PictureBox picPokeRadarUser;
        private System.Windows.Forms.ToolStripMenuItem changePokeRadarImagesToolStripMenuItem;
        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Button btnEvade;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblPokeRadarFeedback;
        private System.Windows.Forms.PictureBox picInventoryPokemon2;
        private System.Windows.Forms.PictureBox picInventoryPokemon1;
        private System.Windows.Forms.PictureBox picInventoryPokemon0;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
    }
}

