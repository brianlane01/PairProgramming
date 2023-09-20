using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.EnemyEntities;

namespace PairProgramming.Repository.Enemy_Repository
{
    public class FinalBossRepository
    {
         public List<FinalBoss> _villageBossDb = new List<FinalBoss>();
        public int _count = 0;
        public FinalBossRepository()
        {
            SeedBoss();
        }

        private void AssignId (FinalBoss finalBoss)
        {
            _count++;
            finalBoss.ID = _count;
        }

        private bool SaveToDatabase(FinalBoss finalBoss)
        {
            AssignId(finalBoss);
            _villageBossDb.Add(finalBoss);
            return true;
        }

        public bool AddBoss(FinalBoss finalBoss)
        {
            return (finalBoss is null) ? false: SaveToDatabase(finalBoss);
        }

        public FinalBoss GetBoss()
        {
            return _villageBossDb.FirstOrDefault()!;
        }

        public FinalBoss GetBoss(int id)
        {
            return _villageBossDb.SingleOrDefault(x => x.ID == id)!;
        }
        private void SeedBoss()
        {
            var finalBoss = new FinalBoss
            {
                ID = 1,
                Name = "Supreme Goblin Overlord",
                AttackStrength = 30,
                AttackName = "Goblin Horde Attack"
            };

            _villageBossDb.Add(finalBoss);
        }
    
    }
}