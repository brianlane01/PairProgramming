using PairProgramming.Data.Entities.PlayerEntities;
namespace PairProgramming.Data.Entities.EnemyEntities
{
    public class FinalBoss : Enemy
    {
         public void Rejuvination()
        {
            IncreaseHealth(20);
            System.Console.WriteLine($"{Name} was able to replenish some HP!\n" + $"{Name} now has {HealthPoints} health!\n");
        }
        public void BossAttack(Player player, int attackStrength = 30, string attackName = "Fists of Destruction")
        {
            if(player.HealthPoints > 0)
            {
                player.DecreaseHealth(attackStrength);
                System.Console.WriteLine($"{Name} just hit you with {attackName.ToUpper()} you Lost {attackStrength} Health!");
            }
        }
    }
}