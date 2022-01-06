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
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllnhanvien().Tables[0];
        }
        DataSet GetAllnhanvien()
        {
            DataSet data = new DataSet();
            string query = "select * from nhanvien";
            using (SqlConnection con=new SqlConnection(ConnectionString.connectionString))
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
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

}
