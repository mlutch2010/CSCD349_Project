using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD349Project
{
    class Gargoyle: GameCharacter
    {
        public Gargoyle(): base("Gargoyle")
        {
            CharacterAttributes myAttributes = new CharacterAttributes();

            myAttributes._basehealth = 120;
            myAttributes._health = 120;
            myAttributes._baseEnergy = 50;
            myAttributes._energy = 50;
            myAttributes._power = 1;
            myAttributes._armor = 1;
            myAttributes.SetIsGoodGuy(false);

            SetAttributes(myAttributes);

            //Add the abilities this concrete GameCharacter has by default
            base.GetAttributes().AddAttack(new GargoyleStare());
            base.GetAttributes().AddDefense(new GargoyleFreeze());
        }
    }
}
