namespace PokeWalkerSimulator.Controls {
    partial class Setup {
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
            this.grpCourseSetup = new System.Windows.Forms.GroupBox();
            this.btnPreviousCourse = new System.Windows.Forms.Button();
            this.btnNextCourse = new System.Windows.Forms.Button();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.picCoursePreviewImage = new System.Windows.Forms.PictureBox();
            this.grpAdditionalSettings = new System.Windows.Forms.GroupBox();
            this.btnSelectStrollPokemon = new System.Windows.Forms.Button();
            this.btnSelectSaveFile = new System.Windows.Forms.Button();
            this.btnStartStroll = new System.Windows.Forms.Button();
            this.grpCourseSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoursePreviewImage)).BeginInit();
            this.grpAdditionalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourseSetup
            // 
            this.grpCourseSetup.Controls.Add(this.btnPreviousCourse);
            this.grpCourseSetup.Controls.Add(this.btnNextCourse);
            this.grpCourseSetup.Controls.Add(this.lblCourseDescription);
            this.grpCourseSetup.Controls.Add(this.lblCourseName);
            this.grpCourseSetup.Controls.Add(this.picCoursePreviewImage);
            this.grpCourseSetup.Location = new System.Drawing.Point(4, 4);
            this.grpCourseSetup.Name = "grpCourseSetup";
            this.grpCourseSetup.Size = new System.Drawing.Size(424, 213);
            this.grpCourseSetup.TabIndex = 0;
            this.grpCourseSetup.TabStop = false;
            this.grpCourseSetup.Text = "Select Course";
            // 
            // btnPreviousCourse
            // 
            this.btnPreviousCourse.Enabled = false;
            this.btnPreviousCourse.Location = new System.Drawing.Point(128, 91);
            this.btnPreviousCourse.Name = "btnPreviousCourse";
            this.btnPreviousCourse.Size = new System.Drawing.Size(30, 30);
            this.btnPreviousCourse.TabIndex = 4;
            this.btnPreviousCourse.Text = "<";
            this.btnPreviousCourse.UseVisualStyleBackColor = true;
            this.btnPreviousCourse.Click += new System.EventHandler(this.BtnPreviousCourse_Click);
            // 
            // btnNextCourse
            // 
            this.btnNextCourse.Location = new System.Drawing.Point(264, 91);
            this.btnNextCourse.Name = "btnNextCourse";
            this.btnNextCourse.Size = new System.Drawing.Size(30, 30);
            this.btnNextCourse.TabIndex = 3;
            this.btnNextCourse.Text = ">";
            this.btnNextCourse.UseVisualStyleBackColor = true;
            this.btnNextCourse.Click += new System.EventHandler(this.BtnNextCourse_Click);
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Location = new System.Drawing.Point(150, 128);
            this.lblCourseDescription.MaximumSize = new System.Drawing.Size(288, 0);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(124, 17);
            this.lblCourseDescription.TabIndex = 2;
            this.lblCourseDescription.Text = "CourseDescription";
            this.lblCourseDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(165, 22);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(94, 17);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // picCoursePreviewImage
            // 
            this.picCoursePreviewImage.Image = global::PokeWalkerSimulator.Properties.Resources.Route_plains2;
            this.picCoursePreviewImage.Location = new System.Drawing.Point(164, 49);
            this.picCoursePreviewImage.Name = "picCoursePreviewImage";
            this.picCoursePreviewImage.Size = new System.Drawing.Size(96, 72);
            this.picCoursePreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoursePreviewImage.TabIndex = 0;
            this.picCoursePreviewImage.TabStop = false;
            // 
            // grpAdditionalSettings
            // 
            this.grpAdditionalSettings.Controls.Add(this.btnSelectStrollPokemon);
            this.grpAdditionalSettings.Controls.Add(this.btnSelectSaveFile);
            this.grpAdditionalSettings.Location = new System.Drawing.Point(4, 224);
            this.grpAdditionalSettings.Name = "grpAdditionalSettings";
            this.grpAdditionalSettings.Size = new System.Drawing.Size(424, 77);
            this.grpAdditionalSettings.TabIndex = 1;
            this.grpAdditionalSettings.TabStop = false;
            this.grpAdditionalSettings.Text = "Additional Settings";
            // 
            // btnSelectStrollPokemon
            // 
            this.btnSelectStrollPokemon.Location = new System.Drawing.Point(207, 30);
            this.btnSelectStrollPokemon.Name = "btnSelectStrollPokemon";
            this.btnSelectStrollPokemon.Size = new System.Drawing.Size(132, 31);
            this.btnSelectStrollPokemon.TabIndex = 1;
            this.btnSelectStrollPokemon.Text = "Select Stroll PKM";
            this.btnSelectStrollPokemon.UseVisualStyleBackColor = true;
            this.btnSelectStrollPokemon.Click += new System.EventHandler(this.BtnSelectStrollPokemon_Click);
            // 
            // btnSelectSaveFile
            // 
            this.btnSelectSaveFile.Location = new System.Drawing.Point(85, 30);
            this.btnSelectSaveFile.Name = "btnSelectSaveFile";
            this.btnSelectSaveFile.Size = new System.Drawing.Size(116, 31);
            this.btnSelectSaveFile.TabIndex = 0;
            this.btnSelectSaveFile.Text = "Select Save";
            this.btnSelectSaveFile.UseVisualStyleBackColor = true;
            this.btnSelectSaveFile.Click += new System.EventHandler(this.BtnSelectSaveFile_Click);
            // 
            // btnStartStroll
            // 
            this.btnStartStroll.Enabled = false;
            this.btnStartStroll.Location = new System.Drawing.Point(158, 307);
            this.btnStartStroll.Name = "btnStartStroll";
            this.btnStartStroll.Size = new System.Drawing.Size(120, 47);
            this.btnStartStroll.TabIndex = 2;
            this.btnStartStroll.Text = "Start Stroll";
            this.btnStartStroll.UseVisualStyleBackColor = true;
            this.btnStartStroll.Click += new System.EventHandler(this.BtnStartStroll_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStartStroll);
            this.Controls.Add(this.grpAdditionalSettings);
            this.Controls.Add(this.grpCourseSetup);
            this.Name = "Setup";
            this.Size = new System.Drawing.Size(431, 365);
            this.grpCourseSetup.ResumeLayout(false);
            this.grpCourseSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoursePreviewImage)).EndInit();
            this.grpAdditionalSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourseSetup;
        private System.Windows.Forms.PictureBox picCoursePreviewImage;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseDescription;
        private System.Windows.Forms.Button btnPreviousCourse;
        private System.Windows.Forms.Button btnNextCourse;
        private System.Windows.Forms.GroupBox grpAdditionalSettings;
        private System.Windows.Forms.Button btnSelectSaveFile;
        private System.Windows.Forms.Button btnSelectStrollPokemon;
        private System.Windows.Forms.Button btnStartStroll;
    }
}
