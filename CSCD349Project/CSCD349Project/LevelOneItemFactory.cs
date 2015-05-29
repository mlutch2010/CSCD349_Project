using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class LevelOneItemFactory : AbstractItemFactory
    {
        public LevelOneItemFactory() { }
        public override GameItem GetRandomItem()
        {
            Random rnd = new Random();
            int choice = rnd.Next(2);
            if(choice == 0)
            {
                return new SmallHealthPotion();
            }
            else
            {
                return new SmallEnergyPotion();
            }
        }
    }
}
