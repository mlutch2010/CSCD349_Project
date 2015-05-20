namespace CSCD349Project
{
    public sealed class Cell
    {
        private Map _MyMap;
        private int[] _Coordinates;

        public Map _myMap
        {
            get { return _MyMap; }
        }

        public Cell(int[] coordinates, Map thisMap)
        {
            _MyMap = thisMap;
            _Coordinates = coordinates;
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