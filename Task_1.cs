// Порушенно принцип God object
// Розділяй і властвуй

class Item
{

}
class OrderStorage
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }

    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}

class DeleteOrder
{
    public void Delete(OrderStorage order) {/*...*/}
}

class UpdateOrder
{
    public void Update(OrderStorage order) {/*...*/}
}
class ShowMyOrder
{
    public void ShowOrder(OrderStorage order) {/*...*/}
}

class PrintMyOrder
{
    public void PrintOrder(OrderStorage order) {/*...*/}
}
class CalculateOrderTotalSum
{
    public void CalculateTotalSum(OrderStorage order) {/*...*/}
}
class GetOrderInfo
{
    public void GetItems(OrderStorage order) {/*...*/}
    public void GetItemCount(OrderStorage order) {/*...*/}
}

class OrderManager
{
    public void Load(OrderStorage order) {/*...*/}
    public void Save(OrderStorage order) {/*...*/}
}


