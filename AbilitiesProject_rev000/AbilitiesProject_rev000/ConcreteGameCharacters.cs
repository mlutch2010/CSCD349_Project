using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCD349Project
{
    public class Warrior: GameCharacter
    {
        public Warrior() : base("Warrior")
        {
            CharacterAttributes myAttributes = new CharacterAttributes();
            myAttributes._basehealth = 10;
            myAttributes._health     = 10;
            myAttributes._baseEnergy = 25;
            myAttributes._energy     = 25;
            myAttributes._basePower  = 5;
            myAttributes._power      = 5;
            myAttributes.SetIsGoodGuy(true);
            myAttributes.SetActiveAttack(new WarriorSlash());
        }
    }
    
}
