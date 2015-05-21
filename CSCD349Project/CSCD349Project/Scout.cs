using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCD349Project
{
    public class Scout : GameCharacter
    {
        public Scout()
            : base("Scout")
        {
            CharacterAttributes myAttributes = new CharacterAttributes();

            myAttributes._baseXP = new int[] { 10, 20, 30, 40 };
            myAttributes._basehealth = 50;
            myAttributes._health = 50;
            myAttributes._baseEnergy = 20;
            myAttributes._energy = 20;
            myAttributes._power = 1;
            myAttributes.SetIsGoodGuy(true);

            SetAttributes(myAttributes);

            //Add the abilities this concrete GameCharacter has by default
            base.GetAttributes().AddAttack(new ScoutShootPlainArrow());
            //base.GetAttributes().AddDefense(new WarriorLiftShield());
        }
    }
}