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
        private List<IAttack> _attacks;
        private IAttack _activeAttack;
        private List<IAttack> _defenses;
        private IAttack _activeDefense;

        // constructors
        public CharacterAttributes()
        {
            _attacks = new List<IAttack>();
            _defenses = new List<IDefense>();
            _activeAttack = new NullAbility();
            _activeAttack = new NullAbility();
        }

        // properties
        public void AddAttack(IAttack newAbility)
        {
            if(newAbility != null)
                _attacks.Add(newAbility);
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
            get { return _armor; }
            //MICHAEL!!! I don't understand this setter crap. Help me out? LOL.
        }
        
        // methods
        public bool GetIsGoodGuy() { return _isGoodGuy; }
        public void SetIsGoodGuy(bool value) { _isGoodGuy = value;}
        
        public void SetActiveAttack(IAttack value){if(value != null) _activeAttack = value;}
        public IAttack GetActiveAttack() { return _activeAttack; }
        public List<IAttack> GetAttacks() { return _attacks; }
        public bool RemoveAttack(IAttack value)
        {
            if (_activeAttack == value)
                return false;
            return _attacks.Remove(value);
        }
        public void SetAttacks(List<IAttack> value) { if (value != null) _attacks = value; }

        public void SetActiveDefense(IDefend value) { if (value != null) _activeDefense = value; }
        public IDefend getActiveDefense() { return _activeDefense; }
        public bool RemoveDefense(IDefend value)
        {
            if (_activeDefense == value)
                return false;
            return _defenses.Remove(value);
        }
        public void SetDefenses(List<IDefend> value) { if (value != null) _attacks = value; }
        public List<IDefend> GetDefenses() { return _defenses; }
    }
}