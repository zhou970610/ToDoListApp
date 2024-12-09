namespace ToDoListApp
{
    partial class frmToDoList
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbToDoList = new System.Windows.Forms.ListBox();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.tdSelectedTask = new ToDoListApp.UC_TaskDescription();
            this.SuspendLayout();
            // 
            // lbToDoList
            // 
            this.lbToDoList.FormattingEnabled = true;
            this.lbToDoList.ItemHeight = 16;
            this.lbToDoList.Location = new System.Drawing.Point(18, 32);
            this.lbToDoList.Margin = new System.Windows.Forms.Padding(4);
            this.lbToDoList.Name = "lbToDoList";
            this.lbToDoList.Size = new System.Drawing.Size(277, 548);
            this.lbToDoList.TabIndex = 0;
            this.lbToDoList.SelectedIndexChanged += new System.EventHandler(this.lbToDoList_SelectedIndexChanged);
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(15, 12);
            this.lblListTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(87, 16);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "待辦清單：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(705, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "增加事項";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(302, 32);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(397, 27);
            this.txtAdd.TabIndex = 3;
            // 
            // tdSelectedTask
            // 
            this.tdSelectedTask.Font = new System.Drawing.Font("新細明體", 12F);
            this.tdSelectedTask.Location = new System.Drawing.Point(302, 66);
            this.tdSelectedTask.Margin = new System.Windows.Forms.Padding(4);
            this.tdSelectedTask.Name = "tdSelectedTask";
            this.tdSelectedTask.Size = new System.Drawing.Size(397, 297);
            this.tdSelectedTask.TabIndex = 4;
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.tdSelectedTask);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.lbToDoList);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToDoList";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbToDoList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private UC_TaskDescription tdSelectedTask;
    }
}

