using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming.Data.Entities.EnemyEntities
{
    public class Goblin : Enemy
    {
        public Goblin()
        {
            AttackName = "Default Attack";
            AttackStrength = 5;
        }
    }
}