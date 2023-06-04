namespace WindowsFormsApp2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.add_grade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_sname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_sid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_grade
            // 
            this.add_grade.Location = new System.Drawing.Point(566, 255);
            this.add_grade.Name = "add_grade";
            this.add_grade.Size = new System.Drawing.Size(100, 28);
            this.add_grade.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "年级：";
            // 
            // add_sname
            // 
            this.add_sname.Location = new System.Drawing.Point(566, 121);
            this.add_sname.Name = "add_sname";
            this.add_sname.Size = new System.Drawing.Size(100, 28);
            this.add_sname.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "姓名：";
            // 
            // add_email
            // 
            this.add_email.Location = new System.Drawing.Point(254, 255);
            this.add_email.Name = "add_email";
            this.add_email.Size = new System.Drawing.Size(100, 28);
            this.add_email.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "邮箱：";
            // 
            // add_sid
            // 
            this.add_sid.Location = new System.Drawing.Point(254, 121);
            this.add_sid.Name = "add_sid";
            this.add_sid.Size = new System.Drawing.Size(100, 28);
            this.add_sid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "学号：";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_grade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add_sname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_sid);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "学生信息添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox add_grade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox add_sname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox add_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox add_sid;
        private System.Windows.Forms.Label label1;
    }
}