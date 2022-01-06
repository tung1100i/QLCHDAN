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
    public partial class thutuc1 : Form
    {
        public thutuc1()
        {
            InitializeComponent();
        }

        DataSet GetAllkh()
        {
            DataSet data = new DataSet();
            string query = "sp_tkkh N'" + txt1.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btntk1_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = GetAllkh().Tables[0];
        }

        DataSet GetAlldiachi()
        {
            DataSet data = new DataSet();
            string query = " execute dsnv_theoTinh N'" + txt2.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btntk2_Click(object sender, EventArgs e)
        {
            dgv2.DataSource = GetAlldiachi().Tables[0];
        }
    }
}
