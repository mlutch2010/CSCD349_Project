namespace CSCD349Project
{
    public sealed class Cell
    {
        private Map _MyMap;
        private int[] _Coordinates;
        private bool _Traversable;
        private Party _Enemies;
        /*
        private bool _IsStart;
        private bool _IsFinish;

        public bool _isStart
        {
            get { return _IsStart; }
            set { _IsStart = _isStart; }
        }

        public bool _isFinish
        {
            get { return _IsFinish; }
            set { _IsFinish = _isFinish; }
        }
         * */

        public Cell(int[] coordinates, Map thisMap)
        {
            _MyMap = thisMap;
            _Coordinates = coordinates;
            _Traversable = true;
            _Enemies = new Party("Enemies", this);
        }
        
        public Party _enemies
        {
            get {return _Enemies;}
        }

        public bool _traversable
        {
            get { return _Traversable; }
        }
        public Map _myMap
        {
            get { return _MyMap; }
        }
        
        //This method takes a random number from a generator and determines the number
        //of enemies that will be in the cell. Currently the range is from 0-4. Then
        //it uses the Map's specific GameEnemyFactory to fill the party with random enemies.
        //(Sorry, I know it looks a little bloated :( )
        public void GenerateEnemies()
        {
            Random rnd = new Random();
            int choice = rnd.Next(12);
            if(choice <= 3)
            {
                //Empty party, no added enemies.
            }
            else if (choice > 3 && choice <= 6)
            {
                _Enemies.AddCharacter(_MyMap.GetFactory().GetRandomGameCharacter());
            }
            else if (choice > 6  || choice <= 9)
            {
                for(int i = 0; i < 2; i++)
                {
                    _Enemies.AddCharacter(_MyMap.GetFactory().GetRandomGameCharacter());
                }
            }
            else if (choice == 10)
            {
                for (int i = 0; i < 3; i++)
                {
                    _Enemies.AddCharacter(_MyMap.GetFactory().GetRandomGameCharacter());
                }
            }
            else
            {
                for(int i = 0; i < 4; i++)
                {
                    _Enemies.AddCharacter(_MyMap.GetFactory().GetRandomGameCharacter());
                }
            }
        }

        
        public override string ToString()
        {
            string output = "\n";
            output += "#--------- Cell ---------#\n";
            output += "coordinates: (" + _Coordinates[0] + ", " + _Coordinates[1] + ")\n";
            output += "#------------------------#\n";
            return output;
        }
    }
}
