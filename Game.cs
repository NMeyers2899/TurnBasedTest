using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{ 
    /// <summary>
    /// The constuctor of a unit template.
    /// </summary>
    struct Unit
    {
        public string name;
        public int health;
        public int attack;
        public int defense;
        public int identifier;
    }

    class Game
    {
        // Initalizes the names of different units.
        Unit Soldier;
        Unit Ruffian;

        Unit unit;

        /// <summary>
        /// Figures out the damage being dealt in a specific attack.
        /// </summary>
        /// <param name="attack"> The unit's attack. </param>
        /// <param name="defense"> The target's defense. </param>
        /// <returns> The damage dealt to the target. </returns>
        int DealDamage(int attack, int defense)
        {
            // Calculates the damage that will be dealt.
            int damage = attack - defense;

            // Checks to see if the damage is less than zero. If it is, it sets damage to zero.
            if(damage < 0)
            {
                return 0;
            }

            return damage;
        }

        /// <summary>
        /// Sends two units against each other to fight, dealing damage to the second.
        /// </summary>
        /// <param name="unit1"> The attacker, who will deal damage. </param>
        /// <param name="unit2"> The target, who will take the damage being dealt.. </param>
        void Combat(ref Unit unit1, ref Unit unit2)
        {
            // Calculates the damage that will be dealt.
            int damageTaken = DealDamage(unit1.attack, unit2.defense);

            // Subtracts the damage from the target's health.
            unit2.health -= damageTaken;

            Console.WriteLine(unit2.name + " takes " + damageTaken + " damage!");
        }


        /// <summary>
        /// Uses an identifier to get a given unit, and sets it equal to that unit's stats.
        /// </summary>
        /// <param name="unitIdentifier"> The indentifier number for a unit. </param>
        void GetUnit(int unitIdentifier)
        {
            if(unitIdentifier == 0)
            {
                Console.WriteLine("No unit identification.");
            } 
            else if(unitIdentifier == 1)
            {
                unit = Soldier;
            }
        }

        void Start()
        {
            // Initializes the player's army.   
            string[] playerArmy;

            // Initalizes the stats for a soldier.
            Soldier.name = "Soldier";
            Soldier.health = 10;
            Soldier.attack = 8;
            Soldier.defense = 3;
            Soldier.identifier = 1;

            // Initializes the stats for a ruffian.
            Ruffian.name = "Ruffian";
            Ruffian.health = 15;
            Ruffian.attack = 10;
            Ruffian.defense = 2;
            Ruffian.identifier = 2;
        }

        void Update()
        {
            
        }

        public void Run()
        {
            
        }
    }
}
