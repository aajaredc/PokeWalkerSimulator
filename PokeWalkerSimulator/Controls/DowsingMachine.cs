using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeWalkerSimulator.Controls {
    public partial class DowsingMachine : UserControl {
        public DowsingMachine() {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e) {

            // Find out which item steps column to search item numbers from
            for (int s = 0; s < FormMain.selectedCourse.itemRequiredSteps.Length; s++) {

                try {
                    // This if statement checks all of the columns except for the last one
                    if (FormMain.selectedCourse.stepsTaken >= FormMain.selectedCourse.itemRequiredSteps[s] &&
                        FormMain.selectedCourse.stepsTaken < FormMain.selectedCourse.itemRequiredSteps[s + 1]) {

                        SearchForItem(s);
                        return;

                    }
                } catch (IndexOutOfRangeException) {
                    // This if statement checks the last column
                    if (FormMain.selectedCourse.stepsTaken >= FormMain.selectedCourse.itemRequiredSteps[FormMain.selectedCourse.itemRequiredSteps.Length - 1]) {

                        SearchForItem(FormMain.selectedCourse.itemRequiredSteps.Length - 1);
                        return;

                    }
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemNumberColumn"></param>
        private void SearchForItem(int itemNumberColumn) {
            Console.WriteLine("Searching column " + itemNumberColumn);

            Random random = new Random();
            int dowsingMachineSelection = random.Next(0, 100);
            double cumulativeRandom = 0;
            Console.WriteLine("Random: " + dowsingMachineSelection);

            for (int n = 0; n < FormMain.selectedCourse.itemNumbers.Length; n++) {

                cumulativeRandom += FormMain.selectedCourse.itemProbabilities[n, itemNumberColumn];

                if (dowsingMachineSelection < cumulativeRandom) {
                    Console.WriteLine("Found item " + FormMain.selectedCourse.itemNumbers[n]);
                }

            }
        }
    }
}
