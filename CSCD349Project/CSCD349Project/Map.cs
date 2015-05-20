using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCD349Project
{
    public sealed class Map
    {
        private int[] _Dimensions;
        private Cell[,] _Cells;
        public Map(int[] dimensions)
        {
            _Cells = new Cell[dimensions[0],dimensions[1]];
            _Dimensions = dimensions;
            int r,c;
            for(r = 0; r < dimensions[0] - 1; ++r)
            {
                for(c = 0; c < dimensions[1] - 1; ++c)
                {
                    _Cells[r, c] = new Cell(new int[] { r, c }, this);
                }
            }
        }
        public void GenerateLevel(){}
        public Cell GetCellAt(int row, int column)
        {
            return _Cells[row, column];
        }
         
    }
}
