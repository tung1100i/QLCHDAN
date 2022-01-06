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
    public partial class Ham1 : Form
    {
        public Ham1()
        {
            InitializeComponent();
        }

        DataSet GetAlltonkho()
        {
            DataSet data = new DataSet();
            string query = "select * from tongtonkho('"+txttonkho.Text+"')";
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
            dgv1.DataSource = GetAlltonkho().Tables[0];
        }

        DataSet GetAllngaysinh()
        {
            DataSet data = new DataSet();
            string query = "select * from BangNV('" + txtngaysinh.Text + "')";
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
            dgv2.DataSource = GetAllngaysinh().Tables[0];
        }
    }
}
