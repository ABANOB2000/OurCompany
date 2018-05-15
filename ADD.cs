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
    public partial class ADD : Form
    {
        SqlCommand com;
        SqlDataAdapter ad;
        DataTable dt = new DataTable();
        int id;
        public ADD()
        {
            InitializeComponent();
        }

        private void ADD_Load(object sender, EventArgs e)
        {
            if (ManegarOrEmployee.res == null)
            {
                ManegarOrEmployee ask = new ManegarOrEmployee();
                ask.Show();
                this.Close();
            }
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

            label.Text = ManegarOrEmployee.res;
            but_AddNew.Enabled = false;
            
            
        }
        void insert ()
        {

            
                com = new SqlCommand("select Max(E_id) from Employee", connection.con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                this.id = Convert.ToInt32(dr[0]) + 1;
                connection.con.Close();
                connection.con.Open();
                SqlCommand com2 = new SqlCommand("insert into Employee values (" + this.id + ",'" + textname.Text + "','" + textadress.Text + "','" + DateTime.Now.ToShortDateString() + "','" + textphone.Text + "'," + textsalary.Text + " ," + comboDepar.SelectedValue+")" , connection.con);
                com2.ExecuteNonQuery();
                connection.con.Close();
            
            
        }
        private void but_AddNew_Click(object sender, EventArgs e)
        {
            
            connection.con.Open();
            switch (ManegarOrEmployee.res)
            {

                case "Eployee":
                    insert();
                    
                    break;
                case "Maneger":
                    insert();
                    connection.con.Open();
                    SqlCommand com3 = new SqlCommand("update Maneger set M_id=" + this.id + "where D_id='" + comboDepar.SelectedValue + "'");
                    com3.ExecuteNonQuery();
                    connection.con.Close();
                    break;
            }
            connection.con.Close();
            MessageBox.Show("Item has been added","add",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation );
           
        }
        private void comboDepar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                but_AddNew.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void ADD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ManegarOrEmployee.res != null)
            {
                DialogResult res2;
                res2= MessageBox.Show("do you want another add ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res2 == DialogResult.Yes)
                {
                    ManegarOrEmployee.res = null;
                    ManegarOrEmployee ask = new ManegarOrEmployee();
                    ask.Show();
                    this.Close();

                }
                else
                {
                    ManegarOrEmployee.res = null;
                }
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ManegarOrEmployee.res = comboBox1.Text;
                label.Text = ManegarOrEmployee.res;
            }
            catch
            {
                return;
            }
        }
    }
}
