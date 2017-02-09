using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class Category
  {
    //declare private variables
    private static List<Category> _instances = new List<Category>{};
    private string _name;
    private int _id;
    private List<Task> _tasks;

    //Make public Objects
    public Category(string categoryName)
    {
      _name = categoryName;
      _instances.Add(this);
      _id = _instances.Count;
      _tasks = new List<Task>{};
    }

    //Getter for variables
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Task> GetTasks()
    {
      return _tasks;
    }
    //Add task to the list in the object
    public void AddTask(Task task)
    {
      _tasks.Add(task);
    }
    //Extract category by making public
    public static List<Category> GetAll()
    {
      return _instances;
    }
    //Make a function
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
