using System;
using System.Collections.Generic;
using System.Linq;
using PairProgramming.Data.Entities.EnemyEntities;

namespace PairProgramming.Repository.Enemy_Repository
{
    public class EnemyRepository
    {
        public List<Enemy> _villageEnemyDb = new List<Enemy>();
        public int _count = 0;
        public EnemyRepository()
        {
            SeedEnemy();
        }

        private void AssignId (Enemy enemy)
        {
            _count++;
            enemy.ID = _count;
        }

        private bool SaveToDatabase(Enemy enemy)
        {
            AssignId(enemy);
            _villageEnemyDb.Add(enemy);
            return true;
        }

        public bool AddEnemy(Enemy enemy)
        {
            return (enemy is null) ? false: SaveToDatabase(enemy);
        }

        public Enemy GetEnemy()
        {
            return _villageEnemyDb.FirstOrDefault()!;
        }

        public Enemy GetEnemy(int id)
        {
            return _villageEnemyDb.SingleOrDefault(x => x.ID == id)!;
        }
        private void SeedEnemy()
        {
            var enemy1 = new Goblin
            {
                ID = 1,
                Name = "Random Goblin",
                AttackStrength = 10,
                AttackName = "Blade Attack"
            };

            var enemy2 = new Goblin
            {
                ID = 2,
                Name = "Goblin Lieutenant",
                AttackStrength = 15,
                AttackName = "Spear Throw"               
            };
            var enemy3 = new Goblin
            {
                ID = 3,
                Name = "Goblin Preist",
                AttackStrength = 20,
                AttackName = "Rage Blast"

            };

            _villageEnemyDb.Add(enemy1);
            _villageEnemyDb.Add(enemy2);
            _villageEnemyDb.Add(enemy3);
        }
    }
}
