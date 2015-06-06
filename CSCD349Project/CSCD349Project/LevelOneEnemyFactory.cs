using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class LevelOneEnemyFactory : AbstractEnemyFactory
    {
        private static Random rand;
        public LevelOneEnemyFactory()
        { 
            rand = new Random();
        }

        override public GameCharacter GetRandomGameCharacter()
        {
            int choice = rand.Next(3);
            if(choice == 0)
            {
                return new LandShark();
            }
            else if (choice == 1)
            {
                return new Leprachaun();
            }
            else
            {
                return new Gargoyle();
            }
        }
    }
}
