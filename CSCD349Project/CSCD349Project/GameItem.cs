namespace CSCD349Project
{
    public abstract class GameItem
    {
        private string _Description;
        public string _description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public GameItem()
        {
        }
        //Use method uses the given item on the current character.
        public abstract void Use(GameCharacter character);
    }
}
