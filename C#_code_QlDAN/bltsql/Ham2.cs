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
    public partial class Ham2 : Form
    {
        public Ham2()
        {
            InitializeComponent();
        }

        DataSet GetAllsanpham()
        {
            DataSet data = new DataSet();
            string query = "select * from dsnv_sanpham('" + txtsp.Text + "')";
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
            dgv1.DataSource = GetAllsanpham().Tables[0];
        }

        DataSet GetAllsanpham2()
        {
            DataSet data = new DataSet();
            string query = "select dbo.slsp_tensp('" + txtsp2.Text + "')";
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
            dgv2.DataSource = GetAllsanpham2().Tables[0];
        }
    }
}
