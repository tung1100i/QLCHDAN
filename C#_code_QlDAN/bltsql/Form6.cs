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
    public partial class Form6 : Form
    {
        

        public Form6()
        {
            InitializeComponent();
        }

        private void btnform6_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllsanpham().Tables[0];
        }
        DataSet GetAllsanpham()
        {
            DataSet data = new DataSet();
            string query = "select * from sanpham";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }
        private void btnthoatform6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
