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
          //  myAttributes._basePower  = 5;
            myAttributes._power      = 5;
            myAttributes.SetIsGoodGuy(true);
            myAttributes.AddAttack(new WarriorSlash());// Shouldn't have an active attack upon creation

            SetAttributes(myAttributes);

            //Add the abilities this concrete GameCharacter has by default
            base.GetAttributes().AddAttack(new WarriorSlash());
            base.GetAttributes().AddDefense(new WarriorLiftShield());
        }
    }
}