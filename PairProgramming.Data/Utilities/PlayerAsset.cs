using PairProgramming.Data.Entities.PlayerEntities;


namespace PairProgramming.Data.Utilities
{
    public class PlayerAsset
    {
        public static List<InventoryItem> InitializePlayerStartUpItems()
        {
            string [] itemInventory = File.ReadAllLines(@"/Users/brianlane/ElevenFiftyProjects/codingFoundations/dotNetprojects/assignments/consoleGame/PairProgramming.Data/Loot.txt");
            List<InventoryItem> beginningPlayerInventory = new List<InventoryItem>();
            for (int i = 0; i < itemInventory.Length; i++)
            {
                if (itemInventory[i] == "|")
                {
                    var inventoryItem = new InventoryItem
                    {
                        ID = int.Parse(itemInventory[++i]),
                        Name = itemInventory[++i],
                        UseUntilBreak = int.Parse(itemInventory[++i])
                        
                    };
                    beginningPlayerInventory.Add(inventoryItem);
                }
            }
            return beginningPlayerInventory;
        }
        public static void FoundArrow(int arrowValue, Player player)
        {
            player.AddToArrowQuiver(arrowValue);
        }
    }
}