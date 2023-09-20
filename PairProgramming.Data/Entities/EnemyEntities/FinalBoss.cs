using PairProgramming.Data.Entities.PlayerEntities;
namespace PairProgramming.Data.Entities.EnemyEntities
{
    public class FinalBoss : Enemy
    {
           public FinalBoss()
        {
            _healthPoints = 200;
        }
         public void Rejuvination()
        {
            IncreaseHealth(20);
            System.Console.WriteLine($"{Name} was able to replenish some HP!\n" + $"{Name} now has {HealthPoints} health!\n");
        }
        public void BossAttack(Player player)
        {
            if(player.HealthPoints > 0)
            {
                player.DecreaseHealth(AttackStrength);
                System.Console.WriteLine("The goblins surrounding their master launch towards you in a frenzy!!");
                System.Console.WriteLine($"{Name} just hit you with {AttackName.ToUpper()} you Lost {AttackStrength} Health!");
                Console.ReadKey();
            }
        }
    }
}