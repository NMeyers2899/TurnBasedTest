using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    public class Player
    {
        private int _playerDeploy;
        private Unit[] _playerArmy = new Unit[15];

        public int PlayerDeploy
        {
            get { return _playerDeploy; }
        }
        
        public Unit[] PlayerArmy
        {
            get { return _playerArmy; }
        }

        public Player()
        {
            _playerDeploy = 16;

            for(int i = 0; i < _playerArmy.Length; i++)
            {
                _playerArmy[i] = new Unit();
            }
        }

        /// <summary>
        /// Adds a unit to the position the player decides.
        /// </summary>
        /// <param name="unit"> The unit being added. </param>
        /// <param name="position"> The position the unit will be added to in the array. </param>
        public void AddUnit(Unit unit, int position)
        {
            _playerArmy[position] = unit;
        }

        /// <summary>
        /// Removes a unit from a position that the player decides.
        /// </summary>
        /// <param name="position"> The position at which a unit will be removed. </param>
        public void RemoveUnit(int position)
        {
            _playerArmy[position] = new Unit();
        }
    }
}
