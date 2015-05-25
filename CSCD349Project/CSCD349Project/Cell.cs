namespace CSCD349Project
{
    public sealed class Cell
    {
        private Map _MyMap;
        private int[] _Coordinates;
        private bool _Traversable;
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
        }

        public bool _traversable
        {
            get { return _Traversable; }
        }
        public Map _myMap
        {
            get { return _MyMap; }
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