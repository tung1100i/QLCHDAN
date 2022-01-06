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
    public partial class qlhoadon : Form
    {
        public qlhoadon()
        {
            InitializeComponent();
        }

        string strConnectionString = @"Data Source=TUNGNT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dahoadon = null;
        DataTable dthoadon = null;
        bool them;


        void ketnoi()
        {
            conn = new SqlConnection(strConnectionString);
            dahoadon = new SqlDataAdapter("select * from hoadonra", conn);
            dthoadon = new DataTable();
            dthoadon.Clear();
            dahoadon.Fill(dthoadon);
            dgvdshoadon.DataSource = dthoadon;
            this.txtmahd.ResetText();
            this.txtmasp.ResetText();
            this.txtsl.ResetText();
            this.txttt.ResetText();
            this.txtngayban.ResetText();
            this.txtmanv.ResetText();
            this.btnluu3.Enabled = false;
            this.btnhuybo3.Enabled = false;
            this.groupBox1.Enabled = false;
            this.btnthem3.Enabled = true;
            this.btnsua3.Enabled = true;
            this.btnxoa3.Enabled = true;
            this.btnthoat3.Enabled = true;
        }

        private void qlhoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            dthoadon.Dispose();
            dthoadon = null;
            conn = null;
        }

        private void qlhoadon_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        int index;

        private void dgvdshoadon_Click(object sender, EventArgs e)
        {
            index = dgvdshoadon.CurrentRow.Index;
            txtmahd.Text = dgvdshoadon.Rows[index].Cells[0].Value.ToString();
            txtmasp.Text = dgvdshoadon.Rows[index].Cells[1].Value.ToString();
            txtsl.Text = dgvdshoadon.Rows[index].Cells[2].Value.ToString();
            txttt.Text = dgvdshoadon.Rows[index].Cells[3].Value.ToString();
            txtngayban.Text = dgvdshoadon.Rows[index].Cells[4].Value.ToString();
            txtmanv.Text = dgvdshoadon.Rows[index].Cells[5].Value.ToString();
        }

        private void btnthoat3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem3_Click(object sender, EventArgs e)
        {
            try
            {
                them = true;
                this.txtmahd.ResetText();
                this.txtmasp.ResetText();
                this.txtsl.ResetText();
                this.txttt.ResetText();
                this.txtngayban.ResetText();
                this.txtmanv.ResetText();
                this.btnluu3.Enabled = true;
                this.btnhuybo3.Enabled = true;
                this.groupBox1.Enabled = true;
                this.btnthem3.Enabled = false;
                this.btnsua3.Enabled = false;
                this.btnxoa3.Enabled = false;
                this.btnthoat3.Enabled = false;
                this.txtmahd.Focus();

            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-Q5MH825;Initial Catalog=BTLCSDL;Integrated Security=True");
                kn.Close();
            }
        }

        private void btnreload3_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btnsua3_Click(object sender, EventArgs e)
        {
            them = false;
            this.groupBox1.Enabled = true;
            int r = dgvdshoadon.CurrentCell.RowIndex;
            this.txtmahd.Text = dgvdshoadon.Rows[r].Cells[0].Value.ToString();
            this.txtmasp.Text = dgvdshoadon.Rows[r].Cells[1].Value.ToString();
            this.txtsl.Text = dgvdshoadon.Rows[r].Cells[2].Value.ToString();
            this.txttt.Text = dgvdshoadon.Rows[r].Cells[3].Value.ToString();
            this.txtngayban.Text = dgvdshoadon.Rows[r].Cells[4].Value.ToString();
            this.txtmanv.Text = dgvdshoadon.Rows[r].Cells[5].Value.ToString();
            this.btnluu3.Enabled = true;
            this.btnhuybo3.Enabled = true;
            this.groupBox1.Enabled = true;
            this.btnthem3.Enabled = false;
            this.btnsua3.Enabled = false;
            this.btnxoa3.Enabled = false;
            this.btnthoat3.Enabled = false;
            this.txtmanv.Focus();
        }

        string xoakhachhang;
        string xoahoadon;

        private void btnxoa3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = xoakhachhang = "delete khachhang where mahdr='" + txtmahd.Text + "'";
                cmd.CommandText = xoahoadon = "delete hoadonra where mahdr='" + txtmahd.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ketnoi();
                MessageBox.Show("đã xóa xong");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("không thể xóa hóa đơn, hãy xóa mã hóa đơn ở bảng khách hàng trước");
            }
        }

        private void btnhuybo3_Click(object sender, EventArgs e)
        {
            this.txtmahd.ResetText();
            this.txtmasp.ResetText();
            this.txtsl.ResetText();
            this.txttt.ResetText();
            this.txtngayban.ResetText();
            this.txtmanv.ResetText();
            this.btnthem3.Enabled = true;
            this.btnsua3.Enabled = true;
            this.btnxoa3.Enabled = true;
            this.btnthoat3.Enabled = true;
            this.btnluu3.Enabled = false;
            this.btnhuybo3.Enabled = false;
            this.groupBox1.Enabled = false;
        }

        private void btnluu3_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("insert into hoadonra values ('" + txtmahd.Text + "','" + txtmasp.Text + "','" + txtsl.Text + "','" + txttt.Text + "','" + txtngayban.Text + "','" + txtmanv.Text + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    ketnoi();
                    MessageBox.Show("đã thêm xong");
                }
                catch (SqlException)
                {
                    MessageBox.Show("không thể thêm, lỗi rồi!!");
                }


            }
            if (!them)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update hoadonra set masp='" + txtmasp.Text + "',soluong='" + txtsl.Text + "',thanhtien='" + txttt.Text + "',ngayban='" + txtngayban.Text + "',manv='" + txtmanv.Text + "' where mahdr='" + txtmahd.Text + "'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    ketnoi();
                    MessageBox.Show("đã sửa xong");
                }
                catch (SqlException)
                {
                    MessageBox.Show("không thể sửa, lỗi rồi!!");
                }
            }
            conn.Close();
        }
    }
}
