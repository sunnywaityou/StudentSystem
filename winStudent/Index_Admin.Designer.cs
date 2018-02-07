namespace winStudent
{
    partial class Index_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学员管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.教师管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学员管理ToolStripMenuItem
            // 
            this.学员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生查询ToolStripMenuItem,
            this.学生添加ToolStripMenuItem});
            this.学员管理ToolStripMenuItem.Name = "学员管理ToolStripMenuItem";
            this.学员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学员管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 学生查询ToolStripMenuItem
            // 
            this.学生查询ToolStripMenuItem.Name = "学生查询ToolStripMenuItem";
            this.学生查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生查询ToolStripMenuItem.Text = "学生查询";
            this.学生查询ToolStripMenuItem.Click += new System.EventHandler(this.学生查询ToolStripMenuItem_Click);
            // 
            // 学生添加ToolStripMenuItem
            // 
            this.学生添加ToolStripMenuItem.Name = "学生添加ToolStripMenuItem";
            this.学生添加ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.学生添加ToolStripMenuItem.Text = "学生添加";
            this.学生添加ToolStripMenuItem.Click += new System.EventHandler(this.学生添加ToolStripMenuItem_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 教师管理ToolStripMenuItem
            // 
            this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
            this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.教师管理ToolStripMenuItem.Text = "教师管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "欢迎您！";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // Index_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 439);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index_Admin";
            this.Text = "教务管理系统-管理员";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 学生添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}