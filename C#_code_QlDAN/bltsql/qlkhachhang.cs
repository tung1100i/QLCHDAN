using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace bltsql
{
    public partial class qlkhachhang : Form
    {
        public qlkhachhang()
        {
            InitializeComponent();
        }
        string strConnectionString = @"Data Source=TUNGNT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dakhachhang = null;
        DataTable dtkhachhang = null;
        bool them;


        void ketnoi()
        {
            conn = new SqlConnection(strConnectionString);
            dakhachhang = new SqlDataAdapter("select * from khachhang", conn);
            dtkhachhang = new DataTable();
            dtkhachhang.Clear();
            dakhachhang.Fill(dtkhachhang);
            dgvdskhachhang.DataSource = dtkhachhang;
            this.txtmakh.ResetText();
            this.txtHoTen.ResetText();
            this.txtdiachi.ResetText();
            this.txtsdt.ResetText();
            this.txtmahd.ResetText();
            this.btnluu2.Enabled = false;
            this.btnhuybo2.Enabled = false;
            this.panel2.Enabled = false;
            this.btnthem2.Enabled = true;
            this.btnsua2.Enabled = true;
            this.btnxoa2.Enabled = true;
            this.btnthoat2.Enabled = true;


        }

        private void qlkhachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtkhachhang.Dispose();
            dtkhachhang = null;
            conn = null;
        }

        private void qlkhachhang_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        int index;
    

        private void btnthoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem2_Click(object sender, EventArgs e)
        {
            try
            {
                them = true;
                this.txtmakh.ResetText();
                this.txtHoTen.ResetText();
                this.txtdiachi.ResetText();
                this.txtsdt.ResetText();
                this.txtmahd.ResetText();
                this.btnluu2.Enabled = true;
                this.btnhuybo2.Enabled = true;
                this.panel2.Enabled = true;
                this.btnthem2.Enabled = false;
                this.btnsua2.Enabled = false;
                this.btnxoa2.Enabled = false;
                this.btnthoat2.Enabled = false;
                this.txtmakh.Focus();

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

        private void btnreload2_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btnsua2_Click(object sender, EventArgs e)
        {
            them = false;
            this.panel2.Enabled = true;
            int r = dgvdskhachhang.CurrentCell.RowIndex;
            this.txtmakh.Text = dgvdskhachhang.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvdskhachhang.Rows[r].Cells[1].Value.ToString();
            this.txtdiachi.Text = dgvdskhachhang.Rows[r].Cells[2].Value.ToString();
            this.txtsdt.Text = dgvdskhachhang.Rows[r].Cells[3].Value.ToString();
            this.txtmahd.Text = dgvdskhachhang.Rows[r].Cells[4].Value.ToString();
            this.btnluu2.Enabled = true;
            this.btnhuybo2.Enabled = true;
            this.panel2.Enabled = true;
            this.btnthem2.Enabled = false;
            this.btnsua2.Enabled = false;
            this.btnxoa2.Enabled = false;
            this.btnthoat2.Enabled = false;
            this.txtmakh.Focus();
        }

        string xoahoadon;
        string xoakhachhang;

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = xoahoadon = "delete hoadonra where mahdr='" + txtmahd.Text + "'";
            cmd.CommandText = xoakhachhang = "delete khachhang where mahdr='" + txtmahd.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ketnoi();
            MessageBox.Show("đã xóa xong");
            conn.Close();
        }

        private void btnhuybo2_Click(object sender, EventArgs e)
        {
            this.txtmakh.ResetText();
            this.txtHoTen.ResetText();
            this.txtdiachi.ResetText();
            this.txtsdt.ResetText();
            this.txtmahd.ResetText();
            this.btnthem2.Enabled = true;
            this.btnsua2.Enabled = true;
            this.btnxoa2.Enabled = true;
            this.btnthoat2.Enabled = true;
            this.btnluu2.Enabled = false;
            this.btnhuybo2.Enabled = false;
            this.panel2.Enabled = false;
        }

        private void btnluu2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("insert into khachhang values ('" + txtmakh.Text + "',N'" + txtHoTen.Text + "','" + txtdiachi.Text + "',N'" + txtsdt.Text + "','" + txtmahd.Text + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    ketnoi();
                    MessageBox.Show("đã thêm xong");
                }
                catch (SqlException)
                {
                    MessageBox.Show("không thể thêm được, lỗi rồi!!");
                }

            }
            if (!them)
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update khachhang set tenkh=N'" + txtHoTen.Text + "',diachi=N'" + txtdiachi.Text + "',sdt=N'" + txtsdt.Text + "',mahdr=N'" + txtmahd.Text + "' where makh='" + txtmakh.Text + "'");
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

        private void dgvdskhachhang_Click(object sender, EventArgs e)
        {
            index = dgvdskhachhang.CurrentRow.Index;
            txtmakh.Text = dgvdskhachhang.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dgvdskhachhang.Rows[index].Cells[1].Value.ToString();
            txtdiachi.Text = dgvdskhachhang.Rows[index].Cells[2].Value.ToString();
            txtsdt.Text = dgvdskhachhang.Rows[index].Cells[3].Value.ToString();
            txtmahd.Text = dgvdskhachhang.Rows[index].Cells[4].Value.ToString();
        }
    }
}
