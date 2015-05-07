using System.Collections.Generic;
namespace CSCD349Project
{
    public class Party
    {
        private Cell _occupiedCell { get; set; }
        private string _name;
        private List<GameCharacter> _Characters;
        public List<GameCharacter> _characters
        {
            get{return _Characters;}
        }
 
        public Party(string name, Cell cell)
        {
            _name = name;
            _occupiedCell = cell;
            _Characters = new List<GameCharacter>();
        }

        public int AddPlayer(GameCharacter newCharacter)
        {
            _characters.Add(newCharacter);
            return _characters.Count;
        }
        
        public bool removePlayer(GameCharacter character)
        {
            return _Characters.Remove(character);
        }
        
        public override string ToString()
        {
            string output = "\n";
            output += "#--------- party ---------#\n";
            output += _occupiedCell.ToString();
            output += "#------------------------#\n";
            return output;
        }
    }
}
