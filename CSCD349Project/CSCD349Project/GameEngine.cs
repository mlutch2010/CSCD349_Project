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
        private Messaging _messaging;
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
            _messaging = new Messaging();
            GameCharacter.SetMessaging(_messaging);
            
            // create the maps
            for (int i = 0; i < noLevels; ++i)
                _Maps.Add(new Map(CSCD349Project.Properties.Resources.level0));

            GameCharacter warrior = new Warrior();
            GameCharacter mage = new Mage();
            GameCharacter scout = new Scout();
            
            GameCharacter landShark = new LandShark();
            GameCharacter gargoyle = new Gargoyle();
            GameCharacter leprachaun = new Leprachaun();

            warrior.GetAttributes().SetActiveAttack(warrior.GetAttributes().GetAttacks()[0]);
            mage.GetAttributes().SetActiveAttack(mage.GetAttributes().GetAttacks()[0]);
            scout.GetAttributes().SetActiveAttack(scout.GetAttributes().GetAttacks()[0]);
            landShark.GetAttributes().SetActiveAttack(landShark.GetAttributes().GetAttacks()[0]);
            gargoyle.GetAttributes().SetActiveAttack(gargoyle.GetAttributes().GetAttacks()[0]);
            leprachaun.GetAttributes().SetActiveAttack(leprachaun.GetAttributes().GetAttacks()[0]);

            warrior.GetAttributes().SetActiveDefense(warrior.GetAttributes().GetDefenses()[0]);
            mage.GetAttributes().SetActiveDefense(mage.GetAttributes().GetDefenses()[0]);
            scout.GetAttributes().SetActiveDefense(scout.GetAttributes().GetDefenses()[0]);
            landShark.GetAttributes().SetActiveDefense(landShark.GetAttributes().GetDefenses()[0]);
            gargoyle.GetAttributes().SetActiveDefense(gargoyle.GetAttributes().GetDefenses()[0]);
            leprachaun.GetAttributes().SetActiveDefense(leprachaun.GetAttributes().GetDefenses()[0]);




            warrior.PerformActiveAttack(landShark);
            mage.PerformActiveAttack(gargoyle);
            scout.PerformActiveAttack(leprachaun);

            landShark.PerformActiveAttack(warrior);
            gargoyle.PerformActiveAttack(mage);
            leprachaun.PerformActiveAttack(scout);



            PrintArray(_messaging.getLatestMessages());


        }


        public void PrintArray(string[] array)
        {
            foreach (string thisLine in (new List<string>(array)))
                Console.WriteLine(thisLine);

        }




        private void  Initialize()
        {
            // Read in and set up maps
            Console.WriteLine(_Maps[0]);
                // Set up cells in maps
                // Randomly generate items and enemy parties in the map

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
