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
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=TUNGNT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        private void btndoimk_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from quyen where tentk='"+txttdn.Text+"'and mk='"+txtmkc.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider2.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtmkm.Text == txtnlmk.Text)
                {
                    con.Open();
                    string daa ="update quyen set mk='" + txtmkm.Text + "' where tentk='" + txttdn.Text + "' and mk='" + txtmkc.Text + "'";
                    SqlCommand cmd = new SqlCommand(daa, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công!", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    errorProvider2.SetError(txtmkm, "bạn chưa điền mật khẩu");
                    errorProvider2.SetError(txtnlmk, "mật khẩu nhập lại chưa đúng");
                }
            }
            else
            {
                errorProvider2.SetError(txttdn, "tên người dùng không đúng");
                errorProvider2.SetError(txtmkc, "mật khẩu cũ không đúng");
            }

            }

        private void doimatkhau_Load(object sender, EventArgs e)
        {

        }
    }
    }
