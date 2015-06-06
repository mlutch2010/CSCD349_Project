using System;
using System.IO;
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
        private List<Map> _Maps;

        public static void Main(string[]args)
        {
            GameEngine thisGame = new GameEngine();
            thisGame.Initialize();
            //thisGame.Run();

            Console.ReadKey();
        }

        public GameEngine()
        {
            _Maps = new List<Map>();

            // create the maps
            for (int i = 0; i < noLevels; ++i)
                _Maps.Add(new Map(CSCD349Project.Properties.Resources.level0));
        }

        private void  Initialize()
        {
            // Read in and set up maps
            //Console.WriteLine(_Maps[0]);
            
            // Randomly generate items and enemy parties in the map
            _Maps[0].PopulateMap();

            Console.WriteLine(_Maps[0]);

            // Place good party in map (active cell)

            //end
        }



        private void Run()
        {
            if (currentLevel < noLevels)
            {
                Map thisLevel = _Maps[currentLevel - 1];
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

    
        public void ShowErrorMessage(string message)
        {
            //MessageBox.Show(message);
        }
    }
}
