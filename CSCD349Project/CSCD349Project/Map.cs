using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCD349Project
{
    public sealed class Map
    {
        private int[] _dimensions;
        private Cell[,] _cells;
        public Map(int[] dimensions)
        {
            _cells = new Cell[dimensions[0],dimensions[1]];
            _dimensions = dimensions;
            int r,c;
            for(r = 0; r < dimensions[0] - 1; ++r)
            {
                for(c = 0; c < dimensions[1] - 1; ++c)
                {
                    _cells[r, c] = new Cell(new int[] { r, c }, this);
                }
            }
        }
        public void GenerateLevel(){}
        public Cell GetCellAt(int row, int column)
        {
            return _cells[row, column];
        }
         
    }
}
