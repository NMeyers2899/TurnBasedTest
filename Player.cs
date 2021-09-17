using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    public class Player
    {
        private int _playerDeploy;
        private Unit[] _playerArmy;

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

            _playerArmy = new Unit[15];

            for(int i = 0; i < _playerArmy.Length; i++)
            {
                _playerArmy[i] = new Unit();
            }
        }

        /// <summary>
        /// Takes a units deploy cost and measures it against another unit's deploy cost then changes the 
        /// players cost accordingly.
        /// </summary>
        /// <param name="unit1"> The unit that is being swapped out. </param>
        /// <param name="unit2"> The unit that is being swapped in. </param>
        /// <returns> True or false, depending on if the deploy cost was able to be changed or not. </returns>
        private bool GetDeployCost(Unit unit1, Unit unit2)
        {
            if (_playerDeploy <= 0 || (_playerDeploy - unit2.DeployCost) <= 0)
            {
                Console.WriteLine("Not enough deploy");
                Console.ReadKey(true);
                Console.Clear();
                return false;
            }
            else
            {
                if (unit1.DeployCost < unit2.DeployCost)
                {
                    _playerDeploy -= unit2.DeployCost - unit1.DeployCost;
                    return true;
                }
                else if (unit1.DeployCost > unit2.DeployCost)
                {
                    _playerDeploy += unit1.DeployCost - unit2.DeployCost;
                    return true;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Adds a unit to the position the player decides.
        /// </summary>
        /// <param name="unit"> The unit being added. </param>
        /// <param name="position"> The position the unit will be added to in the array. </param>
        public void AddUnit(Unit unit, int position)
        {
            if(unit is Commander && (unit as Commander).IsInArmy)
            {
                Console.WriteLine("Your commander is already in your army.");
                Console.ReadKey();
                return;
            }
            else if(unit is Commander)
            {
                (unit as Commander).AddCommander();
            }

            if(!GetDeployCost(_playerArmy[position], unit))
            {
                return;
            }

            _playerArmy[position] = unit;
        }

        /// <summary>
        /// Removes a unit from a position that the player decides.
        /// </summary>
        /// <param name="position"> The position at which a unit will be removed. </param>
        public void RemoveUnit(int position)
        {
            if(_playerArmy[position] is Commander)
            {
                (_playerArmy[position] as Commander).RemoveCommander();
            }

            _playerDeploy += _playerArmy[position].DeployCost;

            _playerArmy[position] = new Unit();
        }
    }
}
