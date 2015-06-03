using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class LevelOneEnemyFactory : AbstractEnemyFactory
    {
        public LevelOneEnemyFactory()
        { }

        override public GameCharacter GetRandomGameCharacter()
        {
            Random rnd = new Random();
            int choice = rnd.Next(3);
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
