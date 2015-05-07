namespace CSCD349Project
{
    public sealed class Cell
    {
        private Map _MyMap;
        private int[] _coordinates;

        public Map _myMap
        {
            get { return _MyMap; }
        }

        public Cell(int[] coordinates, Map thisMap)
        {
            _MyMap = thisMap;
            _coordinates = coordinates;
        }
        public override string ToString()
        {
            string output = "\n";
            output += "#--------- Cell ---------#\n";
            output += "coordinates: (" + _coordinates[0] + ", " + _coordinates[1] + ")\n";
            output += "#------------------------#\n";
            return output;
        }
    }
}