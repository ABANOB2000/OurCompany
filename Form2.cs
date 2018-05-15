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
    public partial class Form2 : Form
    {
        
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        string pos;
        void selectmaneger()
        {
            da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM  dbo.Employee INNER JOIN dbo.Department ON dbo.Employee.D_Id = dbo.Department.D_id where Salary>=5000", connection.con);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void Selectemployee()
        {
            da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM  dbo.Employee INNER JOIN dbo.Department ON dbo.Employee.D_Id = dbo.Department.D_id where Salary<5000", connection.con);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public Form2()
        { 
            InitializeComponent();

            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pos = comboBox1.Text;
            switch (pos)
            {
                case "Maneger":
                   
                      
                    selectmaneger();
                  
                    break;
                case "Employee":
                    Selectemployee();
                    break;
                case"ALL":
                    da = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM  dbo.Employee INNER JOIN dbo.Department ON dbo.Employee.D_Id = dbo.Department.D_id", connection.con);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report re = new report();
            DataView dv = new DataView();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from View_1", connection.con);
            sda.Fill(dt);
            sda.Fill(re.company2DataSet.View_1);
            re.reportViewer1.RefreshReport();
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report re = new report();
            
            SqlDataAdapter sda = new SqlDataAdapter("select * from View_1 where Salary>=5000 ", connection.con);
            sda.Fill(re.company2DataSet.View_1);
            re.reportViewer1.RefreshReport();
            re.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           report re = new report();
            SqlDataAdapter sda = new SqlDataAdapter("select * from View_1 where Salary<5000 ", connection.con);
            sda.Fill(re.company2DataSet.View_1);
            re.reportViewer1.RefreshReport();
            re.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
