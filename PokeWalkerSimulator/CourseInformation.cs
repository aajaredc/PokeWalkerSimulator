using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWalkerSimulator {
    class CourseInformation {
        // Course names
        public static string[] courseNames = {
            "Refreshing Field", // refreshing field
            "Noisy Forest", // noisy forest
            "Rugged Road" // rugged road
        };

        // Course descriptions
        public static string[] courseDescriptions = {
            "A wonderfully refreshing field for a Stroll. You can meet many kinds of Pokémon here.", // refreshing field
            "A large natural forest that has been allowed to grow. Many Pokémon live deep in the forest.", // noisy forest
            "A hilly, rugged mountain road. The view from atop the mountain is very beautiful." // rugged road
        };

        // Required steps
        public static int[][] coursePokemonSteps = {
            new int[] { 2000, 3000, 500, 500, 0, 0 }, // refreshing field
            new int[] { 3000, 4000, 700, 700, 0, 0 }, // noisy forest
            new int[] { 4000, 5000, 1000, 1000, 0, 0 } // rugged road
        };

        // Course names
        public static int[] pokemonEncounterCalculationTypes = {
            0, // refreshing field
            0, // noisy forest
            0 // rugged road
        };

        // Encounter probabilities
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
            }
        };

        // Item numbers
        public static int[][] itemNumbers = {
            new int[] { 28, 27, 19, 20, 150, 21, 149, 12, 155, 17 }, // refreshing field
            new int[] { 28, 27, 19, 20, 150, 21, 149, 12, 155, 17 }, // noisy forest
            new int[] { 28, 27, 19, 20, 150, 21, 149, 12, 155, 17 } // rugged road
        };

        // Item probabilties
        public static double[][,] itemProbabilities = new double[][,] {
            // Refreshing field
            new double[10,10] {
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
            }
        };
    }
}
