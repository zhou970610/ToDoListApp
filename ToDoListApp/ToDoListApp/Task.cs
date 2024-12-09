using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }

        public Task() { }

        public Task(int id, string title, string description, DateTime dueDate)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return (Id+1).ToString() + " - " + Title;
        }
    }
}
