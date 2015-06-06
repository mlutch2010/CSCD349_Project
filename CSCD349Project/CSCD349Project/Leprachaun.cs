using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class Leprachaun : GameCharacter
    {
        public Leprachaun()
            : base("Leprachaun")
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