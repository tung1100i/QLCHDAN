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
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();
        }

        private void btnform5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllhoadon().Tables[0];
        }
        DataSet GetAllhoadon()
        {
            DataSet data = new DataSet();
            string query = "select * from hoadonra";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btnthoatform5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
