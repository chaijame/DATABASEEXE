using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3(string sid,string sname,string email,string grade)
        {
            InitializeComponent();
            updatesid.Text = sid;
            updatesname.Text = sname;
            updateemail.Text = email;
            updategrade.Text = grade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sid = updatesid.Text.Trim();
            string sname = updatesname.Text.Trim();
            string email = updateemail.Text.Trim();
            string grade = updategrade.Text.Trim();
            string sql = "update STUDENTS set sname='" + sname + "', email='" + email + "', grade='" + grade + "' where sid='" + sid + "'";
            if (Form1.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
            this.Close();
        }
    }
}
