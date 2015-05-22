using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCD349Project
{
    public class LandShark : GameCharacter
    {
        public LandShark() 
            : base("Land Shark")
        {
            CharacterAttributes myAttributes = new CharacterAttributes();

            myAttributes._basehealth = 100;
            myAttributes._health = 100;
            myAttributes._baseEnergy = 20;
            myAttributes._energy = 20;
            myAttributes._power = 1;
            myAttributes._armor = 1;
            myAttributes.SetIsGoodGuy(false);

            SetAttributes(myAttributes);

            //Add the abilities this concrete GameCharacter has by default
            base.GetAttributes().AddAttack(new LandSharkChomp());
            base.GetAttributes().AddDefense(new LandSharkEvade());
        }
    }
}