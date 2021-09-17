using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    class Commander : Unit
    {
        private bool _isInArmy;

        public bool IsInArmy
        {
            get { return _isInArmy; }
        }

        public Commander()
        {
            _isInArmy = false;
        }

        public Commander(string name, float maxHealth, float attack, float defense, int deployCost)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attackPower = attack;
            _defensePower = defense;
            _deployCost = deployCost;
            _isInArmy = false;
        }

        public void AddCommander()
        {
            _isInArmy = true;
        }

        public void RemoveCommander()
        {
            _isInArmy = false;
        }
    }
}
