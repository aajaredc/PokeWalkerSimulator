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
            this.pokeWalkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStrollPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSteps = new System.Windows.Forms.Button();
            this.btnPokeRadar = new System.Windows.Forms.Button();
            this.getPK4Info = new System.Windows.Forms.Button();
            this.btnRandomIVs = new System.Windows.Forms.Button();
            this.btnExportStrollPokemon = new System.Windows.Forms.Button();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginStrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endStrollToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            // pokeWalkerToolStripMenuItem
            // 
            this.pokeWalkerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginStrollToolStripMenuItem,
            this.setStrollPokemonToolStripMenuItem});
            this.pokeWalkerToolStripMenuItem.Name = "pokeWalkerToolStripMenuItem";
            this.pokeWalkerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.pokeWalkerToolStripMenuItem.Text = "PokeWalker";
            // 
            // setStrollPokemonToolStripMenuItem
            // 
            this.setStrollPokemonToolStripMenuItem.Name = "setStrollPokemonToolStripMenuItem";
            this.setStrollPokemonToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.setStrollPokemonToolStripMenuItem.Text = "Set Stroll Pokemon";
            this.setStrollPokemonToolStripMenuItem.Click += new System.EventHandler(this.SetStrollPokemonToolStripMenuItem_Click);
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
            // getPK4Info
            // 
            this.getPK4Info.Location = new System.Drawing.Point(12, 390);
            this.getPK4Info.Name = "getPK4Info";
            this.getPK4Info.Size = new System.Drawing.Size(156, 48);
            this.getPK4Info.TabIndex = 3;
            this.getPK4Info.Text = "Get PKHeX PK4 info";
            this.getPK4Info.UseVisualStyleBackColor = true;
            this.getPK4Info.Click += new System.EventHandler(this.GetPK4Info_Click);
            // 
            // btnRandomIVs
            // 
            this.btnRandomIVs.Location = new System.Drawing.Point(174, 390);
            this.btnRandomIVs.Name = "btnRandomIVs";
            this.btnRandomIVs.Size = new System.Drawing.Size(156, 48);
            this.btnRandomIVs.TabIndex = 4;
            this.btnRandomIVs.Text = "Randomize IVs";
            this.btnRandomIVs.UseVisualStyleBackColor = true;
            this.btnRandomIVs.Click += new System.EventHandler(this.BtnRandomIVs_Click);
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
            this.selectSaveFileToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.selectSaveFileToolStripMenuItem.Text = "Select Save File";
            this.selectSaveFileToolStripMenuItem.Click += new System.EventHandler(this.SelectSaveFileToolStripMenuItem_Click);
            // 
            // exportSaveFileToolStripMenuItem
            // 
            this.exportSaveFileToolStripMenuItem.Name = "exportSaveFileToolStripMenuItem";
            this.exportSaveFileToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exportSaveFileToolStripMenuItem.Text = "Export Save File";
            this.exportSaveFileToolStripMenuItem.Click += new System.EventHandler(this.ExportSaveFileToolStripMenuItem_Click);
            // 
            // beginStrollToolStripMenuItem
            // 
            this.beginStrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStrollToolStripMenuItem,
            this.endStrollToolStripMenuItem1});
            this.beginStrollToolStripMenuItem.Name = "beginStrollToolStripMenuItem";
            this.beginStrollToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.beginStrollToolStripMenuItem.Text = "Stroll";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // startStrollToolStripMenuItem
            // 
            this.startStrollToolStripMenuItem.Name = "startStrollToolStripMenuItem";
            this.startStrollToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.startStrollToolStripMenuItem.Text = "Start Stroll";
            // 
            // endStrollToolStripMenuItem1
            // 
            this.endStrollToolStripMenuItem1.Name = "endStrollToolStripMenuItem1";
            this.endStrollToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.endStrollToolStripMenuItem1.Text = "End Stroll";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportStrollPokemon);
            this.Controls.Add(this.btnRandomIVs);
            this.Controls.Add(this.getPK4Info);
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
        private System.Windows.Forms.Button getPK4Info;
        private System.Windows.Forms.Button btnRandomIVs;
        private System.Windows.Forms.Button btnExportStrollPokemon;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginStrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endStrollToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
    }
}

