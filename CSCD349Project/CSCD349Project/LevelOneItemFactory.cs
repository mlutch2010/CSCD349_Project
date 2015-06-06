using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class LevelOneItemFactory : AbstractItemFactory
    {
        private static Random rand;
        public LevelOneItemFactory() 
        {
            rand = new Random();
        }
        public override GameItem GetRandomItem()
        {
            int choice = rand.Next(18);
            if(choice < 5)
            {
                return new SmallHealthPotion();
            }
            else if (choice < 10)
            {
                return new SmallEnergyPotion();
            }
            else if (choice < 13)
            {
                return new MediumHealthPotion();
            }
            else if (choice < 16)
            {
                return new MediumEnergyPotion();
            }
            else if (choice == 16)
            {
                return new LargeHealthPotion();
            }
            else
            {
                return new LargeEnergyPotion();
            }
        }
    }
}
