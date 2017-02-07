using Nancy;
using ToDoList.Objects;

namespace ToDoList
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/view_all_task"] = _ => {
        Task newTask = new Task(Request.Query["new-task"]);
        return View["view_all_task.cshtml", newTask];
      };
      Post["/task_added"] = _ => {
        Task newTask = new Task (Request.Form["new-task"]);
        newTask.Save();
        return View["outputList.cshtml", newTask];
      };
    }
  }
}
