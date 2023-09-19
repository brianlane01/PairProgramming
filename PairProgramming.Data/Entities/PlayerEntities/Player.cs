using System;
using PairProgramming.Data.Entities.EnemyEntities;
using PairProgramming.Data.Utilities;

namespace PairProgramming.Data.Entities.PlayerEntities
{
    public class Player
    {
        public Player()
        {
            PlayerStartUp();
        }
        public Player(string name)
        {
            Name = name;
            PlayerStartUp();
        }
        public string Name {get; set;} = string.Empty;  
        public int Damage {get; set;} 
         public int arrowValue = 1;
         public int HealthPoints {get; set ;} = 200;
        public bool IsAlive
        {
            get 
            {
                return (HealthPoints <= 0) ? true : false; 
            }
        }

        // public void HealthDepletion1(int decreaseValue1 = 5)
        // {
        //     if(HealthPoints >= 0)
        //     HealthPoints -= decreaseValue1;

        // }

        public void DecreaseHealth(int pointValue = 5)
        {
            if(HealthPoints >= 0)
            HealthPoints -= pointValue;
        }

        public void IncreaseHealth(int pointValue = 5)
        {
            if(HealthPoints > 0)
            HealthPoints += pointValue;
        }

        public void DrinkPotion(int healthIncrease = 50 )
        {   
            Console.Clear();
            if(HealthPoints >= 1 && Potion.IsUseable)
            {
            Potion.UseUntilBreak--;
            HealthPoints += healthIncrease;
            System.Console.WriteLine($"You drink the potion, increasing your health.\n"+
                                    $"You recovered 50 HP!!\n"+
                                    $"Your HP is now {HealthPoints}.\n"+
                                    "No more potions available.");
                                
            }
            else
            {
                System.Console.WriteLine("You don't have any potions in your inventory.");
            }
            System.Console.WriteLine("Press any key to continue..");
            Console.ReadKey();


        }

        public void ShootBowAndArrow(Enemy enemy, int attackPower1 = 15 )
        {
            Console.Clear();
            if(BowAndArrow.IsUseable)
            {
                BowAndArrow.UseUntilBreak--;
                System.Console.WriteLine($"You draw an arrow and shoot at {enemy.Name}!\n"+
                                        $"{enemy.Name} lost 15 HP!!.");
                if(enemy.HealthPoints > 0)
                {
                    enemy.DecreaseHealth(attackPower1);
                    System.Console.WriteLine($"{enemy.Name} has {enemy.HealthPoints} left.\n"+
                                        $"You have {BowAndArrow.UseUntilBreak} arrows left");
                }
                else if(enemy.HealthPoints <= 0)
                {
                    System.Console.WriteLine($"You have defeated {enemy.Name}!! Put some Respect on it!!");
                }
                                       

            }
            else
            {
                System.Console.WriteLine("You need to find some arrows to use this Item!!");
            }
            System.Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }

        public void SwordAttack(Enemy enemy, int attackPower2 = 25)
        {   
            Console.Clear();
            if (Sword.IsUseable)
            {
                Sword.UseUntilBreak--;
                System.Console.WriteLine($"You swing your sword at {enemy.Name}!\n"+
                $"{enemy.Name} has lost 25 HP!\n"+
                $"You can use your sword {Sword.UseUntilBreak} more times.");

                if(enemy.HealthPoints> 0)
                {
                    enemy.DecreaseHealth(attackPower2);
                    System.Console.WriteLine($"{enemy.Name} has {enemy.HealthPoints} left.");
                }
                else if(enemy.HealthPoints <= 0)
                {
                    System.Console.WriteLine($"You have defeated {enemy.Name}!! Put some Respect on it!!");
                }
            }
            else
            {
                System.Console.WriteLine("Your Sword has broken find another way to attack!!");
            }
            System.Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }

        public void AddToArrowQuiver(int arrowValue)
        {
            BowAndArrow.UseUntilBreak += arrowValue;
        }

        public List<InventoryItem> Items;
        private InventoryItem BowAndArrow;
        private InventoryItem Sword;
        private InventoryItem Shield;
        private InventoryItem Potion;

        private void PlayerStartUp()
        {
            Items = PlayerAsset.InitializePlayerStartUpItems();
            Potion = Items[0];
            BowAndArrow = Items[1];
            Sword = Items[2];
            Shield = Items[3];

        }

    }
}