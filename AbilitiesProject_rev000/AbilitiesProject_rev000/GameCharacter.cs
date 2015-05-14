using System;
namespace CSCD349Project
{
public abstract class GameCharacter : GameObject, IComparable<GameCharacter>
    {
        private static int noInstances = 0;
        private int _id;
        private CharacterAttributes _attributes;
        private Party _party; 
 
        public GameCharacter(string name) : base(name)
        {
            _id = noInstances ++;
        }
       
        // This constructor is used to create a GamaCharacter instance with a particular id for the purposes 
        // of searching for a character in a list.
        public GameCharacter(int id) : base(""){_id = id;}
    
        public void PerformAbility() { }

        public int CompareTo(GameCharacter other)
        {
 	        return _id - other._id;
        }

        public CharacterAttributes getAttributes()
        {
            return _attributes;
        }

        public void setAttributes(CharacterAttributes attributes)
        {
            if(attributes != null)
                _attributes = attributes;
        }

        public override string ToString()
        {

            string output = "----- Game Character    id:" + _id  + "-----\n";
            output += "name:" + GetName() + "\n";
            output += (_attributes.GetIsGoodGuy()) ? "goodguy\n" : "badguy";
            output += _attributes._health + "\n";
            output += _attributes._energy + "\n";
            output += _attributes._power + "\n";
            output += _attributes._armor + "\n";
            return output;
        }
    }
}