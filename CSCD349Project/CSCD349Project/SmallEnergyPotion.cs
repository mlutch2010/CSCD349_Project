using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class SmallEnergyPotion : GameItem
    {
        public SmallEnergyPotion()
        {
            _name = "Small Energy Potion";
            _description = "A potion that restores 50 energy points.";
        }

        public override void Use(GameCharacter character)
        {
            character.GetAttributes()._energy += 50;
            Console.WriteLine("The potion restored 50 energy points!");
        }
    }
}
