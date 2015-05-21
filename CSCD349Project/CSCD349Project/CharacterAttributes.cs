using System;
using System.Collections.Generic;
namespace CSCD349Project
{
    public class CharacterAttributes
    {
        // private fields
        private sealed static int _MaxLevel = 4;
        private int _Level = 1;
        private int[] _BaseXP;
        private int _XP = 0;
        private Double _Health;
        private Double _BaseHealth;
        private Double _Energy;
        private Double _BaseEnergy;
        private Double _Power;
        private Double _Armor;
        private bool _IsGoodGuy;
        private List<OffensiveAbility> _Attacks;
        private OffensiveAbility _ActiveAttack;
        private List<DefensiveAbility> _Defenses;
        private DefensiveAbility _ActiveDefense;

        // constructors
        public CharacterAttributes()
        {
            _Attacks = new List<OffensiveAbility>();
            _Defenses = new List<DefensiveAbility>();
            _ActiveAttack = new NullAttack();
            _ActiveDefense = new NullDefend();
        }

      
        // properties
        public void AddAttack(OffensiveAbility newAbility)
        {
            if(newAbility != null)
                _Attacks.Add(newAbility);
        }

        public void AddDefense(DefensiveAbility newAbility)
        {
            if (newAbility != null)
                _Defenses.Add(newAbility);
        }

        public int _maxLevel
        {
            get { return _MaxLevel; }
            //set { _MaxLevel = Math.Max(value, 0); }
        }

        public int _level
        {
            get { return _Level; }
            set { _Level = Math.Min(Math.Max(value, 0), _MaxLevel); }
        }

        public int[] _baseXP
        {
            get { return _BaseXP; }
            set { _BaseXP = _baseXP; }
        }

        public int _xp
        {
            get { return _XP; }
            set { _XP = Math.Min(Math.Max(value, 0), _BaseXP[_Level]); }
        }

        public Double _health
        {
            get {return _Health;}
            set { _Health = Math.Min(Math.Max(value, 0), _BaseHealth);}
        }

        public Double _basehealth
        {
            get{return _BaseHealth;}
            set { _BaseHealth = Math.Max(value, 0); _Health = Math.Min(_Health, _BaseHealth); }
        }

        public Double _power
        {
            get { return _Power; }
            set { _Power = value; }
        }

        public Double _energy
        {
            get { return _Energy; }
            set { _Energy = Math.Min(Math.Max(value, 0), _BaseEnergy); }
        }
        public Double _baseEnergy
        {
            get { return _BaseEnergy; }
            set { _BaseEnergy = Math.Max(value, 0); _Energy = Math.Min(_Energy, _BaseEnergy); }
        }
        public Double _armor
        {
            get { return _Armor; }
            set { _Armor = value; }
        }
        public List<DefensiveAbility> _defenses
        {
            get { return _Defenses; }
        }
        public List<OffensiveAbility> _attacks
        {
            get { return _Attacks; }
        }
        
        // methods
        public bool GetIsGoodGuy() { return _IsGoodGuy; }
        public void SetIsGoodGuy(bool value) { _IsGoodGuy = value;}

        public void SetActiveAttack(OffensiveAbility value) { if (value != null) _ActiveAttack = value; }
        public OffensiveAbility GetActiveAttack() { return _ActiveAttack; }
        public List<OffensiveAbility> GetAttacks() { return _Attacks; }
        public bool RemoveAttack(OffensiveAbility value)
        {
            if (_ActiveAttack == value)
                return false;
            return _Attacks.Remove(value);
        }
        public void SetAttacks(List<OffensiveAbility> value) { if (value != null) _Attacks = value; }

        public void SetActiveDefense(DefensiveAbility value) { if (value != null) _ActiveDefense = value; }
        public DefensiveAbility GetActiveDefense() { return _ActiveDefense; }
        public bool RemoveDefense(DefensiveAbility value)
        {
            if (_ActiveDefense == value)
                return false;
            return _Defenses.Remove(value);
        }
        
        
        
        //public void SetDefenses(List<IDefend> value) { if (value != null) _attacks = value; }
        public List<DefensiveAbility> GetDefenses() { return _Defenses; }
    }
}