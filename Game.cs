using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{ 
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

        void GetUnit(int unitIdentifier)
        { 
                
        }

        void Start()
        {
            string[] playerArmy;

            // Initalizes the stats for a soldier.
            Unit soldier;
            soldier.name = "Soldier";
            soldier.health = 10;
            soldier.attack = 8;
            soldier.defense = 3;
            soldier.identifier = 1;
        }

        void Update()
        {

        }

        public void Run()
        {
            
        }
    }
}
