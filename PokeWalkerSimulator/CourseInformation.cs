using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWalkerSimulator {
    class CourseInformation {
        /// <summary>
        /// Names of each Course
        /// </summary>
        public static string[] courseNames = {
            "Refreshing Field", // refreshing field
            "Noisy Forest", // noisy forest
            "Rugged Road", // rugged road
            "Beautiful Beach" // beautiful beach
        };

        /// <summary>
        /// Descriptions of each Course
        /// </summary>
        public static string[] courseDescriptions = {
            "A wonderfully refreshing field for a Stroll. You can meet many kinds of Pokémon here.", // refreshing field
            "A large natural forest that has been allowed to grow. Many Pokémon live deep in the forest.", // noisy forest
            "A hilly, rugged mountain road. The view from atop the mountain is very beautiful.", // rugged road
            "This beautiful sea is a popular place for a Stroll. You can meet many Water-type Pokémon." // beautiful beach
        };

        /// <summary>
        /// Required number of steps for each PKM of each Course
        /// </summary>
        public static int[][] coursePokemonSteps = {
            new int[] { 2000, 3000, 500, 500, 0, 0 }, // refreshing field
            new int[] { 3000, 4000, 700, 700, 0, 0 }, // noisy forest
            new int[] { 4000, 5000, 1000, 1000, 0, 0 }, // rugged road
            new int[] { 4000, 5000, 1500, 1000, 0, 0 } // beautiful beach
        };

        /// <summary>
        /// Course PKM encounter calculation types
        /// </summary>
        public static int[] pokemonEncounterCalculationTypes = {
            0, // refreshing field
            0, // noisy forest
            0, // rugged road
            0 // beautiful beach
        };

        /// <summary>
        /// Probabilities for each PKM of each Course
        /// </summary>
        public static double[][] pokemonEncounterProbabilties = {
            // refreshing field
            new double[] {
                0, 0, 70, //00
                0, 0, 50, //01
                0, 75, 22.5, 0, 75, 37.5, //10
                0, 75, 22.5, 0, 75, 37.5, //11
                100, 25, 7.5, 100, 25, 12.5, //20
                100, 25, 7.5, 100, 25, 12.5  //21
            },
            // noisy forest
            new double[] {
                0, 0, 70, //00
                0, 0, 30, //01
                0, 89, 26.7, 0, 89, 62.3, //10
                0, 89, 26.7, 0, 89, 62.3, //11
                100, 11, 3.3, 100, 11, 7.7, //20
                100, 11, 3.3, 100, 11, 7.7  //21
            },
            // rugged road
            new double[] {
                0, 0, 80, //00
                0, 0, 50, //01
                0, 92, 18.4, 0, 92, 46, //10
                0, 92, 18.4, 0, 92, 46, //11
                100, 8, 1.6, 100, 8, 4, //20
                100, 8, 1.6, 100, 8, 4  //21
            },
            // beautiful beach
            new double[] {
                0, 0, 70,
                0, 0, 60,
                0, 87, 26.1, 0, 87, 34.8,
                0, 87, 26.1, 0, 87, 34.8,
                100, 13, 3.9, 100, 13, 5.2,
                100, 13, 3.9, 100, 13, 5.2
            }
        };

        /// <summary>
        /// Number identifies of each item for each Course
        /// </summary>
        public static int[][] itemNumbers = {
            new int[] { 28, 27, 19, 20, 150, 21, 149, 12, 155, 17 }, // refreshing field
            new int[] { 6, 28, 75, 38, 35, 34, 87, 151, 86, 149 }, // noisy forest
            new int[] { 51, 238, 72, 91, 27, 76, 19, 18, 78, 79 }, // rugged road
            new int[] { 7, 89, 73, 93, 154, 27, 153, 31, 152, 30 } // beautiful beach
        };

        /// <summary>
        /// Required steps for each items for each Course
        /// </summary>
        public static double[][] itemRequiredSteps = {
            new double[] { 0, 300, 500, 600, 700, 800, 900, 1000, 2000, 2500 }, // refreshing field
            new double[] { 0, 200, 500, 700, 800, 900, 1000, 2000, 2500, 5000 }, // noisy forest
            new double[] { 0, 100, 500, 800, 1000, 1500, 2000, 3000, 5000, 7000 }, // rugged road
            new double[] { 0, 100, 800, 1000, 1500, 1800, 2000, 3000, 4000, 5000 } // beautiful beach
        };

        /// <summary>
        /// Probabillity percentages of each item in each Course
        /// </summary>
        public static double[][,] itemProbabilities = new double[][,] {
            // Refreshing field
            new double[10,10] { // 0,9 = 20 & 9,0 = 100
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 20 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 20, 16 },
                { 0, 0, 0, 0, 0, 0, 0, 30, 24, 19 },
                { 0, 0, 0, 0, 0, 0, 30, 21, 17, 13 },
                { 0, 0, 0, 0, 0, 30, 21, 15, 12, 9 },
                { 0, 0, 0, 0, 40, 28, 20, 14, 11, 9 },
                { 0, 0, 0, 50, 30, 21, 15, 10, 8, 7 },
                { 0, 0, 50, 25, 15, 11, 7, 5, 4, 3 },
                { 0, 50, 25, 13, 8, 5, 4, 3, 2, 2 },
                { 100, 50, 25, 13, 8, 5, 4, 3, 2, 2 }
            },
            // Noisy Forest
            new double[10,10] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 30 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 20, 14 },
                { 0, 0, 0, 0, 0, 0, 0, 20, 16, 11 },
                { 0, 0, 0, 0, 0, 0, 5, 4, 3, 2 },
                { 0, 0, 0, 0, 0, 10, 10, 8, 6, 4 },
                { 0, 0, 0, 0, 50, 45, 43, 34, 27, 19 },
                { 0, 0, 0, 10, 5, 5, 4, 3, 3, 2 },
                { 0, 0, 50, 45, 23, 20, 19, 15, 12, 9 },
                { 0, 50, 25, 23, 11, 10, 10, 8, 6, 4 },
                { 100, 50, 25, 23, 11, 10, 10, 8, 6, 4 }
            },
            // Rugged Road
            new double[10,10] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 3 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 10, 10 },
                { 0, 0, 0, 0, 0, 0, 0, 20, 18, 17 },
                { 0, 0, 0, 0, 0, 0, 20, 16, 14, 14 },
                { 0, 0, 0, 0, 0, 20, 16, 13, 12, 11 },
                { 0, 0, 0, 0, 20, 16, 13, 10, 9, 9 },
                { 0, 0, 0, 20, 16, 13, 10, 8, 7, 7 },
                { 0, 0, 40, 32, 26, 20, 16, 13, 12, 11 },
                { 0, 50, 30, 24, 19, 15, 12, 10, 9, 9 },
                { 100, 50, 30, 24, 19, 15, 12, 10, 9, 9 }
            },
            // Beautiful Beach
            new double[10,10] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 30 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 20, 14 },
                { 0, 0, 0, 0, 0, 0, 0, 20, 16, 11 },
                { 0, 0, 0, 0, 0, 0, 20, 16, 13, 9 },
                { 0, 0, 0, 0, 0, 20, 16, 13, 10, 7 },
                { 0, 0, 0, 0, 30, 24, 19, 15, 12, 9 },
                { 0, 0, 0, 20, 14, 11, 9, 7, 6, 4 },
                { 0, 0, 50, 40, 28, 22, 18, 14, 11, 8 },
                { 0, 40, 20, 16, 11, 9, 7, 6, 5, 3 },
                { 100, 60, 30, 24, 17, 13, 11, 9, 7, 5 }
            }
        };
    }
}
