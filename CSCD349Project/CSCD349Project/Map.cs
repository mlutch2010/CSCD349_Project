using System;
using System.IO;
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
        private AbstractEnemyFactory _EnemyFactory;
        private AbstractItemFactory _ItemFactory;

        public Map(int[] dimensions, int[] startCoordinates, int[] finishCoordinates, AbstractEnemyFactory enemyFactory, AbstractItemFactory itemFactory)
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
            _EnemyFactory = enemyFactory;
            _ItemFactory = itemFactory;

            //Set start, finish, and active cells
            _StartCell = _Cells[startCoordinates[0], startCoordinates[1]];
            _FinishCell = _Cells[finishCoordinates[0], finishCoordinates[1]];
            _ActiveCell = _StartCell;
        }

        //Build a map from file
        //CONSIDER MAKING THIS A CLASS
        public Map(string path)
        {
            Map thisMap = null;
            Cell[,] cells;
            int noRows = 0;
            int noCols = 0;
            char tCellCode, ntCellCode;//t => traversable, nt => non-traversable

            // read in a map from a map file
            try
            {
                // get dimensions
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = "";
                    char[] lineChars;



                    //Read in dimensions
                    if ((line = sr.ReadLine()) != null)
                        noRows = Convert.ToInt32(line);

                    if ((line = sr.ReadLine()) != null)
                        noCols = Convert.ToInt32(line);

                    //Read in legend
                    //noRows = String.ToCharArray(line);


                    //Read in map
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //thisMap = new Map(new int[] { noRows, noCols });
            return thisMap;
        }

        public void GenerateLevel()
        {
            for (int i = 0; i < _Dimensions[0]-1; ++i)
            {
                for(int j = 0; j < _Dimensions[1]-1; ++j)
                {
                    _Cells[i, j].GenerateEnemies();
                    _Cells[i, j].GenerateItems();
                }
            }
        }
        public Cell GetCellAt(int row, int column)
        {
            return _Cells[row, column];
        }
        
        public AbstractEnemyFactory GetEnemyFactory()
        {
            return _EnemyFactory;
        }

        public AbstractItemFactory GetItemFactory()
        {
            return _ItemFactory;
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
