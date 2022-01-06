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
    public partial class qlsanpham : Form
    {
        public qlsanpham()
        {
            InitializeComponent();
        }

        string strConnectionString = @"Data Source=TUNGNT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dasanpham = null;
        DataTable dtsanpham = null;
        bool them;

        void ketnoi()
        {
            conn = new SqlConnection(strConnectionString);
            dasanpham = new SqlDataAdapter("select * from sanpham", conn);
            dtsanpham = new DataTable();
            dtsanpham.Clear();
            dasanpham.Fill(dtsanpham);
            dgvdssanpham.DataSource = dtsanpham;
            this.txtmasp.ResetText();
            this.txttensp.ResetText();
            this.txtgia.ResetText();
            this.btnluu4.Enabled = false;
            this.btnhuybo4.Enabled = false;
            this.groupBox4.Enabled = false;
            this.btnthem4.Enabled = true;
            this.btnsua4.Enabled = true;
            this.btnxoa4.Enabled = true;
            this.btnthoat4.Enabled = true;


        }
        private void qlnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtsanpham.Dispose();
            dtsanpham = null;
            conn = null;
        }

        private void qlsanpham_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        int index;

        private void dgvdssanpham_Click(object sender, EventArgs e)
        {
            index = dgvdssanpham.CurrentRow.Index;
            txtmasp.Text = dgvdssanpham.Rows[index].Cells[0].Value.ToString();
            txttensp.Text = dgvdssanpham.Rows[index].Cells[1].Value.ToString();
            txtgia.Text = dgvdssanpham.Rows[index].Cells[2].Value.ToString();
        }

        private void btnthoat4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem4_Click(object sender, EventArgs e)
        {
            try
            {
                them = true;
                this.txtmasp.ResetText();
                this.txttensp.ResetText();
                this.txtgia.ResetText();
                this.btnluu4.Enabled = true;
                this.btnhuybo4.Enabled = true;
                this.groupBox4.Enabled = true;
                this.btnthem4.Enabled = false;
                this.btnsua4.Enabled = false;
                this.btnxoa4.Enabled = false;
                this.btnthoat4.Enabled = false;
                this.txtmasp.Focus();

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

        private void btnreload4_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btnsua4_Click(object sender, EventArgs e)
        {
            them = false;
            this.groupBox4.Enabled = true;
            int r = dgvdssanpham.CurrentCell.RowIndex;
            this.txtmasp.Text = dgvdssanpham.Rows[r].Cells[0].Value.ToString();
            this.txttensp.Text = dgvdssanpham.Rows[r].Cells[1].Value.ToString();
            this.txtgia.Text = dgvdssanpham.Rows[r].Cells[2].Value.ToString();
            this.btnluu4.Enabled = true;
            this.btnhuybo4.Enabled = true;
            this.groupBox4.Enabled = true;
            this.btnthem4.Enabled = false;
            this.btnsua4.Enabled = false;
            this.btnxoa4.Enabled = false;
            this.btnthoat4.Enabled = false;
            this.txtmasp.Focus();
        }


        private void btnxoa4_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete sanpham where masp='" + txtmasp.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ketnoi();
            MessageBox.Show("đã xóa xong");
            conn.Close();
        }

        private void btnhuybo4_Click(object sender, EventArgs e)
        {
            this.txtmasp.ResetText();
            this.txttensp.ResetText();
            this.txtgia.ResetText();
            this.btnthem4.Enabled = true;
            this.btnsua4.Enabled = true;
            this.btnxoa4.Enabled = true;
            this.btnthoat4.Enabled = true;
            this.btnluu4.Enabled = false;
            this.btnhuybo4.Enabled = false;
            this.groupBox4.Enabled = false;
        }

        private void btnluu4_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("insert into sanpham values ('" + txtmasp.Text + "',N'" + txttensp.Text + "','" + txtgia.Text + "')");
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
                
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update sanpham set tensp=N'" + txttensp.Text + "',giaban='" + txtgia.Text + "' where masp='" + txtmasp.Text + "'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    ketnoi();
                    MessageBox.Show("đã sửa xong");
                
            }
            conn.Close();
        }
    }

}