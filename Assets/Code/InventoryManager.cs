public class InventoryManager
{
    private uint wallet; //The amount of money the player has. Max of 4.294 billon (Maybe overkill)

    private byte inventorySize = 32; //Max 255

    private InventoryItem[] inventory;

    public InventoryManager(){
        inventory = new InventoryItem[inventorySize];
    }

    //Adds an InventoryItem object to the inventory list in the first able spot.
    //Returns TRUE if able to add to list, FALSE if not
    public bool AddItemToInventory(InventoryItem item){
        for(int i = 0; i < inventorySize; i++)
        {
            if (inventory[i] != null)
            {
                inventory[i] = item;
                return true;
            }
        }
        return false;//Inventory Full
    }

    //Adds an InventoryItem object to the inventory list at the inventorySlot spot.
    //Returns TRUE if able to add to list, FALSE if not
    public bool AddItemToInventory(InventoryItem item, byte inventorySlot){
        if (inventorySlot > inventorySize)
            return false;

        if (inventory[inventorySlot] != null){
            return false; //Maybe don't do this. Could use it to swap the held item for the item in the spot.
        }else{
            inventory[inventorySlot] = item;
            return true;
        }
    }

    //Deletes InventoryItem from the inventory
    //Returns deleted InventoryItem
    public InventoryItem DropItemFromInventory(byte inventorySlot){
        if(inventory[inventorySlot] != null){
            InventoryItem droppedItem = inventory[inventorySlot];
            inventory[inventorySlot] = null;
            return droppedItem;
        }
        else{
            return null;
        }
    }
}
