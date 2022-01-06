using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bltsql
{
    public partial class Form4 : Form
    {
        
        

        public Form4()
        {
            InitializeComponent();
        }

        private void btnform4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllkhachhang().Tables[0];
        }
        DataSet GetAllkhachhang()
        {
            DataSet data = new DataSet();
            string query = "select * from khachhang";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btnthoatform4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
