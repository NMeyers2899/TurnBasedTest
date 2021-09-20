using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    class Soldier : Unit
    {
        public Soldier() : base("Soldier", 10, 8, 3, 2) { }

        public override Unit Target(int currentPosition, Unit[] targetSquad)
        {
            Unit unit = new Unit();

            int targetedPosition = currentPosition;

            bool targetFound = false;

            if(targetSquad[targetedPosition].Health > 0)
            {
                Attack(targetSquad[targetedPosition]);
            }

            return unit;
        }
    }
}
