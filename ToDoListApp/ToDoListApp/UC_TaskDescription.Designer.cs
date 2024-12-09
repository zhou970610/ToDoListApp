namespace ToDoListApp
{
    partial class UC_TaskDescription
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.rbDoned = new System.Windows.Forms.RadioButton();
            this.rbNotYet = new System.Windows.Forms.RadioButton();
            this.lblDueDateTitle = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(3, 14);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(87, 16);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "任務標題：";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskTitle.Location = new System.Drawing.Point(96, 11);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(342, 27);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // txtDetail
            // 
            this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetail.Location = new System.Drawing.Point(96, 127);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(342, 161);
            this.txtDetail.TabIndex = 2;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Location = new System.Drawing.Point(3, 130);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(87, 16);
            this.lblDetailTitle.TabIndex = 3;
            this.lblDetailTitle.Text = "詳細內容：";
            // 
            // rbDoned
            // 
            this.rbDoned.AutoSize = true;
            this.rbDoned.Location = new System.Drawing.Point(96, 53);
            this.rbDoned.Name = "rbDoned";
            this.rbDoned.Size = new System.Drawing.Size(73, 20);
            this.rbDoned.TabIndex = 4;
            this.rbDoned.TabStop = true;
            this.rbDoned.Text = "已完成";
            this.rbDoned.UseVisualStyleBackColor = true;
            // 
            // rbNotYet
            // 
            this.rbNotYet.AutoSize = true;
            this.rbNotYet.Location = new System.Drawing.Point(175, 53);
            this.rbNotYet.Name = "rbNotYet";
            this.rbNotYet.Size = new System.Drawing.Size(73, 20);
            this.rbNotYet.TabIndex = 5;
            this.rbNotYet.TabStop = true;
            this.rbNotYet.Text = "未完成";
            this.rbNotYet.UseVisualStyleBackColor = true;
            // 
            // lblDueDateTitle
            // 
            this.lblDueDateTitle.AutoSize = true;
            this.lblDueDateTitle.Location = new System.Drawing.Point(3, 89);
            this.lblDueDateTitle.Name = "lblDueDateTitle";
            this.lblDueDateTitle.Size = new System.Drawing.Size(87, 16);
            this.lblDueDateTitle.TabIndex = 6;
            this.lblDueDateTitle.Text = "截止日期：";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(96, 82);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 27);
            this.dtpDueDate.TabIndex = 7;
            // 
            // UC_TaskDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDueDateTitle);
            this.Controls.Add(this.rbNotYet);
            this.Controls.Add(this.rbDoned);
            this.Controls.Add(this.lblDetailTitle);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.lblTaskName);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_TaskDescription";
            this.Size = new System.Drawing.Size(441, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.RadioButton rbDoned;
        private System.Windows.Forms.RadioButton rbNotYet;
        private System.Windows.Forms.Label lblDueDateTitle;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
    }
}
