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
    public partial class Form3 : Form
    {
        SqlDataAdapter ad;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public Form3()
        {
            InitializeComponent();
             try
          {
              dt1.Clear();
              ad = new SqlDataAdapter("select * from Employee", connection.con);
              ad.Fill(dt1);
              comboBox1.DataSource = dt1;
              comboBox1.DisplayMember = "Name";
              comboBox1.ValueMember = "E_id";
              comboBox1.Text = "";
                
          }
          catch (Exception ex)
          {
              return;
          }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue+"";
        }
    }
}
