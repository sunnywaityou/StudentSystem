namespace winStudent
{
    partial class stu_query
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_xuehao = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_age = new System.Windows.Forms.TextBox();
            this.tbx_xueli = new System.Windows.Forms.TextBox();
            this.tbx_zhuanye = new System.Windows.Forms.TextBox();
            this.tbx_hobby = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "专业：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "爱好：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "学历：";
            // 
            // tbx_xuehao
            // 
            this.tbx_xuehao.Location = new System.Drawing.Point(110, 56);
            this.tbx_xuehao.Name = "tbx_xuehao";
            this.tbx_xuehao.Size = new System.Drawing.Size(100, 21);
            this.tbx_xuehao.TabIndex = 6;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(300, 56);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 21);
            this.tbx_name.TabIndex = 7;
            // 
            // tbx_age
            // 
            this.tbx_age.Location = new System.Drawing.Point(110, 116);
            this.tbx_age.Name = "tbx_age";
            this.tbx_age.Size = new System.Drawing.Size(100, 21);
            this.tbx_age.TabIndex = 8;
            // 
            // tbx_xueli
            // 
            this.tbx_xueli.Location = new System.Drawing.Point(300, 116);
            this.tbx_xueli.Name = "tbx_xueli";
            this.tbx_xueli.Size = new System.Drawing.Size(100, 21);
            this.tbx_xueli.TabIndex = 9;
            // 
            // tbx_zhuanye
            // 
            this.tbx_zhuanye.Location = new System.Drawing.Point(110, 185);
            this.tbx_zhuanye.Name = "tbx_zhuanye";
            this.tbx_zhuanye.Size = new System.Drawing.Size(100, 21);
            this.tbx_zhuanye.TabIndex = 10;
            // 
            // tbx_hobby
            // 
            this.tbx_hobby.Location = new System.Drawing.Point(300, 185);
            this.tbx_hobby.Multiline = true;
            this.tbx_hobby.Name = "tbx_hobby";
            this.tbx_hobby.Size = new System.Drawing.Size(156, 95);
            this.tbx_hobby.TabIndex = 11;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(505, 257);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // stu_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 338);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tbx_hobby);
            this.Controls.Add(this.tbx_zhuanye);
            this.Controls.Add(this.tbx_xueli);
            this.Controls.Add(this.tbx_age);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.tbx_xuehao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stu_query";
            this.Text = "个人信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_xuehao;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_age;
        private System.Windows.Forms.TextBox tbx_xueli;
        private System.Windows.Forms.TextBox tbx_zhuanye;
        private System.Windows.Forms.TextBox tbx_hobby;
        private System.Windows.Forms.Button btn_close;
    }
}