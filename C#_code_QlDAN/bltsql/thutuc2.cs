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
    public partial class thutuc2 : Form
    {
        public thutuc2()
        {
            InitializeComponent();
        }

        DataSet GetAllcontro()
        {
            DataSet data = new DataSet();
            string query = "tinhtong @thang='"+dateTimePicker1.Text+"'";
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
            dgv3.DataSource = GetAllcontro().Tables[0];
        }

        DataSet GetAlltinhtongtien()
        {
            DataSet data = new DataSet();
            string query = "tinhtongtien @thang='" + dateTimePicker2.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(data);
                con.Close();
            }
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv4.DataSource = GetAlltinhtongtien().Tables[0];
        }
    }
}
