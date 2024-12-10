using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class frmToDoList : Form
    {
        private static TasksManager TasksManager = new TasksManager();
        public frmToDoList()
        {
            InitializeComponent();
            lbToDoList.Items.Clear();
        }

        private static int _id_counter=0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TasksManager.AddTask( new Task(_id_counter++,txtAdd.Text,"",DateTime.Now));
            lbToDoList.Items.AddRange(TasksManager.GetTasksWithoutAlreadyExist(lbToDoList.Items.Cast<Task>().ToList()).ToArray());
        }

        private void lbToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task SelectedTask = (Task)lbToDoList.SelectedItem;
            tdSelectedTask.SetTask(SelectedTask);
        }
    }
}
