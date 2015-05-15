using System.Collections.Generic;
namespace CSCD349Project
{
    public class Party
    {
        private Cell _occupiedCell { get; set; }
        private string _name;
        private List<GameCharacter> _characters;
        private List<GameItem> _inventory;

        public Party(string name, Cell cell)
        {
            _name = name;
            _occupiedCell = cell;
            _characters = new List<GameCharacter>();
            _inventory  = new List<GameItem>();
        }

        public List<GameItem> GetIventory() { return _inventory; }
        public List<GameCharacter> GetCharacters() { return _characters; }
        public string GetName() { return _name; }
        
        public int AddCharacter(GameCharacter character)
        {
            _characters.Add(character);
            return _characters.Count;
        }
        
        public bool removeCharacter(GameCharacter character)
        {
            return _characters.Remove(character);
        }
        
        public override string ToString()
        {
            string output = "\n";
            output += "#--------- party ---------#\n";
            output += "cell: \n"     + _occupiedCell.ToString() + "\n";
            output += "characters: " + string.Join("\n", (object[])_characters.ToArray());
            output += "#------------------------#\n";
            return output;
        }
    }
}
