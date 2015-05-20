using System.Collections.Generic;
namespace CSCD349Project
{
    public class Party
    {
        private Cell _OccupiedCell { get; set; }
        private string _Name;
        private List<GameCharacter> _Characters;
        private List<GameItem> _Inventory;

        public Party(string name, Cell cell)
        {
            _Name = name;
            _OccupiedCell = cell;
            _Characters = new List<GameCharacter>();
            _Inventory  = new List<GameItem>();
        }

        public List<GameItem> GetIventory() { return _Inventory; }
        public List<GameCharacter> GetCharacters() { return _Characters; }
        public string GetName() { return _Name; }        
        public int AddCharacter(GameCharacter character)
        {
            _Characters.Add(character);
            return _Characters.Count;
        }

        public bool RemoveCharacter(GameCharacter character)
        {
            return _Characters.Remove(character);
        }
        
        public override string ToString()
        {
            string output = "\n";
            output += "#--------- party ---------#\n";
            output += "cell: \n"     + _OccupiedCell.ToString() + "\n";
            output += "characters: " + string.Join("\n", (object[])_Characters.ToArray());
            output += "#------------------------#\n";
            return output;
        }
    }
}
