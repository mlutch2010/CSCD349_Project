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

            myAttributes._basehealth = 90;
            myAttributes._health = 90;
            myAttributes._baseEnergy = 20;
            myAttributes._energy = 20;
            myAttributes._power = 1;
            myAttributes._armor = 1;
            myAttributes.SetIsGoodGuy(false);

            SetAttributes(myAttributes);

            //Add the abilities this concrete GameCharacter has by default
            base.GetAttributes().AddAttack(new LeprachaunThrowGold());
            base.GetAttributes().AddDefense(new LeprachaunDisappear());
        }
    }
}