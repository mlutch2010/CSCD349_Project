using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Forms;

namespace CSCD349Project
{

    class GameEngine
    {
        private int noLevels = 1;
        private int currentLevel = 1;
        private List<Map> maps;

        public static void Main(string[]args)
        {
            //GameEngine thisGame = new GameEngine();

            //thisGame.Initialize();
            //thisGame.Run();
        }

        public GameEngine()
        {
            maps = new List<Map>();

            // create the maps
            for (int i = 0; i < noLevels; ++i)
                maps.Add(ReadMapFile("levelData\\level" + i + ".map"));
        }

        private void  Initialize()
        {
            // Read in and set up maps
                // Set up cells in maps
                // Randomly generate items and enemy parties in the map

            // Place good party in map (active cell)

            //end
        }



        private void Run()
        {
            if (currentLevel < noLevels)
            {
                Map thisLevel = maps[currentLevel - 1];
                Cell thisCell;

                // If active cell is finish then display victory message and move to next map
                thisCell = thisLevel._activeCell;

                // Start NavigateMap()
                // If there is an enemy in the active cell's enemy party
                    // Start Combat()
            }
            else
            {
                //Awesome victory message (YOU HAVE WON THE GAME!!!)
            }
        }

        public Map ReadMapFile(string path)
        {
            Map thisMap = null;
            Cell[,] cells;
            int noRows = 0;
            int noCols = 0;
            
            // read in a map from a map file
            try
            {
                // get dimensions
                

            }
            catch (Exception e)
            {

            }
            //thisMap = new Map(new int[] { noRows, noCols });
            return thisMap;
        }
    
    
    
        public void ShowErrorMessage(string message)
        {
            //MessageBox.Show(message);
        }
    
    }
}
