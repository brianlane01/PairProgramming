using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PairProgramming.Data.Entities.PlayerEntities;

namespace PairProgramming.Data.Entities.EnemyEntities
{
    public abstract class Enemy
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int HealthPoints { get; set; } = 100;
        public int AttackStrength {get; set;}
        public string AttackName {get; set;}
        public bool IsAlive
        {
            get 
            {
                return HealthPoints > 0;
            }
        }

         public void IncreaseHealth(int pointValue = 5)
        {
            if(HealthPoints > 0)
            HealthPoints += pointValue;
        }

        public void DecreaseHealth(int pointValue = 5)
        {
            if(HealthPoints >= 0)
            HealthPoints -= pointValue;
        }

        public virtual void EnemyAttack(Player player, int attackStrength , string attackName)
        {
            if(player.HealthPoints > 0)
            {
                player.DecreaseHealth(attackStrength);
                System.Console.WriteLine($"{Name} just hit you with {attackName.ToUpper()} you Lost {attackStrength} Health!");
            }
        }

    }
}