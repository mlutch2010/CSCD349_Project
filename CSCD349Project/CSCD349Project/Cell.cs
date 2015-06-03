using System;
using System.Collections.Generic;

﻿namespace CSCD349Project
{
    public sealed class Cell
    {
        private Map _MyMap;
        private int[] _Coordinates;
        private bool _Traversable;
        private Party _Enemies;
        private List<GameItem> _Items;
        private bool _IsStart;
        private bool _IsFinish;

        /*
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

        /*
         * traversable=true
         * startOrFinish: true->start, false->finish, null->neither
         * */
        public Cell(int[] coordinates, Map thisMap, bool traversable, bool startOrFinish)
        {
            _MyMap = thisMap;
            _Coordinates = coordinates;
            _Traversable = traversable;

            if (startOrFinish == true)
            {
                _IsStart = true;
                _IsFinish = false;
            }
            else if (startOrFinish == false)
            {
                _IsStart = true;
                _IsFinish = false;
            }
            else
            {
                _IsStart = false;
                _IsFinish = false;
            }

            _Enemies = new Party("Enemies", this);
            _Items = new List<GameItem>();
        }


        
        public Party _enemies
        {
            get {return _Enemies;}
        }
        
        public List<GameItem> _items
        {
            get { return _Items; }
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
            //Test to see if the cell is traversable. We don't need to generate enemies in the wall!
            if(_Traversable)
            {
                Random rnd = new Random();
                int choice = rnd.Next(12);
                if (choice <= 3)
                {
                    //Empty party, no added enemies.
                }
                else if (choice > 3 && choice <= 6)
                {
                    _Enemies.AddCharacter(_MyMap.GetEnemyFactory().GetRandomGameCharacter());
                }
                else if (choice > 6 || choice <= 9)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        _Enemies.AddCharacter(_MyMap.GetEnemyFactory().GetRandomGameCharacter());
                    }
                }
                else if (choice == 10)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        _Enemies.AddCharacter(_MyMap.GetEnemyFactory().GetRandomGameCharacter());
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        _Enemies.AddCharacter(_MyMap.GetEnemyFactory().GetRandomGameCharacter());
                    }
                }
            }
        }
        
        public void GenerateItems()
        {
            if(_Traversable)
            {
                Random rnd = new Random();
                int choice = rnd.Next(5);
                if (choice < 2)
                {
                    //Empty list, no items added.
                }
                else if (choice == 2)
                {
                    _Items.Add(_MyMap.GetItemFactory().GetRandomItem());
                }
                else if (choice == 3)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        _Items.Add(_MyMap.GetItemFactory().GetRandomItem());
                    }
                }
                else if (choice == 4)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        _Items.Add(_MyMap.GetItemFactory().GetRandomItem());
                    }
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
