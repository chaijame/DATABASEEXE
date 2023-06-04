using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    

    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.AppSettings["connectionString"];
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public static int ExecuteSql(String sql)
        {
            Form1 form = new Form1();
            SqlConnection con = new SqlConnection(form.connectionString);
            SqlCommand cmd = new SqlCommand(sql,con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        public static DataSet Query(String sql)
        {
            Form1 form = new Form1();
            SqlConnection con = new SqlConnection(form.connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "students");
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sid = textBox1.Text.Trim();
            string sname = textBox2.Text.Trim();
            this.studentsList.DataSource = Query("select * from students where sid like '%" + sid + "%' and sname like '%" + sname + "%'").Tables["students"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = studentsList.CurrentRow.Index;
            string sid = studentsList.Rows[a].Cells[0].Value.ToString().Trim();
            string sql = "delete from students where sid ='" + sid + "'";
            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 childrenForm = new Form2();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int b = studentsList.CurrentRow.Index;
            string sid = studentsList.Rows[b].Cells[0].Value.ToString().Trim();
            string sname = studentsList.Rows[b].Cells[1].Value.ToString().Trim();
            string email = studentsList.Rows[b].Cells[2].Value.ToString().Trim();
            string grade = studentsList.Rows[b].Cells[3].Value.ToString().Trim();
            Form3 update = new Form3(sid,sname,email,grade);
            update.Owner = this;
            update.Show();
        }
    }
}

