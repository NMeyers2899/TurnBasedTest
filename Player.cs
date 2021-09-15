using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    class Player
    {
        private int _playerDeploy;
        private Unit[] playerArmy = new Unit[15];

        public int PlayerDeploy
        {
            get { return _playerDeploy; }
        }

        public Player()
        {
            _playerDeploy = 16;
        }

        /// <summary>
        /// Adds a unit to the position the player decides.
        /// </summary>
        /// <param name="unit"> The unit being added. </param>
        /// <param name="position"> The position the unit will be added to in the array. </param>
        public void AddUnit(Unit unit, int position)
        {
            playerArmy[position] = unit;
        }

        public void RemoveUnit(int position)
        {
            playerArmy[position] = new Unit("None", 0, 0, 0, 0, 0, 0);
        }
    }
}
