using System;
using System.Collections.Generic;
namespace CSCD349Project
{
    public class GameObject
    {
        private Cell _OccupyingCell;
        private Sprite _Sprite;
        //private GameObjectType _type{get;set;}
        private string _Name;

        public string GetName() { return _Name; }

        public Cell GetCell() { return _OccupyingCell; }
        public void SetCell(Cell value) { if (value != null) _OccupyingCell = value; }

        public Sprite GetSprite() { return _Sprite; }
        public void SetSprite(Sprite value) { if(value != null ) _Sprite = value;}


        public GameObject(string name)
        {
            _Name = name;
        }

        public override string ToString()
        {
            return _Name;
        }
    }



    public enum GameObjectType{gameCharacter, gameItem, }

    public class Sprite
    {
        public Sprite(string path)
        {

        }
        
    }
}
