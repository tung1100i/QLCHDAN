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

namespace bltsql
{
    public partial class view1 : Form
    {
        public view1()
        {
            InitializeComponent();
        }

        DataSet GetAllnhanvien()
        {
            DataSet data = new DataSet();
            string query = "select * from khach";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }
        private void btnxem1_Click(object sender, EventArgs e)
        {
            dgvkh.DataSource = GetAllnhanvien().Tables[0];
        }

        DataSet GetAllhoadon()
        {
            DataSet data = new DataSet();
            string query = "select * from hoadon";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }


        private void btnmax_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = GetAllhoadon().Tables[0];
        }
        DataSet GetAlltonkho()
        {
            DataSet data = new DataSet();
            string query = "select * from viewtonkho";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }

        private void btnxem3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = GetAlltonkho().Tables[0];
        }
    }
}
