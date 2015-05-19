using System;
using System.Collections.Generic;
namespace CSCD349Project
{
    public class CharacterAttributes
    {
        // private feilds
        private Double _Health;
        private Double _BaseHealth;
        private Double _Energy;
        private Double _BaseEnergy;
        private Double _Power;
        private Double _Armor;
        private bool _isGoodGuy;
        private List<OffensiveAbility> _attacks;
        private OffensiveAbility _activeAttack;
        private List<DefensiveAbility> _defenses;
        private DefensiveAbility _activeDefense;

        // constructors
        public CharacterAttributes()
        {
            _attacks = new List<OffensiveAbility>();
            _defenses = new List<DefensiveAbility>();
            _activeAttack = new NullAttack();
            _activeDefense = new NullDefend();
        }

      
        // properties
        public void AddAttack(OffensiveAbility newAbility)
        {
            if(newAbility != null)
                _attacks.Add(newAbility);
        }

        public void AddDefense(DefensiveAbility newAbility)
        {
            if (newAbility != null)
                _defenses.Add(newAbility);
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
            set { _Power = Math.Min(Math.Max(value, 0), _power); }
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
        public List<DefensiveAbility> _Defenses
        {
            get { return _defenses; }
        }
        public List<OffensiveAbility> _Attacks
        {
            get { return _attacks; }
        }
        
        // methods
        public bool GetIsGoodGuy() { return _isGoodGuy; }
        public void SetIsGoodGuy(bool value) { _isGoodGuy = value;}

        public void SetActiveAttack(OffensiveAbility value) { if (value != null) _activeAttack = value; }
        public OffensiveAbility GetActiveAttack() { return _activeAttack; }
        public List<OffensiveAbility> GetAttacks() { return _attacks; }
        public bool RemoveAttack(OffensiveAbility value)
        {
            if (_activeAttack == value)
                return false;
            return _attacks.Remove(value);
        }
        public void SetAttacks(List<OffensiveAbility> value) { if (value != null) _attacks = value; }

        public void SetActiveDefense(DefensiveAbility value) { if (value != null) _activeDefense = value; }
        public DefensiveAbility GetActiveDefense() { return _activeDefense; }
        public bool RemoveDefense(DefensiveAbility value)
        {
            if (_activeDefense == value)
                return false;
            return _defenses.Remove(value);
        }
        
        
        
        //public void SetDefenses(List<IDefend> value) { if (value != null) _attacks = value; }
        public List<DefensiveAbility> GetDefenses() { return _defenses; }
    }
}