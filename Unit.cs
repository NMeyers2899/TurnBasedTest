using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    public class Unit
    {
        protected string _name;
        protected float _maxHealth;
        protected float _health;
        protected float _attackPower;
        protected float _defensePower;
        protected int _deployCost;

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
            _deployCost = 0;
        }

        public Unit(string name, float maxHealth, float attack, float defense, int deployCost)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attackPower = attack;
            _defensePower = defense;
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

            Console.WriteLine(damageTaken + " damage was taken by " + this.Name + "!");
            Console.ReadKey(true);

            return damageTaken;
        }

        /// <summary>
        /// This unit will attack another. Dealing damage to it.
        /// </summary>
        /// <param name="target"> The target of the attack. </param>
        /// <returns> Returns the damage taken by the target. </returns>
        public float Attack(Unit target)
        {
            return target.TakeDamage(AttackPower);
        }

        public virtual Unit Target(int currentPosition, Unit[] targetSquad)
        {
            Unit unit = new Unit();

            return unit;
        }
    }
}
