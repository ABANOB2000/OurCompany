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
    public  partial class Mian : Form
    {
       // public static Mian x = this;
       
    
        SqlDataAdapter ad;
        DataTable dt = new DataTable ();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
       public  void selectmaneger()
        {
            try
            {
                ad = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id  where  Salary>=5000 and dbo.Employee.D_Id = " + Depar.SelectedValue, connection.con);
                dt2.Clear();
                ad.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            catch
            {
                return;
            }
        }
       public void Selectemployee()
        {
            ad = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id  where  Salary<5000 and dbo.Employee.D_Id =" + Depar.SelectedValue, connection.con);
            dt2.Clear();
            ad.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        public Mian()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void Mian_Load(object sender, EventArgs e)
        {
            try
            {
                
                ad = new SqlDataAdapter("select * from Department", connection.con);
                ad.Fill(dt);
                Depar.DisplayMember = "D_Name";
                Depar.ValueMember = "D_id";
                Depar.DataSource = dt;
                Depar.Text = "";
            }
            catch
            {
                return;
            }

        }

        

        private void Depar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Focus();
            comboBox2.Text = "";
           /* try
            {
                dt1.Clear();
                ad = new SqlDataAdapter("select * from Employee where D_Id =" + Depar.SelectedValue, connection.con);
                ad.Fill(dt1);
                dataGridView1.DataSource = dt1;
                comboBox2.DataSource = dt1;
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "E_id";
                comboBox2.Text = "";
                
            }
            catch (Exception ex)
            {
                return;
            }*/
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           string pos = comboBox2.Text;
            switch (pos)
            {
                case "Maneger":
                    selectmaneger();
                    textBox1.Enabled = false;
                    break;
                case "Employee":
                    Selectemployee();
                    textBox1.Enabled = true;
                    break;
            }
           /* try
            {
                dt2.Clear();
                ad = new SqlDataAdapter("SELECT dbo.Employee.*, dbo.Department.D_Name FROM dbo.Department INNER JOIN dbo.Employee ON dbo.Department.D_id = dbo.Employee.D_Id where E_id =" + comboBox2.SelectedValue, connection.con);
                ad.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            catch
            {
                return;
            }*/


        }

       

        

        private void aLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report re = new report();
            SqlDataAdapter sda = new SqlDataAdapter("select * from View_1", connection.con);
            sda.Fill(re.company2DataSet.View_1);
            re.reportViewer1.RefreshReport();
            re.Show();
        }

        private void mANAGERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report re = new report();

            SqlDataAdapter sda = new SqlDataAdapter("select * from View_1 where Salary>=5000 ", connection.con);
            sda.Fill(re.company2DataSet.View_1);
            re.reportViewer1.RefreshReport();
            re.Show();
        }

        private void eMPOLYEESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report re = new report();
            SqlDataAdapter sda = new SqlDataAdapter("select * from View_1 where Salary<5000 ", connection.con);
            sda.Fill(re.company2DataSet.View_1);
            re.reportViewer1.RefreshReport();
            re.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD ad = new ADD();
            ad.ShowDialog(); 
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateform updata = new updateform();
            updata.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteform del = new deleteform();
            del.ShowDialog();
        }

        private void printORViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt1.Clear();
            ad = new SqlDataAdapter("select * from Employee where Name like '%" + textBox1.Text + "%' and D_Id = " + Depar.SelectedValue + " and Salary<5000", connection.con);
            ad.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // menuStrip1.Enabled = false;
           // main.Enabled = false;
           // first.Enabled = true;
           // second.Enabled = false;
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //menuStrip1.Enabled = false;

        }

      

        



       

       
    }
}
