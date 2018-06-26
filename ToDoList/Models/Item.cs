namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    public Item (string description)
    {
        _description = description; //uncomment to get test to pass
    }
    public string GetDescription()
    {
      return _description;
    }
  }
}
