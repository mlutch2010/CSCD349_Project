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

            myAttributes._baseXP = new int[]{10, 20, 30, 40};
            myAttributes._basehealth = 100;
            myAttributes._health     = 100;
            myAttributes._baseEnergy = 50;
            myAttributes._energy     = 50;
            myAttributes._power      = 1;
            myAttributes._armor      = 1;
            myAttributes.SetIsGoodGuy(true);

            SetAttributes(myAttributes);

            //Add the abilities this concrete GameCharacter has by default
            base.GetAttributes().AddAttack(new WarriorSlash());
            base.GetAttributes().AddDefense(new WarriorLiftShield());
        }
    }
}