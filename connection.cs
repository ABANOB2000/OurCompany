using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OurCompany
{
   static  class connection
    {
      public static  SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=company2;Integrated Security=True");
    }
}
