namespace PokeWalkerSimulator.Controls {
    partial class PokeRadar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeRadar));
            this.btnCatch = new System.Windows.Forms.Button();
            this.btnEvade = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.picPokeRadarUser = new System.Windows.Forms.PictureBox();
            this.picWildEncounter = new System.Windows.Forms.PictureBox();
            this.btnStartPokeRadar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPokeRadarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWildEncounter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCatch
            // 
            this.btnCatch.Enabled = false;
            this.btnCatch.Location = new System.Drawing.Point(279, 231);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(113, 43);
            this.btnCatch.TabIndex = 10;
            this.btnCatch.Text = "Catch";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.BtnCatch_Click);
            // 
            // btnEvade
            // 
            this.btnEvade.Enabled = false;
            this.btnEvade.Location = new System.Drawing.Point(160, 231);
            this.btnEvade.Name = "btnEvade";
            this.btnEvade.Size = new System.Drawing.Size(113, 43);
            this.btnEvade.TabIndex = 9;
            this.btnEvade.Text = "Evade";
            this.btnEvade.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Enabled = false;
            this.btnAttack.Location = new System.Drawing.Point(41, 231);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(113, 43);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // picPokeRadarUser
            // 
            this.picPokeRadarUser.Image = ((System.Drawing.Image)(resources.GetObject("picPokeRadarUser.Image")));
            this.picPokeRadarUser.Location = new System.Drawing.Point(323, 113);
            this.picPokeRadarUser.Name = "picPokeRadarUser";
            this.picPokeRadarUser.Size = new System.Drawing.Size(80, 60);
            this.picPokeRadarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPokeRadarUser.TabIndex = 7;
            this.picPokeRadarUser.TabStop = false;
            // 
            // picWildEncounter
            // 
            this.picWildEncounter.Image = ((System.Drawing.Image)(resources.GetObject("picWildEncounter.Image")));
            this.picWildEncounter.Location = new System.Drawing.Point(27, 43);
            this.picWildEncounter.Name = "picWildEncounter";
            this.picWildEncounter.Size = new System.Drawing.Size(80, 60);
            this.picWildEncounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWildEncounter.TabIndex = 6;
            this.picWildEncounter.TabStop = false;
            // 
            // btnStartPokeRadar
            // 
            this.btnStartPokeRadar.Location = new System.Drawing.Point(135, 280);
            this.btnStartPokeRadar.Name = "btnStartPokeRadar";
            this.btnStartPokeRadar.Size = new System.Drawing.Size(160, 43);
            this.btnStartPokeRadar.TabIndex = 11;
            this.btnStartPokeRadar.Text = "Start PokeRadar";
            this.btnStartPokeRadar.UseVisualStyleBackColor = true;
            this.btnStartPokeRadar.Click += new System.EventHandler(this.BtnStartPokeRadar_Click);
            // 
            // PokeRadar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStartPokeRadar);
            this.Controls.Add(this.btnCatch);
            this.Controls.Add(this.btnEvade);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.picPokeRadarUser);
            this.Controls.Add(this.picWildEncounter);
            this.Name = "PokeRadar";
            this.Size = new System.Drawing.Size(431, 365);
            ((System.ComponentModel.ISupportInitialize)(this.picPokeRadarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWildEncounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Button btnEvade;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox picPokeRadarUser;
        private System.Windows.Forms.PictureBox picWildEncounter;
        private System.Windows.Forms.Button btnStartPokeRadar;
    }
}
