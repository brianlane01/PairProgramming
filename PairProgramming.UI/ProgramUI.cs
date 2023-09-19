
using static System.Console;
using PairProgramming.Data.Entities;
using PairProgramming.Data.Entities.PlayerEntities;
using PairProgramming.Repository.Enemy_Repository;
using PairProgramming.Data.Entities.EnemyEntities;
namespace PairProgramming.UI
{

    public class ProgramUI
    {
        private readonly EnemyRepository _villageEnemyRepo = new EnemyRepository();
        // private PairProgramming.Data.Entities.EnemyEntities _enemy;
        public Player newHero = new Player();
        public bool _rescuedUpperVillage;
        public bool _rescuedLowerVillage;
        public bool hasLeftUpperVillage;
        public bool hasLeftLowerVillage;
        private bool isRunning = true;
        public string playerName;
        // private readonly ProjectItemRepo _projRepo = new ProjectItemRepo();

        public ProgramUI()
        {
            _villageEnemyRepo.GetEnemy();

        }
        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            // bool isRunning = true;
            while (isRunning)
            {
                // Game code goes here 
                System.Console.WriteLine("Welcome to Code Warriors\n" +
                "1. Start Game\n" +
                "2. Exit App\n");

                string userInput = ReadLine();

                switch (userInput)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        isRunning = ExitApplication();
                        break;
                    default:
                        WriteLine("Invalid Selection");
                        break;
                }
            }
        }
        private bool ExitApplication()
        {
            Clear();
            WriteLine("Thanks for playing");
            ReadKey();
            return false;
        }

        private void StartGame()
        {
            Clear();
            System.Console.WriteLine($"What is your name?");
            playerName = Console.ReadLine();
            Clear();
            System.Console.WriteLine($"Welcome {playerName} to the land of Middle Earth.\n" + "Your quest is just beginning\n" +
                                        $"Press any Key to Continue...");
            ReadKey();
            Clear();
            System.Console.WriteLine("You have been tasked with saving a village from rutheless goblins\n" +
                                    "The goblins have destroyed portions of the village and surrounding farmlands....\n" +
                                    "You must defeat The Goblin Lord and any other foes that cross your path\n" +
                                        "Press any key to continue.. ");
            MainGate();
        }

        private void MainGate()
        {
            if (_rescuedLowerVillage == false && _rescuedUpperVillage == false)
            {
                ArriveAtOverrunVillage();
            }
            else if (_rescuedLowerVillage == true && _rescuedUpperVillage == false)
            {
                ProceedToUpperVillage();
            }
            else if (_rescuedLowerVillage == false && _rescuedUpperVillage == true)
            {
                ProceedToLowerVillage();
            }
            else
            {
                if (_rescuedLowerVillage == true && _rescuedUpperVillage == true)
                {
                    isRunning = ExitApplication();
                }
                AdvanceToKeep();
            }
        }

        private void AdvanceToKeep()
        {
            // _rescuedLowerVillage = true;
            // _rescuedUpperVillage = true;

            System.Console.WriteLine("You have made to the end\n" +
                                    "Press any key to continue..");
            Console.ReadKey();
            MainGate();
        }

        private void ProceedToUpperVillage()
        {
            Console.Clear();
            System.Console.WriteLine($"{playerName}, you succesfully saved the market place in the Lower Village\n" +
                                    "We still need to free the Upper village and defeat the Goblin Master...\n " +
                                    "Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine($"What will you do next {playerName}?\n" +
                                    "1. Work towards clearing the Goblins from the Upper Village\n" +
                                    "2. Flee the village for safety.....");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    PathToUpperVillage();
                    break;
                case 2:
                    RunAway();
                    break;
                default:
                    System.Console.WriteLine("You must decide quickly before the goblins overrun your position.\n" +
                                            "Please chose 1 or 2");
                    Console.Clear();
                    break;
            }
        }
        private void ProceedToLowerVillage()
        {
            Console.Clear();
            System.Console.WriteLine($"{playerName}, you succesfully saved the homes from the goblins in the Upper Village\n" +
                                    "We still need to free the lower village and defeat the Goblin Master...\n " +
                                    "Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine($"What will you do next {playerName}?\n" +
                                    "1. Work towards clearing the Goblins from the Lower Village\n" +
                                    "2. Flee the village for safety.....");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    PathToLowerVillage();
                    break;
                case 2:
                    RunAway();
                    break;
                default:
                    System.Console.WriteLine("You must decide quickly before the goblins overrun your position.\n" +
                                            "Please chose 1 or 2");
                    Console.Clear();
                    break;
            }


        }
        private void ArriveAtOverrunVillage()
        {
            Clear();
            System.Console.WriteLine("As you reach the main gate of the city you hear...\n" +
                                            " Down the path to the Upper Village a loud wailing sound\n" +
                                            " Down the path to the Lower Village a cry for help\n" +
                                            "Press any key to continue.. ");
            ReadKey();
            Clear();
            System.Console.WriteLine($"So {playerName} which path do you chose go down first to save this village from the goblin unslaught\n" +
                                    "1. Take the Path to the Upper Village.\n" +
                                    "2. Take the Path to the Lower Village.\n" +
                                    "3. Run away trembling in fear of what you have seen and heard....");
            var userInput = ReadLine();
            switch (userInput)
            {
                case "1":
                    PathToUpperVillage();
                    break;

                case "2":
                    PathToLowerVillage();
                    break;

                case "3":
                    RunAway();
                    break;

                default:
                    System.Console.WriteLine($"{playerName}, you must make a choice. Do not be afraid...");
                    break;
            }
        }

        private void PathToUpperVillage()
        {
            // bool rescuedUpperVillage = false;
            while (!hasLeftUpperVillage)
            {
                Clear();
                System.Console.WriteLine($"{playerName} reaches the Upper Village and see the devastation a group of goblins are leaving in their wake\n" +
                                         "Only you can stop the destruction of the Homes in the Upper Village but...\n" +
                                         $"{playerName} still have to face the Master of the goblins to end this...\n");
                ReadKey();
                Clear();
                System.Console.WriteLine($"{playerName}, you have a split second to decide before you are noticed...\n" +
                                        $"1. Charge in and attack the goblins destroying Homes in Upper Village\n" +
                                        "2. Try to sneak around the goblins and find their leader");
                var userInput = ReadLine();
                switch (userInput)
                {
                    case "1":
                        AttackUpperVillage();
                        break;

                    case "2":
                        SneakAroundUpperVillage();
                        break;

                    default:
                        System.Console.WriteLine($"{playerName}, you must act now or perish!!");
                        break;
                }
            }
        }
        private void AttackUpperVillage()
        {
            System.Console.WriteLine("You charge in to stop the goblins from destroying more homes.\n" +
                                    "As you move in closer the leader of the group steps out to confront you...");
            var randomGoblin = _villageEnemyRepo.GetEnemy(1);
            randomGoblin.EnemyAttack(newHero);
            while (randomGoblin.HealthPoints > 0)
            {
                System.Console.WriteLine("Its your turn to attack\n" +
                                        "1. Shoot an arrow at the enemy.\n" +
                                        "2. Use your sword to attack the goblin\n" +
                                        "3. Drink your potion to replinish health.");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        newHero.ShootBowAndArrow(randomGoblin);
                        break;
                    case 2:
                        newHero.SwordAttack(randomGoblin);
                        break;
                    case 3:
                        newHero.DrinkPotion();
                        break;
                    default:
                        System.Console.WriteLine("Invalid Selection");
                        randomGoblin.EnemyAttack(newHero);
                        break;
                }
            }

            System.Console.WriteLine("You defeat the Random Goblin!!\n" +
                                    "The rest of the goblins run towards the safety of the Keep.");
            _rescuedUpperVillage = true;
            MainGate();
        }

        private void SneakAroundUpperVillage()
        {
            Clear();
            System.Console.WriteLine(" You successfully sneak past the goblins ransacking homes...\n" +
                                    "We will have to return later ");
            MainGate();
        }

        private void PathToLowerVillage()
        {
            // bool rescuedLowerVillage = false;
            while (!hasLeftLowerVillage)
            {
                Clear();
                System.Console.WriteLine($"{playerName} reaches the Lower Village and see the horror a group of goblins are leaving in their wake\n" +
                                        "Only you can stop the destruction of the marketplace in the Lower Village but...\n" +
                                        $"{playerName} still have to face the Master of the goblins to end this...\n");
                ReadKey();
                Clear();
                System.Console.WriteLine($"{playerName}, you have a split second to decide before you are noticed...\n" +
                                        $"1. Charge in and attack the goblins destroying the marketplace in the Lower Village\n" +
                                        "2. Try to sneak around the goblins\n");
                var userInput = ReadLine();
                switch (userInput)
                {
                    case "1":
                        AttackLowerVillage();
                        break;

                    case "2":
                        SneakAroundLowerVillage();
                        break;

                    default:
                        System.Console.WriteLine($"{playerName}, you must act now or perish!!");
                        break;
                }
            }
        }

        private void AttackLowerVillage()
        {
            Console.Clear();
            System.Console.WriteLine($"{playerName} charges in hoping to prevent further destruction of the economic center of the town.\n" +
                                    "As you move in closer the leader of the group steps out to confront you...");
            var randomGoblin2 = _villageEnemyRepo.GetEnemy(3);

            try
            {
                while (randomGoblin2.HealthPoints > 0)
                {
                    randomGoblin2.EnemyAttack(newHero);
                    System.Console.WriteLine("Its your turn to attack... Be mindful of your health\n" +
                                            $"1. Shoot an arrow at the {randomGoblin2.Name}.\n" +
                                            $"2. Use your sword to attack the {randomGoblin2.Name}\n" +
                                            "3. Drink your potion to replenish health.");
                    int userInput = int.Parse(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            newHero.ShootBowAndArrow(randomGoblin2);
                            break;
                        case 2:
                            newHero.SwordAttack(randomGoblin2);
                            break;
                        case 3:
                            newHero.DrinkPotion();
                            break;
                        default:
                            System.Console.WriteLine("Invalid Selection");
                            randomGoblin2.EnemyAttack(newHero);
                            break;
                    }
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine("AWLE.... Bad selection.. Press any key to continue");
                Console.ReadKey();
            }

            System.Console.WriteLine("You defeat the Goblin Preist!\n" +
                                    "The rest of the goblins run towards the safety of the Keep.");
            _rescuedLowerVillage = true;
            MainGate();
        }

        private void SneakAroundLowerVillage()
        {
            if (_rescuedUpperVillage == true)
            {
                Console.Clear();
                System.Console.WriteLine("The only way forward is to fight the goblins here...\n" +
                                        $"Prepare {playerName} the enemy is coming...");
                AttackLowerVillage();
            }
            else
            {
                System.Console.WriteLine("You are able to successfully make it pass the enemies back to the main area of the village.");
                MainGate();
            }
        }
        private void RunAway()
        {
            Clear();
            System.Console.WriteLine("As you turn to run a swarm of goblins seize you from behind\n" +
                                        "They begin dragging you back to their lair as you slowly fade into oblivion....\n");
            ReadKey();
            System.Console.WriteLine("You have passed into the void and left the kingdom open to destruction...");
            ReadKey();
            isRunning=ExitApplication();

        }
    }
}

