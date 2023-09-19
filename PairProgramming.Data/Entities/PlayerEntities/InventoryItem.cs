
namespace PairProgramming.Data.Entities.PlayerEntities
{
    public class InventoryItem
    {
        public InventoryItem()
        {
            
        }
        public InventoryItem(int id, string name, int useUntilBreak = 5)
        {
            ID = id; 
            Name = name; 
            UseUntilBreak = useUntilBreak;
        }
        public int ID { get; set; } 
        public string Name {get; set; }
        public int UseUntilBreak { get; set; }


        public bool IsUseable
        {
            get 
            {
                return (UseUntilBreak >  0) ? true : false; 
            }
        }

    }
}