using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using ToDoListApp;

namespace UnitTest
{
    [TestClass]
    public class TasksManager_UnitTest
    {
        [TestMethod]
        public void AddDuplicateTask()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var task = new ToDoListApp.Task { Id = 1, Title = "Test Task" };

            // Act
            tasksManager.AddTask(task);
            Assert.ThrowsException<ArgumentException>(() => tasksManager.AddTask(task));
        }

        [TestMethod]
        public void AddTask()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var task = new ToDoListApp.Task { Id = 1, Title = "Test Task" };

            // Act
            tasksManager.AddTask(task);
            var tasks = tasksManager.GetTasks();

            // Assert
            Assert.AreEqual(1, tasks.Count);
            Assert.IsNotNull(tasks[0]);
            Assert.AreEqual(task, tasks[0]);
            CollectionAssert.Contains(tasks, task);
        }

        [TestMethod]
        public void AddNullTask()
        {
            // Arrange
            var tasksManager = new TasksManager();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => tasksManager.AddTask(null));
        }

        [TestMethod]
        public void RemoveTask()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var task = new ToDoListApp.Task { Id = 1, Title = "Test Task" };
            tasksManager.AddTask(task);
            var task2 = new ToDoListApp.Task { Id = 2, Title = "Test Task 2" };
            tasksManager.AddTask(task2);

            // Act
            tasksManager.RemoveTask(task);

            var tasks = tasksManager.GetTasks();

            // Assert
            Assert.AreEqual(1, tasks.Count);
            Assert.AreEqual(task2, tasks[0]);
        }

        [TestMethod]
        public void RemoveNonExistentTask()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var task = new ToDoListApp.Task { Id = 1, Title = "Test Task" };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => tasksManager.RemoveTask(task));
        }

        [TestMethod]
        public void RemoveNullTask()
        {
            // Arrange
            var tasksManager = new TasksManager();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => tasksManager.RemoveTask(null));
        }

        [TestMethod]
        public void GetTasks()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var tasksList = new System.Collections.Generic.List<ToDoListApp.Task>
            {
                new ToDoListApp.Task { Id = 1, Title = "Test Task" },
                new ToDoListApp.Task { Id = 2, Title = "Test Task 2" },
                new ToDoListApp.Task { Id = 3, Title = "Test Task 3" }
            };
            foreach (var task in tasksList)
            {
                tasksManager.AddTask(task);
            }

            // Act
            var tasks = tasksManager.GetTasks();

            // Assert
            CollectionAssert.AreEqual(tasksList, tasks);
        }

        [TestMethod]
        public void GetTasks_EmptyList()
        {
            // Arrange
            var tasksManager = new TasksManager();

            // Act
            var tasks = tasksManager.GetTasks();

            // Assert
            Assert.AreEqual(0, tasks.Count);
        }

        [TestMethod]
        public void GetTasksWithoutAlreadyExist_HaveExist()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var tasksList = new System.Collections.Generic.List<ToDoListApp.Task>
            {
                new ToDoListApp.Task { Id = 1, Title = "Test Task" },
                new ToDoListApp.Task { Id = 2, Title = "Test Task 2" },
                new ToDoListApp.Task { Id = 3, Title = "Test Task 3" }
            };
            var AlreadyExistList = tasksList;
            var RandomDeleteIndex = new Random().Next(0, tasksList.Count);
            AlreadyExistList.RemoveAt(RandomDeleteIndex);

            foreach (var task in tasksList)
            {
                tasksManager.AddTask(task);
            }

            // Act
            var tasks = tasksManager.GetTasksWithoutAlreadyExist(AlreadyExistList);

            // Assert
            Assert.AreEqual(tasksList.Count, tasks.Count + AlreadyExistList.Count);
            CollectionAssert.AllItemsAreNotNull(tasks);
            CollectionAssert.AreNotEquivalent(AlreadyExistList, tasks);
        }

        [TestMethod]
        public void GetTasksWithoutAlreadyExist_HaveNotExist()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var tasksList = new System.Collections.Generic.List<ToDoListApp.Task>
            {
                new ToDoListApp.Task { Id = 1, Title = "Test Task" },
                new ToDoListApp.Task { Id = 2, Title = "Test Task 2" },
                new ToDoListApp.Task { Id = 3, Title = "Test Task 3" }
            };

            foreach (var task in tasksList)
            {
                tasksManager.AddTask(task);
            }

            // Act
            var tasks = tasksManager.GetTasksWithoutAlreadyExist(null);

            // Assert
            Assert.AreEqual(tasksList.Count, tasks.Count);
            CollectionAssert.AreEquivalent(tasksList, tasks);
        }

        [TestMethod]
        public void GetTasksWithoutAlreadyExist_EmptyAlreadyExistList()
        {
            // Arrange
            var tasksManager = new TasksManager();
            var tasksList = new System.Collections.Generic.List<ToDoListApp.Task>
            {
                new ToDoListApp.Task { Id = 1, Title = "Test Task" },
                new ToDoListApp.Task { Id = 2, Title = "Test Task 2" },
                new ToDoListApp.Task { Id = 3, Title = "Test Task 3" }
            };
            foreach (var task in tasksList)
            {
                tasksManager.AddTask(task);
            }

            // Act
            var tasks = tasksManager.GetTasksWithoutAlreadyExist(new System.Collections.Generic.List<ToDoListApp.Task>());

            // Assert
            Assert.AreEqual(tasksList.Count, tasks.Count);
            CollectionAssert.AreEquivalent(tasksList, tasks);
        }
    }
}
