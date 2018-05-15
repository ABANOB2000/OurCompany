using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurCompany
{
    public partial class ManegarOrEmployee : Form
    {
        public static string res;
        ADD ad = new ADD();
        public ManegarOrEmployee()
        {
            InitializeComponent();
        }

        private void ManegarOrEmployee_Load(object sender, EventArgs e)
        {
            string text = "Chosse Which One You Want To Add";
            label1.Text = text ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res = "Maneger";
            this.Close();
            
            ad.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            res = "Eployee";
            this.Close();
            
            ad.Show();
        }
    }
}
