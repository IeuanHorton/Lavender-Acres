enum ItemType {Equipment, Catchable, Furniture}

public class InventoryItem
{
    private string itemName;
    private ItemType itemType;
    private ushort value, sellValue; //Theres prob a good way to just get 80% of the value to pass as the sell value, but that can come later

    public ushort getSellValue(){
        return sellValue;
    }

    public ushort getValue(){
        return value;
    }

    public int getItemType()
    {
        return (int)itemType;
    }

    public string getItemName()
    {
        return itemName;
    }
}
