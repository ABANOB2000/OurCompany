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

namespace OurCompany
{
    public partial class deleteform : Form
    {
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        string pos;
        int id;
        void del()
        {
            SqlCommand com;
            com = new SqlCommand("delete from Employee where E_id = " + this.id, connection.con);
            connection.con.Open();
            com.ExecuteNonQuery();
            connection.con.Close();
        }
       void Selectemployee()
        {
            da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id where Salary<5000 and  dbo.Employee.D_Id =" + comboDepar.SelectedValue, connection.con);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public deleteform()
        {
            try
            {
                InitializeComponent();
                button1.Enabled = false;
            }
            catch
            {
                return;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


            SqlCommand com;
            com = new SqlCommand("delete from Employee where E_id = " + this.id, connection.con);
            connection.con.Open();
            com.ExecuteNonQuery();
            connection.con.Close();
            Selectemployee();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            button1.Enabled = true;
            this.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value );
            label1.Text = "E_id = " + this.id;

           
        }

        private void deleteform_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ad;
            DataTable dt = new DataTable();
            try
            {
                ad = new SqlDataAdapter("select * from Department", connection.con);
                ad.Fill(dt);
                comboDepar.DataSource = dt;
                comboDepar.DisplayMember = "D_Name";
                comboDepar.ValueMember = "D_id";
                comboDepar.Text = "";
            }
            catch
            {
                return;
            }
        }

        private void comboDepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Selectemployee();
            }
            catch
            {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id where Salary<5000 and  dbo.Employee.D_Id =" + comboDepar.SelectedValue+" and Name like '%" + textBox1.Text + "%'", connection.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
