using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CSCD349Project
{

    class GameEngine
    {
        private int noLevels = 1;
        private List<Map> maps;

        public static void Main(string[]args)
        {
            GameEngine thisGame = new GameEngine();
            thisGame.Begin();
        }

        public GameEngine()
        {
            maps = new List<Map>();
            // create the maps
            for (int i = 0; i < noLevels; ++i)
                maps.Add(readMapFile("level" + i + ".map"));

        }

        public void  Begin()
        {
            
        }

        public Map readMapFile(string path)
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
            thisMap = new Map(new int[] { noRows, noCols }); 
            return thisMap;
        }
    
    
    
        public void showErrorMessage(string message)
        {
            MessageBox.Show(message);
        }
    
    }
}
