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
            "Beautiful Beach", // beautiful beach
            "Suburban Area", // suburban area
            "Dim Cave", // dim cave
            "Blue Lake", // blue lake
            "Town Outskirts", // town outskirts
            "Hoenn Field", // hoenn field
            "Warm Beach", // warm beach
            "Volcano Path", // volcano path
            "Treehouse", // treehouse
            "Scary Cave", // scary cave
            "Sinnoh Field", // sinnoh field
            "Icy Mountain Rd.", // icy mountain rd
            "Big Forest", // big forest
            "White Lake", // white lake
            "Stormy Beach", // stormy beach
            "Resort", // resort
            "Quiet Cave", // quiet cave
            "Beyond the Sea", // beyond the sea
            "Night Skys Edge", // night skys edge
            "Yellow Forest", // yellow forest
            "Rally", //rally
            "Sightseeing", // sightseeing
            "Winner's Path", // winner's path
            "Amity Meadow" // amity meadow
        };

        /// <summary>
        /// Descriptions of each Course
        /// </summary>
        public static string[] courseDescriptions = {
            "A wonderfully refreshing field for a Stroll. You can meet many kinds of Pokémon here.", // refreshing field
            "A large natural forest that has been allowed to grow. Many Pokémon live deep in the forest.", // noisy forest
            "A hilly, rugged mountain road. The view from atop the mountain is very beautiful.", // rugged road
            "This beautiful sea is a popular place for a Stroll. You can meet many Water-type Pokémon.", // beautiful beach
            "A residential area somewhere. Even when you take a Stroll here, you can meet Pokémon.", // suburban area
            "A dark cave sometimes used as a test of courage. Look closely, and you'll find many Pokémon.", // dim cave
            "A deep, blue lake. It's said that some rare Pokémon live at the bottom of this lake.", // blue lake 
            "The outskirts of a town. Where people have moved away, Pokémon have moved in.", // town outskirts
            "A Route that goes deep into the Hoenn Region. You can meet many Pokémon not in Johto or Kanto.", // hoenn field
            "A very warm beach in the Hoenn region. You can meet many Pokémon not in Johto or Kanto.", // warm beach
            "A path through a currently active volcano. Very fiery and rare Pokémon live here.", // volcano path
            "A path that works with the trees of the forest. Pokémon here are always changing.", // treehouse
            "A pitch-black cave that seems haunted. It's said that many Pokémon live deep inside.", // scary cave
            "A Route through the Sinnoh region, far from Johto and Kanto. Rare Pokémon live here.", // sinnoh field
            "A snow-covered road where a misstep could result in a fall-- it tests your trust in Pokémon.", // icy mountain rd
            "A forest surrounded by many old trees since the olden days. Many Pokémon live here.", // big forest
            "A lake concealed in white mist. It lends a very mysterious feel to the area", // white lake
            "Strong waves wash onto this beach. Because people don't visit, rare Pokémon live here.", // stormy beach
            "A high-class resort everyone wants to visit, famous for the cute Pokémon living here.", // resort
            "A quiet, deep, and empty cave. If you look carefully, you'll find some rare Pokémon", // quiet cave
            "A small island far away on the horizon. If you look to the sea, you can see Pokémon swimming.", // beyond the sea
            "A dark mountain path that gives you the feeling you've traveled through time back to the past.", // night skys edge
            "Many PIKACHU live in harmony in this forest. Walk through here frequently, and try to find one!", // yellow forest
            "A fun Route to play with your Pokéwalker. Take a Stroll and visit the many places!", // rally
            "You can find many Pokémon on this Route. Take a long walk and see if you can find them all!", // sightseeing
            "If you're aiming to be Champion, you'll want to walk this Route! You'll meet strong Pokémon!", // winner's path
            "You can meet cute Pokémon that evolve through friendship and find items to evolve Pokémon!" // amity meadow
        };

        /// <summary>
        /// Required number of steps for each PKM of each Course
        /// </summary>
        public static int[][] coursePokemonSteps = {
            new int[] { 2000, 3000, 500, 500, 0, 0 }, // refreshing field
            new int[] { 3000, 4000, 700, 700, 0, 0 }, // noisy forest
            new int[] { 4000, 5000, 1000, 1000, 0, 0 }, // rugged road
            new int[] { 4000, 5000, 1500, 1000, 0, 0 }, // beautiful beach
            new int[] { 4000, 5000, 1000, 1000, 0, 0 }, // suburban area
            new int[] { 5000, 5000, 1000, 1000, 0, 0 }, // dim cave
            new int[] { 4000, 5000, 500, 500, 0, 0 }, // blue lake
            new int[] { 5000, 3000, 1500, 1500, 0, 0 }, // town outskirts
            new int[] { 5000, 7500, 2000, 2000, 0, 0 }, // hoenn field
            new int[] { 5000, 7000, 1500, 1500, 0, 0 }, // warm beach
            new int[] { 5000, 5000, 2000, 2000, 0, 0 }, // volcano path
            new int[] { 5000, 5000, 1000, 1000, 0, 0 }, // treehouse
            new int[] { 5000, 5000, 500, 1000, 0, 0 }, // scary cave
            new int[] { 7000, 7000, 3000, 3000, 0, 0 }, // sinnoh field
            new int[] { 10000, 10000, 3000, 3000, 0, 0 }, // icy mountain rd
            new int[] { 6000, 5000, 1000, 1000, 0, 0 }, // big forest
            new int[] { 6000, 5000, 500, 1000, 0, 0 }, // white lake
            new int[] { 5000, 4000, 1500, 500, 0, 0 }, // stormy beach
            new int[] { 8000, 8000, 4000, 4000, 0, 0 }, // resort
            new int[] { 10000, 10000, 500, 500, 0, 0 }, // quiet cave
            new int[] { 5000, 5000, 2500, 2500, 0, 0 }, // beyond the sea
            new int[] { 5000, 5000, 2500, 2500, 0, 0 }, // night skys edge
            new int[] { 10000, 9500, 2000, 5000, 0, 0 }, // yellow forest
            new int[] { 1000, 1000, 500, 500, 0, 0 }, // rally
            new int[] { 7000, 10000, 2000, 3000, 0, 0 }, // sightseeing
            new int[] { 8000, 8000, 3000, 3000, 0, 0 }, // winner's path
            new int[] { 5000, 5000, 2000, 2000, 0, 0 } // amity meadow
        };

        /// <summary>
        /// Course PKM encounter calculation types
        /// </summary>
        public static int[] pokemonEncounterCalculationTypes = {
            0, // refreshing field
            0, // noisy forest
            0, // rugged road
            0, // beautiful beach
            1, // suburban area
            0, // dim cave
            1, // blue lake
            1, // town outskirts
            0, // hoenn field
            0, // warm beach
            0, // volcano path
            0, // treehouse
            2, // scary cave
            0, // sinnoh field
            2, // icy mountain rd
            0, // big forest
            2, // white lake
            0, // stormy beach
            3, // resort
            1, // quiet cave
            0, // beyond the sea
            3, // night skys edge
            1, // yellow forest
            3, // rally
            0, // sightseeing
            0, // winner's path
            3 // amity meadow
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
            },
            // suburban area
            new double[] {
                0, 0, 40,
                0, 0, 15,
                0, 85, 51, 0, 85, 72.25,
                0, 45, 27, 0, 45, 38.25,
                100, 15, 9, 100, 55, 33, 100, 15, 12.75, 100, 55, 47.75,
                100, 15, 9, 100, 55, 33, 100, 15, 12.75, 100, 55, 47.75
            },
            // dim cave
            new double[] {
                0, 0, 20,
                0, 0, 50,
                0, 92, 73.6, 0, 92, 46,
                0, 92, 73.6, 0, 92, 46,
                100, 8, 6.4, 100, 8, 4,
                100, 8, 6.4, 100, 8, 4
            },
            // blue lake
            new double[] {
                0, 0, 60,
                0, 0, 30,
                0, 92, 36.8, 0, 92, 64.4,
                0, 72, 28.8, 0, 72, 50.4,
                100, 8, 3.2, 100, 28, 11.2, 100, 8, 5.6, 100, 28, 19.6,
                100, 8, 3.2, 100, 28, 11.2, 100, 8, 5.6, 100, 28, 19.6
            },
            // town outskirts
            new double[] {
                0, 0, 40,
                0, 0, 60,
                0, 92, 55.2, 0, 92, 36.8,
                0, 75, 45, 0, 75, 30,
                100, 8, 4.8, 100, 25, 15, 100, 8, 3.2, 100, 25, 10,
                100, 8, 4.8, 100, 25, 15, 100, 8, 3.2, 100, 25, 10
            },
            // hoenn field
            new double[] {
                0, 0, 75,
                0, 0, 50,
                0, 84, 21, 0, 84, 42,
                0, 84, 21, 0, 84, 42,
                100, 16, 4, 100, 16, 8,
                100, 16, 4, 100, 16, 8
            },
            // warm beach
            new double[] {
                0, 0, 50,
                0, 0, 50,
                0, 84, 42, 0, 84, 42,
                0, 84, 42, 0, 84, 42,
                100, 16, 8, 100, 16, 8,
                100, 16, 8, 100, 16, 8
            },
            // volcano path
            new double[] {
                0, 0, 70,
                0, 0, 60,
                0, 85, 25.5, 0, 85, 34,
                0, 85, 25.5, 0, 85, 34,
                100, 15, 4.5, 100, 15, 6,
                100, 15, 4.5, 100, 15, 6
            },
            // treehouse
            new double[] {
                0, 0, 30,
                0, 0, 30,
                0, 85, 59.5, 0, 85, 59.5,
                0, 85, 59.5, 0, 85, 59.5,
                100, 15, 10.5, 100, 15, 10.5,
                100, 15, 10.5, 100, 15, 10.5
            },
            // scary cave
            new double[] {
                0, 0, 45,
                0, 0, 45,
                0, 65, 35.75,
                0, 55, 30.25,
                100, 35, 19.25, 100, 45, 24.75,
                100, 35, 19.25, 100, 45, 24.75
            },
            // sinnoh field
            new double[] {
                0, 0, 45,
                0, 0, 40,
                0, 55, 30.25, 0, 55, 33,
                0, 55, 30.25, 0, 55, 33,
                100, 45, 24.75, 100, 45, 27,
                100, 45, 24.75, 100, 45, 27
            },
            // icy mountain rd
            new double[] {
                0, 0, 50,
                0, 0, 50,
                0, 55, 27.5,
                0, 75, 37.5,
                100, 45, 22.5, 100, 25, 12.5,
                100, 45, 22.5, 100, 25, 12.5
            },
            // big forest
            new double[] {
                0, 0, 50,
                0, 0, 40,
                0, 55, 27.5, 0, 55, 33,
                0, 55, 27.5, 0, 55, 33,
                100, 45, 22.5, 100, 45, 27,
                100, 45, 22.5, 100, 45, 27
            },
            // white lake
            new double[] {
                0, 0, 50,
                0, 0, 50,
                0, 55, 27.5,
                0, 65, 32.5,
                100, 45, 22.5, 100, 35, 17.5,
                100, 45, 22.5, 100, 35, 17.5
            },
            // stormy beach
            new double[] {
                0, 0, 55,
                0, 0, 30,
                0, 69, 29.25, 0, 65, 45.5,
                0, 69, 29.25, 0, 65, 45.5,
                100, 35, 15.75, 100, 35, 24.5,
                100, 35, 15.75, 100, 35, 24.5
            },
            // resort
            new double[] {
                0, 0, 45,
                0, 0, 45,
                0, 55, 30.25,
                0, 55, 30.25,
                100, 45, 24.75,
                100, 45, 24.75
            },
            // quiet cave
            new double[] {
                0, 0, 5,
                0, 0, 15,
                0, 20, 19, 0, 20, 17,
                0, 45, 42.75, 0, 45, 38.25,
                100, 80, 76, 100, 55, 52.25, 100, 80, 68, 100, 55, 46.75,
                100, 80, 76, 100, 55, 52.25, 100, 80, 68, 100, 55, 46.75
            },
            // beyond the sea
            new double[] {
                0, 0, 20,
                0, 0, 5,
                0, 55, 44, 0, 55, 52.25,
                0, 55, 44, 0, 55, 52.25,
                100, 45, 36, 100, 45, 42.75,
                100, 45, 36, 100, 45, 42.75
            },
            // night skys edge
            new double[] {
                0, 0, 55,
                0, 0, 55,
                0, 75, 33.75,
                0, 75, 33.75,
                100, 25, 11.25,
                100, 25, 11.25
            },
            // yellow forest
            new double[] {
                0, 0, 2,
                0, 0, 3,
                0, 35, 34.3, 0, 35, 33.95,
                0, 8, 7.84, 0, 8, 7.8,
                100, 65, 63.7, 100, 92, 90.46, 100, 65, 63.05, 100, 92, 89.2,
                100, 65, 63.7, 100, 92, 90.46, 100, 65, 63.05, 100, 92, 89.2
            },
            // rally
            new double[] {
                0, 0, 25,
                0, 0, 25,
                0, 55, 41.25,
                0, 55, 41.25,
                100, 45, 33.75,
                100, 45, 33.75,
            },
            // sightseeing
            new double[] {
                0, 0, 10,
                0, 0, 1,
                0, 35, 31.5, 0, 35, 34.65,
                0, 35, 31.5, 0, 35, 34.65,
                100, 65, 58.5, 100, 65, 64.35,
                100, 65, 58.5, 100, 65, 64.35
            },
            // winner's path
            new double[] {
                0, 0, 20,
                0, 0, 5,
                0, 55, 45, 0, 55, 52.25,
                0, 55, 45, 0, 55, 52.25,
                100, 45, 36, 100, 45, 42.75,
                100, 45, 36, 100, 45, 42.75,
            },
            // amity meadow
            new double[] {
                0, 0, 20,
                0, 0, 20,
                0, 55, 44,
                0, 55, 44,
                100, 45, 36,
                100, 45, 36
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
        public static int[][] itemRequiredSteps = {
            new int[] { 0, 300, 500, 600, 700, 800, 900, 1000, 2000, 2500 }, // refreshing field
            new int[] { 0, 200, 500, 700, 800, 900, 1000, 2000, 2500, 5000 }, // noisy forest
            new int[] { 0, 100, 500, 800, 1000, 1500, 2000, 3000, 5000, 7000 }, // rugged road
            new int[] { 0, 100, 800, 1000, 1500, 1800, 2000, 3000, 4000, 5000 } // beautiful beach
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
            },
            // Suburban Area
            new double[10,10] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 3 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 30, 29 },
                { 0, 0, 0, 0, 0, 0, 0, 30, 21, 20 },
                { 0, 0, 0, 0, 0, 0, 30, 21, 15, 14 },
                { 0, 0, 0, 0, 0, 30, 21, 15, 10, 10 },
                { 0, 0, 0, 0, 30, 21, 15, 10, 7, 7 },
                { 0, 0, 0, 30, 21, 15, 10, 7, 5, 5 },
                { 0, 0, 30, 21, 15, 10, 7, 5, 4, 3 },
                { 0, 30, 21, 15, 10, 7, 5, 4, 2, 2 },
                { 100, 70, 49, 34, 24, 17, 12, 8, 6, 6 }
            },
            // Dim Cave 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 20 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 5, 4 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 19, 15 },
                 { 0, 0, 0, 0, 0, 0, 5, 4, 4, 3 },
                 { 0, 0, 0, 0, 0, 20, 19, 15, 14, 12 },
                 { 0, 0, 0, 0, 10, 8, 8, 6, 6, 5 },
                 { 0, 0, 0, 5, 5, 4, 3, 3, 3, 2 },
                 { 0, 0, 20, 19, 17, 14, 13, 10, 10, 8 },
                 { 0, 20, 16, 15, 14, 11, 10, 8, 8, 6 },
                 { 100, 80, 64, 61, 55, 44, 42, 33, 32, 25 }
             },
            // Blue Lake 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 20 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 8 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 9, 7 },
                 { 0, 0, 0, 0, 0, 0, 15, 14, 12, 10 },
                 { 0, 0, 0, 0, 0, 5, 4, 4, 3, 3 },
                 { 0, 0, 0, 0, 20, 19, 16, 15, 13, 10 },
                 { 0, 0, 0, 20, 16, 15, 13, 12, 10, 8 },
                 { 0, 0, 5, 4, 3, 3, 3, 2, 2, 2 },
                 { 0, 20, 19, 15, 12, 12, 10, 9, 8, 6 },
                 { 100, 80, 76, 61, 49, 46, 39, 35, 32, 25 }
             },
            // Town Outskirts
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 20 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 20, 16 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 8, 6 },
                 { 0, 0, 0, 0, 0, 0, 20, 18, 14, 12 },
                 { 0, 0, 0, 0, 0, 20, 16, 14, 12, 9 },
                 { 0, 0, 0, 0, 20, 16, 13, 12, 9, 7 },
                 { 0, 0, 0, 10, 8, 6, 5, 5, 4, 3 },
                 { 0, 0, 20, 18, 14, 12, 9, 8, 7, 5 },
                 { 0, 20, 16, 14, 12, 9, 7, 7, 5, 4 },
                 { 100, 80, 64, 58, 46, 37, 29, 27, 21, 17 }
             },
            // Hoenn Field
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 9, 9 },
                 { 0, 0, 0, 0, 0, 0, 20, 18, 16, 15 },
                 { 0, 0, 0, 0, 0, 20, 16, 14, 13, 12 },
                 { 0, 0, 0, 0, 20, 16, 13, 12, 10, 10 },
                 { 0, 0, 0, 20, 16, 13, 10, 9, 8, 8 },
                 { 0, 0, 20, 16, 13, 10, 8, 7, 7, 6 },
                 { 0, 20, 16, 13, 10, 8, 7, 6, 5, 5 },
                 { 100, 80, 64, 51, 41, 33, 26, 24, 21, 20 }
             },
            // Warm Beach
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 5, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 19, 18 },
                 { 0, 0, 0, 0, 0, 0, 20, 16, 15, 14 },
                 { 0, 0, 0, 0, 0, 5, 4, 3, 3, 3 },
                 { 0, 0, 0, 0, 5, 5, 4, 3, 3, 3 },
                 { 0, 0, 0, 40, 38, 36, 29, 23, 22, 21 },
                 { 0, 0, 10, 6, 6, 5, 4, 3, 3, 3 },
                 { 0, 20, 18, 11, 10, 10, 8, 6, 6, 6 },
                 { 100, 80, 72, 43, 41, 39, 31, 25, 24, 23 }
             },
            // Volcano Path 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 5, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 19, 18 },
                 { 0, 0, 0, 0, 0, 0, 5, 4, 4, 4 },
                 { 0, 0, 0, 0, 0, 5, 5, 4, 4, 3 },
                 { 0, 0, 0, 0, 30, 29, 27, 22, 21, 20 },
                 { 0, 0, 0, 20, 14, 13, 13, 10, 10, 9 },
                 { 0, 0, 20, 16, 11, 11, 10, 8, 8, 7 },
                 { 0, 50, 40, 32, 22, 21, 20, 16, 15, 15 },
                 { 100, 50, 40, 32, 22, 21, 20, 16, 15, 15 }
             },
            // Treehouse
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 3, 3, 3 },
                 { 0, 0, 0, 0, 0, 0, 20, 19, 17, 17 },
                 { 0, 0, 0, 0, 0, 5, 4, 4, 3, 3 },
                 { 0, 0, 0, 0, 5, 5, 4, 4, 3, 3 },
                 { 0, 0, 0, 20, 19, 18, 14, 14, 13, 12 },
                 { 0, 0, 20, 16, 15, 14, 12, 11, 10, 10 },
                 { 0, 20, 16, 13, 12, 12, 9, 9, 8, 8 },
                 { 100, 80, 64, 51, 49, 46, 37, 36, 32, 31 }
             },
            // Scary Cave
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 5, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 5, 5, 5 },
                 { 0, 0, 0, 0, 0, 0, 20, 19, 18, 17 },
                 { 0, 0, 0, 0, 0, 20, 16, 15, 14, 14 },
                 { 0, 0, 0, 0, 5, 4, 3, 3, 3, 3 },
                 { 0, 0, 0, 20, 19, 15, 12, 12, 11, 10 },
                 { 0, 0, 20, 16, 15, 12, 10, 9, 9, 8 },
                 { 0, 20, 16, 13, 12, 10, 8, 7, 7, 7 },
                 { 100, 80, 64, 51, 49, 39, 31, 30, 28, 27 }
             },
            // Sinnoh Field
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 9 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 18, 16 },
                 { 0, 0, 0, 0, 0, 0, 20, 16, 14, 13 },
                 { 0, 0, 0, 0, 0, 20, 16, 13, 12, 10 },
                 { 0, 0, 0, 0, 20, 16, 13, 10, 9, 8 },
                 { 0, 0, 0, 20, 16, 13, 10, 8, 7, 7 },
                 { 0, 0, 20, 16, 13, 10, 8, 7, 6, 5 },
                 { 0, 20, 16, 13, 10, 8, 7, 5, 5, 4 },
                 { 100, 80, 64, 51, 41, 33, 26, 21, 19, 17 }
             },
            // Icy Mountain Rd. 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 20 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 8 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 9, 7 },
                 { 0, 0, 0, 0, 0, 0, 5, 5, 4, 3 },
                 { 0, 0, 0, 0, 0, 5, 5, 4, 4, 3 },
                 { 0, 0, 0, 0, 5, 5, 5, 4, 4, 3 },
                 { 0, 0, 0, 5, 5, 5, 4, 4, 3, 3 },
                 { 0, 0, 30, 29, 27, 26, 24, 22, 20, 16 },
                 { 0, 40, 28, 27, 25, 24, 23, 21, 18, 15 },
                 { 100, 60, 42, 40, 38, 36, 34, 31, 28, 22 }
             },
            // Big Forest 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 9 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 9, 8 },
                 { 0, 0, 0, 0, 0, 0, 20, 18, 16, 15 },
                 { 0, 0, 0, 0, 0, 50, 40, 36, 32, 29 },
                 { 0, 0, 0, 0, 20, 10, 8, 7, 6, 6 },
                 { 0, 0, 0, 20, 16, 8, 6, 6, 5, 5 },
                 { 0, 0, 20, 16, 13, 6, 5, 5, 4, 4 },
                 { 0, 20, 16, 13, 10, 5, 4, 4, 3, 3 },
                 { 100, 80, 64, 51, 41, 20, 16, 15, 13, 12 }
             },
            // White Lake
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 9, 9 },
                 { 0, 0, 0, 0, 0, 0, 20, 18, 16, 16 },
                 { 0, 0, 0, 0, 0, 20, 16, 14, 13, 13 },
                 { 0, 0, 0, 0, 20, 16, 13, 12, 10, 10 },
                 { 0, 0, 0, 20, 16, 13, 10, 9, 8, 8 },
                 { 0, 0, 20, 16, 13, 10, 8, 7, 7, 7 },
                 { 0, 20, 16, 13, 10, 8, 7, 6, 5, 5 },
                 { 100, 80, 64, 51, 41, 33, 26, 24, 21, 21 }
             },
            // Stormy Beach 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 9 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 9, 8 },
                 { 0, 0, 0, 0, 0, 0, 10, 9, 8, 7 },
                 { 0, 0, 0, 0, 0, 10, 9, 8, 7, 7 },
                 { 0, 0, 0, 0, 10, 9, 8, 7, 7, 6 },
                 { 0, 0, 0, 20, 18, 16, 15, 13, 12, 11 },
                 { 0, 0, 20, 16, 14, 13, 12, 10, 9, 9 },
                 { 0, 40, 32, 26, 23, 21, 19, 17, 15, 14 },
                 { 100, 60, 48, 38, 35, 31, 28, 25, 23, 20 }
             },
            // Resort 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 9 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 18, 16 },
                 { 0, 0, 0, 0, 0, 0, 20, 16, 14, 13 },
                 { 0, 0, 0, 0, 0, 5, 4, 3, 3, 3 },
                 { 0, 0, 0, 0, 20, 19, 15, 12, 11, 10 },
                 { 0, 0, 0, 5, 4, 4, 3, 2, 2, 2 },
                 { 0, 0, 5, 5, 4, 4, 3, 2, 2, 2 },
                 { 0, 20, 19, 18, 14, 14, 11, 9, 8, 7 },
                 { 100, 80, 76, 72, 58, 55, 44, 35, 32, 28 }
             },
            // Quiet Cave 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 5, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 19, 19 },
                 { 0, 0, 0, 0, 0, 0, 5, 4, 4, 4 },
                 { 0, 0, 0, 0, 0, 10, 10, 8, 7, 7 },
                 { 0, 0, 0, 0, 30, 27, 26, 21, 19, 19 },
                 { 0, 0, 0, 20, 14, 13, 12, 10, 9, 9 },
                 { 0, 0, 20, 16, 11, 10, 10, 8, 7, 7 },
                 { 0, 20, 16, 13, 9, 8, 8, 6, 6, 6 },
                 { 100, 80, 64, 51, 36, 32, 31, 25, 23, 23 }
             },
            // Beyond the Sea
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 20 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 20, 16 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 16, 13 },
                 { 0, 0, 0, 0, 0, 0, 20, 16, 13, 10 },
                 { 0, 0, 0, 0, 0, 20, 16, 13, 10, 8 },
                 { 0, 0, 0, 0, 20, 16, 13, 10, 8, 7 },
                 { 0, 0, 0, 20, 16, 13, 10, 8, 7, 5 },
                 { 0, 0, 20, 16, 13, 10, 8, 7, 5, 4 },
                 { 0, 20, 16, 13, 10, 8, 7, 5, 4, 3 },
                 { 100, 80, 64, 51, 41, 33, 26, 21, 17, 13 }
             },
            // Night Skys Edge 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 30, 30 },
                 { 0, 0, 0, 0, 0, 0, 0, 20, 14, 14 },
                 { 0, 0, 0, 0, 0, 0, 20, 16, 11, 11 },
                 { 0, 0, 0, 0, 0, 20, 16, 13, 9, 9 },
                 { 0, 0, 0, 0, 20, 16, 13, 10, 7, 7 },
                 { 0, 0, 0, 20, 16, 13, 10, 8, 6, 6 },
                 { 0, 0, 20, 16, 13, 10, 8, 7, 5, 5 },
                 { 0, 10, 8, 6, 5, 4, 3, 3, 2, 2 },
                 { 100, 90, 72, 58, 46, 37, 29, 24, 17, 16 }
             },
            // Yellow Forest 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 3 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 5, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 10, 9 },
                 { 0, 0, 0, 0, 0, 0, 10, 9, 9, 8 },
                 { 0, 0, 0, 0, 0, 40, 36, 32, 31, 30 },
                 { 0, 0, 0, 0, 40, 24, 22, 19, 18, 18 },
                 { 0, 0, 0, 50, 30, 18, 16, 15, 14, 13 },
                 { 0, 0, 50, 25, 15, 9, 8, 7, 7, 7 },
                 { 0, 50, 25, 13, 8, 5, 4, 4, 3, 3 },
                 { 100, 50, 25, 13, 8, 4, 4, 4, 3, 3 }
             },
            // Rally 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 5, 5, 4 },
                 { 0, 0, 0, 0, 0, 0, 20, 19, 17, 16 },
                 { 0, 0, 0, 0, 0, 30, 24, 23, 21, 19 },
                 { 0, 0, 0, 0, 70, 49, 39, 37, 34, 32 },
                 { 0, 0, 0, 40, 12, 8, 7, 6, 6, 5 },
                 { 0, 0, 40, 24, 7, 5, 4, 4, 3, 3 },
                 { 0, 40, 24, 14, 4, 3, 2, 2, 2, 2 },
                 { 100, 60, 36, 22, 6, 5, 4, 3, 3, 3 }
             },
            // Sightseeing 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 10 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 10, 9 },
                 { 0, 0, 0, 0, 0, 0, 0, 15, 14, 12 },
                 { 0, 0, 0, 0, 0, 0, 15, 13, 11, 10 },
                 { 0, 0, 0, 0, 0, 30, 26, 22, 20, 18 },
                 { 0, 0, 0, 0, 30, 21, 18, 15, 14, 12 },
                 { 0, 0, 0, 35, 25, 17, 15, 12, 11, 10 },
                 { 0, 0, 35, 23, 16, 11, 9, 8, 7, 7 },
                 { 0, 50, 33, 21, 15, 10, 9, 7, 7, 6 },
                 { 100, 50, 33, 21, 15, 10, 9, 7, 7, 6 }
             },
            // Winner’s Path 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 3 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 3, 3 },
                 { 0, 0, 0, 0, 0, 0, 0, 3, 3, 3 },
                 { 0, 0, 0, 0, 0, 0, 3, 3, 3, 3 },
                 { 0, 0, 0, 0, 0, 3, 3, 3, 3, 3 },
                 { 0, 0, 0, 0, 3, 3, 3, 3, 3, 3 },
                 { 0, 0, 0, 20, 19, 19, 18, 18, 17, 17 },
                 { 0, 0, 20, 16, 16, 15, 15, 14, 14, 13 },
                 { 0, 50, 40, 32, 31, 30, 29, 28, 27, 27 },
                 { 100, 50, 40, 32, 31, 30, 29, 28, 27, 27 }
             },
            // Amity Meadow 
             new double[10,10] {
                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 0, 5, 5 },
                 { 0, 0, 0, 0, 0, 0, 0, 10, 10, 9 },
                 { 0, 0, 0, 0, 0, 0, 10, 9, 9, 8 },
                 { 0, 0, 0, 0, 0, 10, 9, 8, 8, 7 },
                 { 0, 0, 0, 0, 50, 45, 41, 36, 35, 33 },
                 { 0, 0, 0, 50, 25, 23, 20, 18, 17, 16 },
                 { 0, 0, 60, 30, 15, 14, 12, 11, 10, 10 },
                 { 0, 70, 28, 14, 7, 6, 6, 5, 5, 5 },
                 { 100, 30, 12, 6, 3, 3, 2, 2, 2, 2 }
             }
            
        };
    }
}
