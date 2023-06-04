using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sid = add_sid.Text.Trim();
            string sname = add_sname.Text.Trim();
            string email = add_email.Text.Trim();
            string grade = add_grade.Text.Trim();
            string sql = "insert into students values('"+sid+"','"+sname+"','"+email+"','"+grade+"')";
            Form1.ExecuteSql(sql);
            this.Close();
        }
    }
}
