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
    public partial class Form7 : Form
    {
        

        public Form7()
        {
            InitializeComponent();
        }

        private void btnform7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllnhapkho().Tables[0];
        }
        DataSet GetAllnhapkho()
        {
            DataSet data = new DataSet();
            string query = "select * from nhapkho";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btnthoatform7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
