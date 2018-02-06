namespace winStudent.Admin
{
    partial class student_query
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Num = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.dgv_studentList = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // tbx_Num
            // 
            this.tbx_Num.Location = new System.Drawing.Point(107, 14);
            this.tbx_Num.Name = "tbx_Num";
            this.tbx_Num.Size = new System.Drawing.Size(120, 21);
            this.tbx_Num.TabIndex = 2;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(107, 48);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(120, 21);
            this.tbx_Name.TabIndex = 3;
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(283, 31);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 4;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // dgv_studentList
            // 
            this.dgv_studentList.AllowUserToAddRows = false;
            this.dgv_studentList.AllowUserToDeleteRows = false;
            this.dgv_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_studentList.Location = new System.Drawing.Point(0, 103);
            this.dgv_studentList.Name = "dgv_studentList";
            this.dgv_studentList.ReadOnly = true;
            this.dgv_studentList.RowTemplate.Height = 23;
            this.dgv_studentList.Size = new System.Drawing.Size(661, 267);
            this.dgv_studentList.TabIndex = 5;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(376, 31);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "修改";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(469, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // student_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 370);
            this.Controls.Add(this.dgv_studentList);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.tbx_Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "student_query";
            this.Text = "信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Num;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridView dgv_studentList;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}