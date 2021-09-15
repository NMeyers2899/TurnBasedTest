using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    class Unit
    {
        private string _name;
        private float _maxHealth;
        private float _health;
        private float _attackPower;
        private float _defensePower;
        private float _magic;
        private float _resistance;
        private int _deployCost;

        public string Name
        {
            get { return _name; }
        }

        public float Health
        {
            get { return _health; }
        }

        public float AttackPower
        {
            get { return _attackPower; }
        }

        public float DefensePower
        {
            get { return _defensePower; }
        }

        public float Magic
        {
            get { return _magic; }
        }

        public float Resistance
        {
            get { return _resistance; }
        }

        public int DeployCost
        {
            get { return _deployCost; }
        }

        public Unit()
        {
            _name = "None";
            _maxHealth = 0;
            _health = _maxHealth;
            _attackPower = 0;
            _defensePower = 0;
            _magic = 0;
            _resistance = 0;
            _deployCost = 0;
        }

        public Unit(string name, float maxHealth, float attack, float defense, float magic, float resistance,
            int deployCost)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attackPower = attack;
            _defensePower = defense;
            _magic = magic;
            _resistance = resistance;
            _deployCost = deployCost;
        }

        /// <summary>
        /// Allows the entity to take damage and decrease their health based on that damage.
        /// </summary>
        /// <param name="damageAmount"> The amount of damage being dealt. </param>
        /// <returns> The amount of damage being dealt. </returns>
        public float TakeDamage(float damageAmount)
        {
            float damageTaken = damageAmount - DefensePower;

            if (damageTaken < 0)
            {
                damageTaken = 0;
            }

            _health -= damageTaken;

            return damageTaken;
        }

        public float Attack(Unit target)
        {
            return target.TakeDamage(AttackPower);
        }
    }
}
