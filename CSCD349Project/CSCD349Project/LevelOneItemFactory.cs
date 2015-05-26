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
            return new SmallHealthPotion();
        }
    }
}
