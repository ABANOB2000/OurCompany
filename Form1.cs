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
using System.Threading;

namespace OurCompany
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
           

        }

        private void but_Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Login_Click(object sender, EventArgs e)
        {
            
          //  List<SqlParameter> ParamList = new List<SqlParameter>(2);
            
            SqlParameter [] pram =new SqlParameter [2];
            pram[0]=new SqlParameter ("@ID",SqlDbType .Int  );
            pram[1]=new SqlParameter ("@USER",SqlDbType .NVarChar ,25);
            pram[0].Value  = pass.Text;
            pram[1].Value = user.Text;

            SqlCommand comm = new SqlCommand("select * from DataUsers where Id= @ID and username = @USER", connection.con);
            comm.Parameters.AddRange(pram);
            connection.con.Open();
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
       
            if (dr.HasRows)
            {

                this.Close();
                th = new Thread(opennnewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }

            else
                MessageBox.Show("UserName or Password is Invaled ","Erorr",MessageBoxButtons.OK ,MessageBoxIcon.Error );
            connection.con.Close();

        }

        private void opennnewform(object obj)
        {
            Application.Run(new Mian());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

      
        
    }
}
