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
            this.picInventoryPokemon0 = new System.Windows.Forms.PictureBox();
            this.picInventoryPokemon1 = new System.Windows.Forms.PictureBox();
            this.picInventoryPokemon2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon2)).BeginInit();
            this.SuspendLayout();
            // 
            // picInventoryPokemon0
            // 
            this.picInventoryPokemon0.Location = new System.Drawing.Point(3, 3);
            this.picInventoryPokemon0.Name = "picInventoryPokemon0";
            this.picInventoryPokemon0.Size = new System.Drawing.Size(80, 60);
            this.picInventoryPokemon0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picInventoryPokemon0.TabIndex = 1;
            this.picInventoryPokemon0.TabStop = false;
            // 
            // picInventoryPokemon1
            // 
            this.picInventoryPokemon1.Location = new System.Drawing.Point(89, 3);
            this.picInventoryPokemon1.Name = "picInventoryPokemon1";
            this.picInventoryPokemon1.Size = new System.Drawing.Size(80, 60);
            this.picInventoryPokemon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picInventoryPokemon1.TabIndex = 2;
            this.picInventoryPokemon1.TabStop = false;
            // 
            // picInventoryPokemon2
            // 
            this.picInventoryPokemon2.Location = new System.Drawing.Point(175, 3);
            this.picInventoryPokemon2.Name = "picInventoryPokemon2";
            this.picInventoryPokemon2.Size = new System.Drawing.Size(80, 60);
            this.picInventoryPokemon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picInventoryPokemon2.TabIndex = 3;
            this.picInventoryPokemon2.TabStop = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picInventoryPokemon2);
            this.Controls.Add(this.picInventoryPokemon1);
            this.Controls.Add(this.picInventoryPokemon0);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(431, 365);
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryPokemon2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picInventoryPokemon0;
        private System.Windows.Forms.PictureBox picInventoryPokemon1;
        private System.Windows.Forms.PictureBox picInventoryPokemon2;
    }
}
