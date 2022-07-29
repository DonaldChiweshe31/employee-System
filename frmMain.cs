using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class frmMain : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=INTERN3-LT;Initial Catalog=EmployeeDb;Integrated Security=True");

        public frmMain()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Emp_Details VALUES('" + textBox1.Text + "','" + textBox2.Text + "','"+textBox3.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Data Successfully");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Emp_Details SET Employee_Name='"+textBox2.Text+"',Address='"+textBox3.Text+"',Salary='"+textBox4.Text+"' WHERE Employee_Id='"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update information successfully");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Emp_Details WHERE Employee_Id='"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DELETE data Successfully");
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox3.Text = "";
        }

    }
}
