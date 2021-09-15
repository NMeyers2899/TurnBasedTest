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
    }
}
