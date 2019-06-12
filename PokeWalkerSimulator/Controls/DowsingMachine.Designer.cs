namespace PokeWalkerSimulator.Controls {
    partial class DowsingMachine {
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.picFoundItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoundItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 43);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // picFoundItem
            // 
            this.picFoundItem.Location = new System.Drawing.Point(4, 53);
            this.picFoundItem.Name = "picFoundItem";
            this.picFoundItem.Size = new System.Drawing.Size(69, 60);
            this.picFoundItem.TabIndex = 12;
            this.picFoundItem.TabStop = false;
            // 
            // DowsingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFoundItem);
            this.Controls.Add(this.btnSearch);
            this.Name = "DowsingMachine";
            this.Size = new System.Drawing.Size(431, 365);
            ((System.ComponentModel.ISupportInitialize)(this.picFoundItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picFoundItem;
    }
}
