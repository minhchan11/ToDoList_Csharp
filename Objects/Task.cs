using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class Task
  {
    // Declare private variables that we will use
    private string _description;
    private int _id;
    // Make a list of all instances
    private static List<Task> _instances = new List<Task>{};
    // Create a public object from the original
    public Task (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }
    //Set,Get only for private variables
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Task> GetAll()
    {
      return _instances;
    }
    //Methods to clear all instances in List
    public static void ClearAll()
    {
      _instances.Clear();
    }
    //Method to search and find instances in List
    public static Task Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
