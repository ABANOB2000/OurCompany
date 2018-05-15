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
    public partial class updateform : Form
    {
       
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        string pos;
        public updateform()
        {
            InitializeComponent();
            button1.Enabled = false;
            comboBox1.Enabled = false;
            comboDepar.Focus();
        }
        void selectmaneger()
        {
            da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id  where Salary>=5000 and  dbo.Employee.D_Id =" + comboDepar.SelectedValue, connection.con);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Selectemployee()
        {
            da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id where Salary<5000 and  dbo.Employee.D_Id =" + comboDepar.SelectedValue, connection.con);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pos = comboBox1.Text;
            switch (pos)
            {
                case "Maneger":
                    selectmaneger();
                    button1.Enabled = false;
                    break;
                case "Employee":
                    Selectemployee();
                    button1.Enabled = true;
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textadress.Text  = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            textphone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textsalary.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            SqlCommand com2 = new SqlCommand("select D_Name from Department where D_id="+dataGridView1.CurrentRow.Cells[6].Value.ToString(),connection.con );
            connection.con.Open();
            SqlDataReader dr = com2.ExecuteReader();
            dr.Read();
           
            comboDepar.Text = dr[0].ToString();
            connection.con.Close();
            
        }

        private void updateform_Load(object sender, EventArgs e)
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

        private void but_update_Click(object sender, EventArgs e)
        {
            SqlCommand com,com2;
            pos = comboBox1.Text;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            switch (pos)
            {
                case "Maneger":
                    com = new SqlCommand("update Employee set Name = '" + textname.Text + "', Adress = '" + textadress.Text + "',StartDate = '" + DateTime.Now.ToShortDateString() + "', Phone = '" + textphone.Text + "', Salary = " + textsalary.Text + " , D_Id = " + comboDepar.SelectedValue +"where E_id ="+id, connection.con);
                    com2 = new SqlCommand("update Maneger set D_Id = " + comboDepar.SelectedValue + "where M_id =" + id, connection.con);
                    connection.con.Open();
                    com.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    connection.con.Close();
                    selectmaneger();
                    break;
                case "Employee":
                    com = new SqlCommand("update Employee set Name = '" + textname.Text + "', Adress = '" + textadress.Text + "',StartDate = '" + DateTime.Now.ToShortDateString() + "', Phone = '" + textphone.Text + "', Salary = " + textsalary.Text + " , D_Id = " + comboDepar.SelectedValue +"where E_id ="+id, connection.con);
                    connection.con.Open();
                    com.ExecuteNonQuery();
                    connection.con.Close();
                    Selectemployee();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textsalary.Text) >= 5000)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                connection.con.Open();
                SqlCommand com ,com2;
                com= new SqlCommand("update Maneger set M_id  = " + id + "where D_Id =" + comboDepar.SelectedValue, connection.con);
                com2 = new SqlCommand("delete from Employee where D_Id =" + comboDepar.SelectedValue, connection.con);
                com.ExecuteNonQuery();
                connection.con.Close();
            }
            else
                MessageBox.Show("Check The Salary Again", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id where Salary<5000 and  dbo.Employee.D_Id =" + comboDepar.SelectedValue + " and Name like '%" + textBox1.Text + "%'", connection.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboDepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox1.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
