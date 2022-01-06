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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Connect con = new Connect();

        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
                string ten = txtUser.Text.Trim();
                string mk = txtPass.Text.Trim();
                string sql = "select * from quyen where tentk='" + ten + "' and mk='" + mk + "' ";

            if (ten != "" || mk != "")
            {

                if (con.XemDL(sql).Rows.Count != 0)
                {
                    Form1.quyen = con.XemDL("select quyen from quyen where tentk='" + ten + "' and mk='" + mk + "' ").Rows[0][0].ToString().Trim();
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }

            }

            else
            {
                MessageBox.Show("bạn chưa nhập tài khoản và mật khẩu !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("chắc không?", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }


    }
}
