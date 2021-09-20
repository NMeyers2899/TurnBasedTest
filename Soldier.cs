using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{
    class Soldier : Unit
    {
        public Soldier() : base("Soldier", 10, 8, 3, 2) { }

        public override Unit Target(Unit[] targetSquad)
        {
            Unit unit = new Unit();

            return unit;
        }
    }
}
