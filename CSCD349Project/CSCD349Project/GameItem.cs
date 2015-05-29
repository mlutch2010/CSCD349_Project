namespace CSCD349Project
{
    public abstract class GameItem
    {
        private string _Description;
        private string _Name;
        public string _description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string _name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public GameItem()
        {
        }
        //Use method uses the given item on the current character.
        public abstract void Use(GameCharacter character);
    }
}
