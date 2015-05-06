using System;
using System.Collections.Generic;
namespace CSCD349Project
{
    public class CharacterAttributes
    {
        // private feilds
        private int _Health;
        private int _BaseHealth;
        private int _Power;
        private int _BasePower;
        private int _Energy;
        private int _BaseEnergy;
        private bool _isGoodGuy;
        private List<Ability> _attacks;
        private Ability _activeAttack;
        private List<Ability> _defenses;
        private Ability _activeDefense;

        // constructors
        public CharacterAttributes()
        {
            _attacks = new List<Ability>();
            _defenses = new List<Ability>();
            _activeAttack = new NullAbility();
            _activeAttack = new NullAbility();
        }

        // properties
        public void AddAttack(Ability newAbility)
        {
            if(newAbility != null)
                _attacks.Add(newAbility);
        }
        public int _health
        {
            get {return _Health;}
            set { _Health = Math.Min(Math.Max(value, 0), _BaseHealth);}
        }
        public int _basehealth
        {
            get{return _BaseHealth;}
            set { _BaseHealth = Math.Max(value, 0); _Health = Math.Min(_Health, _BaseHealth); }
        }

        public int _power
        {
            get { return _Power; }
            set { _Power = Math.Min(Math.Max(value, 0), _BasePower); }
        }
        public int _basePower
        {
            get { return _BasePower; }
            set { _BasePower = Math.Max(value, 0); _Power = Math.Min(_Power, _BasePower); }
        }

        public int _energy
        {
            get { return _Energy; }
            set { _Energy = Math.Min(Math.Max(value, 0), _BaseEnergy); }
        }
        public int _baseEnergy
        {
            get { return _BaseEnergy; }
            set { _BaseEnergy = Math.Max(value, 0); _Energy = Math.Min(_Energy, _BaseEnergy); }
        }
        
        // methods
        public bool GetIsGoodGuy() { return _isGoodGuy; }
        public void SetIsGoodGuy(bool value) { _isGoodGuy = value;}
        
        public void SetActiveAttack(Ability value){if(value != null) _activeAttack = value;}
        public Ability GetActiveAttack() { return _activeAttack; }
        public List<Ability> GetAttacks() { return _attacks; }
        public bool RemoveAttack(Ability value)
        {
            if (_activeAttack == value)
                return false;
            return _attacks.Remove(value);
        }
        public void SetAttacks(List<Ability> value) { if (value != null) _attacks = value; }

        public void SetActiveDefense(Ability value){if(value != null) _activeDefense = value;}
        public Ability getActiveDefense(){return _activeDefense;}
        public bool RemoveDefense(Ability value)
        {
            if (_activeDefense == value)
                return false;
            return _defenses.Remove(value);
        }
        public void SetDefences(List<Ability> value) { if (value != null) _attacks = value; }
        public List<Ability> GetDefences() { return _defenses; }
        

    }
}