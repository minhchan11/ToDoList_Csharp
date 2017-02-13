using Xunit;
using ToDoList.Objects;
using System;
using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class TastTest : IDisposable
  {
    [Fact]
    public void GetDescription_TaskDescription_ReturnDescription()
    {
      //Arrange
      string descriptionTest = "cleaning";
      Task newTask = new Task(descriptionTest);
      //Act
      string getDescriptionResult = newTask.GetDescription();
      //Assert
      Assert.Equal(descriptionTest,getDescriptionResult);
    }
    [Fact]
    public void GetAll_AllTaskList_ReturnAllTasks()
    {
      //Arrange
      string description1 = "cleaning";
      string description2 = "washing";
      Task newTask1 = new Task(description1);
      Task newTask2 = new Task(description2);
      List<Task> newList = new List<Task>{newTask1,newTask2};

      //Act
      List<Task> resultList = Task.GetAll();
      foreach (Task thisTask in resultList)
      {
        Console.WriteLine("Output: " + thisTask.GetDescription());
      }
      //Assert
      Assert.Equal(newList,resultList);
    }
    public void Dispose()
    {
      Task.ClearAll();
    }
  }
}
