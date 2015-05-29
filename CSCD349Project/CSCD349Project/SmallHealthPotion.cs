//SmallHealthPotion.cs
//Audrey Henry

using System;

namespace CSCD349Project
{
    public class SmallHealthPotion : GameItem
    {
        //Default constructor for SmallHealthPotion
        public SmallHealthPotion()
        {
            _name = "Small Health Potion";
            _description = "A potion that heals 50 health.";
        }

        public override void Use(GameCharacter character)
        {
            //We can adjust the values to achieve a better balance. AH
            character.GetAttributes()._health += 50.0;
            //Test text
            Console.WriteLine("The potion healed 50 health!");

        }
    }
}
