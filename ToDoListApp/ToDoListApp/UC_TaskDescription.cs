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
    public partial class UC_TaskDescription : UserControl
    {
        public UC_TaskDescription()
        {
            InitializeComponent();
        }

        public void SetTask(Task task)
        {
            txtTaskTitle.Text = task.Title;
            txtDetail.Text = task.Description;
            dtpDueDate.Text = task.DueDate.ToString("dd/MM/yyyy");
            if (task.IsDone)
            {
                rbDoned.Checked = true;
            }
            else
            {
                rbNotYet.Checked = true;
            }
        }
        
        public Task GetTaskInfo()
        {
            Task task = new Task();
            task.Title = txtTaskTitle.Text;
            task.Description = txtDetail.Text;
            task.DueDate = dtpDueDate.Value;
            task.IsDone = rbDoned.Checked;
            return task;
        }
    }
}
