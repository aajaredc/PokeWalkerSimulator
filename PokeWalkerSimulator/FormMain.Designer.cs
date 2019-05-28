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
            this.endStrollToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setStrollPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeStrollPKMIVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSteps = new System.Windows.Forms.Button();
            this.btnPokeRadar = new System.Windows.Forms.Button();
            this.btnExportStrollPokemon = new System.Windows.Forms.Button();
            this.viewPK4InformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrainerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
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
            this.menuMain.Size = new System.Drawing.Size(800, 28);
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
            this.endStrollToolStripMenuItem1});
            this.beginStrollToolStripMenuItem.Name = "beginStrollToolStripMenuItem";
            this.beginStrollToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.beginStrollToolStripMenuItem.Text = "Stroll";
            // 
            // startStrollToolStripMenuItem
            // 
            this.startStrollToolStripMenuItem.Name = "startStrollToolStripMenuItem";
            this.startStrollToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.startStrollToolStripMenuItem.Text = "Start Stroll";
            // 
            // endStrollToolStripMenuItem1
            // 
            this.endStrollToolStripMenuItem1.Name = "endStrollToolStripMenuItem1";
            this.endStrollToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.endStrollToolStripMenuItem1.Text = "End Stroll";
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
            this.stepsToolStripMenuItem1,
            this.stepsToolStripMenuItem2,
            this.stepsToolStripMenuItem3});
            this.stepsToolStripMenuItem.Name = "stepsToolStripMenuItem";
            this.stepsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.stepsToolStripMenuItem.Text = "Steps";
            // 
            // stepsToolStripMenuItem1
            // 
            this.stepsToolStripMenuItem1.Name = "stepsToolStripMenuItem1";
            this.stepsToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.stepsToolStripMenuItem1.Text = "100 Steps";
            // 
            // stepsToolStripMenuItem2
            // 
            this.stepsToolStripMenuItem2.Name = "stepsToolStripMenuItem2";
            this.stepsToolStripMenuItem2.Size = new System.Drawing.Size(156, 26);
            this.stepsToolStripMenuItem2.Text = "500 Steps";
            // 
            // stepsToolStripMenuItem3
            // 
            this.stepsToolStripMenuItem3.Name = "stepsToolStripMenuItem3";
            this.stepsToolStripMenuItem3.Size = new System.Drawing.Size(156, 26);
            this.stepsToolStripMenuItem3.Text = "1000 Steps";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeStrollPKMIVsToolStripMenuItem,
            this.viewPK4InformationToolStripMenuItem,
            this.viewTrainerInformationToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // randomizeStrollPKMIVsToolStripMenuItem
            // 
            this.randomizeStrollPKMIVsToolStripMenuItem.Name = "randomizeStrollPKMIVsToolStripMenuItem";
            this.randomizeStrollPKMIVsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.randomizeStrollPKMIVsToolStripMenuItem.Text = "Randomize Stroll PKM IVs";
            this.randomizeStrollPKMIVsToolStripMenuItem.Click += new System.EventHandler(this.RandomizeStrollPKMIVsToolStripMenuItem_Click);
            // 
            // btnAddSteps
            // 
            this.btnAddSteps.Location = new System.Drawing.Point(12, 85);
            this.btnAddSteps.Name = "btnAddSteps";
            this.btnAddSteps.Size = new System.Drawing.Size(156, 48);
            this.btnAddSteps.TabIndex = 1;
            this.btnAddSteps.Text = "Add Steps";
            this.btnAddSteps.UseVisualStyleBackColor = true;
            this.btnAddSteps.Click += new System.EventHandler(this.BtnAddSteps_Click);
            // 
            // btnPokeRadar
            // 
            this.btnPokeRadar.Location = new System.Drawing.Point(12, 31);
            this.btnPokeRadar.Name = "btnPokeRadar";
            this.btnPokeRadar.Size = new System.Drawing.Size(156, 48);
            this.btnPokeRadar.TabIndex = 2;
            this.btnPokeRadar.Text = "Poke Radar";
            this.btnPokeRadar.UseVisualStyleBackColor = true;
            this.btnPokeRadar.Click += new System.EventHandler(this.BtnPokeRadar_Click);
            // 
            // btnExportStrollPokemon
            // 
            this.btnExportStrollPokemon.Location = new System.Drawing.Point(632, 390);
            this.btnExportStrollPokemon.Name = "btnExportStrollPokemon";
            this.btnExportStrollPokemon.Size = new System.Drawing.Size(156, 48);
            this.btnExportStrollPokemon.TabIndex = 5;
            this.btnExportStrollPokemon.Text = "Export Stroll Pokemon";
            this.btnExportStrollPokemon.UseVisualStyleBackColor = true;
            this.btnExportStrollPokemon.Click += new System.EventHandler(this.BtnExportStrollPokemon_Click);
            // 
            // viewPK4InformationToolStripMenuItem
            // 
            this.viewPK4InformationToolStripMenuItem.Name = "viewPK4InformationToolStripMenuItem";
            this.viewPK4InformationToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.viewPK4InformationToolStripMenuItem.Text = "View PK4 Information";
            this.viewPK4InformationToolStripMenuItem.Click += new System.EventHandler(this.ViewPK4InformationToolStripMenuItem_Click);
            // 
            // viewTrainerInformationToolStripMenuItem
            // 
            this.viewTrainerInformationToolStripMenuItem.Name = "viewTrainerInformationToolStripMenuItem";
            this.viewTrainerInformationToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.viewTrainerInformationToolStripMenuItem.Text = "View Trainer Information";
            this.viewTrainerInformationToolStripMenuItem.Click += new System.EventHandler(this.ViewTrainerInformationToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportStrollPokemon);
            this.Controls.Add(this.btnPokeRadar);
            this.Controls.Add(this.btnAddSteps);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.Text = "PokeWalker Simulator";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem pokeWalkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setStrollPokemonToolStripMenuItem;
        private System.Windows.Forms.Button btnAddSteps;
        private System.Windows.Forms.Button btnPokeRadar;
        private System.Windows.Forms.Button btnExportStrollPokemon;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginStrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endStrollToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem randomizeStrollPKMIVsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPK4InformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrainerInformationToolStripMenuItem;
    }
}

