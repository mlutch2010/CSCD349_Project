using System;
namespace CSCD349Project
{
public abstract class GameCharacter : GameObject, IComparable<GameCharacter>
    {
        private static int noInstances = 0;
        private int _ID;
        private CharacterAttributes _Attributes;
        private Party _Party; 
 
        public GameCharacter(string name) : base(name)
        {
            _ID = noInstances ++;
        }
       
        // This constructor is used to create a GamaCharacter instance with a particular id for the purposes 
        // of searching for a character in a list.
        public GameCharacter(int id) : base(""){_ID = id;}
    
        public void PerformAbility() { }

        public int CompareTo(GameCharacter other)
        {
 	        return _ID - other._ID;
        }

        public CharacterAttributes GetAttributes()
        {
            return _Attributes;
        }

        public void SetAttributes(CharacterAttributes attributes)
        {
            if(attributes != null)
                _Attributes = attributes;
        }

        public override string ToString()
        {
            string output = "----- Game Character    id:" + _ID  + "-----\n";
            output += "name:" + GetName() + "\n";
            output += (_Attributes.GetIsGoodGuy()) ? "goodguy\n" : "badguy";
            output += "health: " + _Attributes._health + "\n";
            output += "energy: " + _Attributes._energy + "\n";
            output += "power: "  + _Attributes._power + "\n";
            output += "armor: "  + _Attributes._armor + "\n";
            output += "----------------------------------------------------\n";
            
            return output;
        }
    }
}