using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKHeX.WinForms;

namespace PokeWalkerSimulator.Controls {
    public partial class Setup : UserControl {

        public int courseNumber = 0;
        public bool hasSaveLoaded = false;
        public bool hasStrollPokemonLoaded = false;

        public Setup() {
            InitializeComponent();
        }

        public void UpdateCoursePreview() {
            lblCourseName.Text = FormMain.courses[courseNumber].name;
            lblCourseName.Left = (this.ClientSize.Width - lblCourseName.Width) / 2;

            lblCourseDescription.Text = FormMain.courses[courseNumber].description;
            lblCourseDescription.Left = (this.ClientSize.Width - lblCourseDescription.Width) / 2;

            picCoursePreviewImage.Image = FormMain.courses[courseNumber].courseImage;
        }

        private void BtnPreviousCourse_Click(object sender, EventArgs e) {
            courseNumber -= 1;
            btnNextCourse.Enabled = true;

            if (courseNumber == 0) {
                btnPreviousCourse.Enabled = false;
            }

            UpdateCoursePreview();
        }

        private void BtnNextCourse_Click(object sender, EventArgs e) {
            courseNumber += 1;
            btnPreviousCourse.Enabled = true;

            if (courseNumber == FormMain.courses.Length - 1) {
                btnNextCourse.Enabled = false;
            }

            UpdateCoursePreview();
        }

        private void BtnSelectSaveFile_Click(object sender, EventArgs e) {
            if (WinFormsUtil.OpenSAVPKMDialog(FormMain.main.C_SAV.SAV.PKMExtensions, out string path)) {
                FormMain.main.OpenQuick(path);
                hasSaveLoaded = true;
            }

            if (CanStartStroll()) {
                btnStartStroll.Enabled = true;
            }
        }

        private void BtnSelectStrollPokemon_Click(object sender, EventArgs e) {
            // Select the Pokemon
            if (WinFormsUtil.OpenSAVPKMDialog(FormMain.main.C_SAV.SAV.PKMExtensions, out string path)) {
                FormMain.main.OpenQuick(path);
                hasStrollPokemonLoaded = true;
            }

            // Set the Pokemon
            FormMain.strollPokemon = FormMain.main.PKME_Tabs.pkm;

            if (CanStartStroll()) {
                btnStartStroll.Enabled = true;
            }
        }

        public bool CanStartStroll() {
            if (hasStrollPokemonLoaded && hasSaveLoaded) {
                return true;
            } else {
                return false;
            }
        }

        private void BtnStartStroll_Click(object sender, EventArgs e) {
            FormMain.selectedCourse = FormMain.courses[courseNumber];
            MessageBox.Show("Stroll started");
        }
    }
}
