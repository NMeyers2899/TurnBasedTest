﻿using System;
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

        public Commander() : base("Ivanas", 25, 10, 6, 0)
        {
            _isInArmy = false;
        }

        public Commander(string name, float maxHealth, float attack, float defense, int deployCost) :
            base(name, maxHealth, attack, defense, deployCost)
        {
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

        public override Unit Target(int currentPosition, Unit[] targetSquad)
        {
            Unit unit = new Unit();

            int targetedPosition = currentPosition;

            bool targetFound = false;

            if (targetSquad[targetedPosition].Health > 0)
            {
                Attack(targetSquad[targetedPosition]);
            }

            return unit;
        }
    }
}
