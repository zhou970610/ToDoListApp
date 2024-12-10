using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class TasksManager
    {
        private Dictionary<int,Task> Tasks = new Dictionary<int,Task>();

        public void AddTask(Task task)
        {
            if(task == null) throw new ArgumentNullException("增加失敗，項目為Null。");
            Tasks.Add(task.Id, task);
        }
        public void RemoveTask(Task task) {
            if(task == null) throw new ArgumentNullException("移除失敗，項目為Null。");
            if( Tasks.Remove(task.Id)==false) throw new ArgumentException("移除失敗，列表中無此項目。");
        }

        public Collection<Task> GetTasks()
        {
            return new Collection<Task>(Tasks.Values.ToList());
        }

        public Collection<Task> GetTasksWithoutAlreadyExist(List<Task> TaskAlreadyHave)
        {
            Collection<Task> ReturnCollenction = new Collection<Task>(Tasks.Values.ToList());
            if (TaskAlreadyHave == null) return ReturnCollenction;

            foreach (Task task in TaskAlreadyHave)
            {
                ReturnCollenction.Remove(task);
            }
            return ReturnCollenction;
        }
    }
}
