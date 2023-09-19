
using static System.Console;
using PairProgramming.Data.Entities;
using PairProgramming.Data.Entities.PlayerEntities;
using PairProgramming.Repository.Enemy_Repository;
using PairProgramming.Data.Entities.EnemyEntities;
namespace PairProgramming.UI
{
    
    public class ProgramUI
    {   
        public static  Player newHero = new Player();
        public bool rescuedUpperVillage;
        public bool rescuedLowerVillage;
        private bool isRunning = true; 
        public string playerName;
        // private readonly ProjectItemRepo _projRepo = new ProjectItemRepo();
        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while(isRunning)
            {
                // Game code goes here 
                System.Console.WriteLine("Welcome to Code Warriors\n"+
                "1. Start Game\n"+
                "2. Exit App\n");

                string userInput = ReadLine()!;

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
                System.Console.WriteLine($"Welcome {playerName} to the land of Middle Earth.\n"+ "Your quest is just beginning\n" +
                                            $"Press any Key to Continue...");
                ReadKey();
                Clear();
                System.Console.WriteLine("You have been tasked with saving a village from rutheless goblins\n"+
                                        "The goblins have destroyed portions of the village and surrounding farmlands....\n"+
                                        "You must defeat The Goblin Lord and any other foes that cross your path\n"+  
                                            "Press any key to continue.. ");
                MainGate();
        }

        private void MainGate()
        {
            
        }

        private void PathToUpperVillage()
        {
            bool rescuedUpperVillage = false;
            while (!hasLeftUpperVillage)
            {
                Clear(); 
                System.Console.WriteLine($"{playerName} reaches the Upper Village and see the devastation a group of goblins are leaving in their wake\n"+
                                         "Only you can stop the destruction of the Homes in the Upper Village but...\n"+
                                         $"{playerName} still have to face the Master of the goblins to end this...\n"+);
                ReadKey();
                Clear();
                System.Console.WriteLine($"{playerName}, you have a split second to decide before you are noticed...\n"+
                                        $"1. Charge in and attack the goblins destroying Homes in Upper Village\n"+
                                        "2. Try to sneak around the goblins and find their leader");
                var userInput = ReadLine();
                switch(userInput)
                {
                    case "1":
                    AttackUpperVillage();
                    break;

                    case "2": 
                }
            }
        }
        private void RunAway()
        {
            Clear();
            System.Console.WriteLine("As you turn to run a swarm of goblins seize you from behind\n"+
                                        "They begin dragging you back to their lair as you slowly fade into oblivion....\n");
            ReadKey();
            System.Console.WriteLine("You have passed into the void and left the kingdom open to destruction...");
            ExitApplication();

        }
    }
}

