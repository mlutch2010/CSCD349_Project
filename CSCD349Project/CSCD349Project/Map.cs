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
        private Cell _StartCell, _FinishCell, _ActiveCell;

        public Map(int[] dimensions, int[] startCoordinates, int[] finishCoordinates)
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

            //Set start, finish, and active cells
            _StartCell = _Cells[startCoordinates[0], startCoordinates[1]];
            _FinishCell = _Cells[finishCoordinates[0], finishCoordinates[1]];
            _ActiveCell = _StartCell;
        }

        public void GenerateLevel(){}
        public Cell GetCellAt(int row, int column)
        {
            return _Cells[row, column];
        }

        public Cell _startCell
        {
            get { return _StartCell; }
        }
        public Cell _finishCell
        {
            get { return _FinishCell; }
        }
        public Cell _activeCell
        {
            get { return _ActiveCell; }
        }


        public override string ToString()
        {
            string output = "";
            int r, c;
            for (r = 0; r < _Dimensions[0] - 1; ++r)
            {
                for (c = 0; c < _Dimensions[1] - 1; ++c)
                {
                    //_Cells[r, c] = new Cell(new int[] { r, c }, this);
                    if(_Cells[r,c] == _StartCell)
                        output += "S";
                    else if(_Cells[r,c] == _FinishCell)
                        output += "F";
                    else if (_Cells[r, c] == _ActiveCell)
                        output += "X";
                    else
                    {
                        if (_Cells[r, c]._traversable)
                            output += "+";
                        else
                            output += "-";
                    }
                }
                output += "\n";
            }

            return output;
        }
    }
}