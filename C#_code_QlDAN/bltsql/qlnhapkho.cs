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
    public partial class qlnhapkho : Form
    {
        public qlnhapkho()
        {
            InitializeComponent();
        }
        string strConnectionString = @"Data Source=TUNGNT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter danhapkho = null;
        DataTable dtnhapkho = null;
        bool them;


        void ketnoi()
        {
            conn = new SqlConnection(strConnectionString);
            danhapkho = new SqlDataAdapter("select * from nhapkho", conn);
            dtnhapkho = new DataTable();
            dtnhapkho.Clear();
            danhapkho.Fill(dtnhapkho);
            dgvdsnhapkho.DataSource = dtnhapkho;
            this.txtmaspnhap.ResetText();
            this.txttenspnhap.ResetText();
            this.txtsl.ResetText();
            this.txtgia.ResetText();
            this.txtngaynhap.ResetText();
            this.txttonkho.ResetText();
            this.txtmanv.ResetText();
            this.btnluu5.Enabled = false;
            this.btnhuybo5.Enabled = false;
            this.groupBox5.Enabled = false;
            this.btnthem5.Enabled = true;
            this.btnsua5.Enabled = true;
            this.btnxoa5.Enabled = true;
            this.btnthoat5.Enabled = true;


        }
        private void qlsanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtnhapkho.Dispose();
            dtnhapkho = null;
            conn = null;
        }

        private void qlnhapkho_Load(object sender, EventArgs e)
        {
            ketnoi();
        }
        int index;

        private void dgvdsnhapkho_Click(object sender, EventArgs e)
        {
            index = dgvdsnhapkho.CurrentRow.Index;
            txtmaspnhap.Text = dgvdsnhapkho.Rows[index].Cells[0].Value.ToString();
            txttenspnhap.Text = dgvdsnhapkho.Rows[index].Cells[1].Value.ToString();
            txtsl.Text = dgvdsnhapkho.Rows[index].Cells[2].Value.ToString();
            txtgia.Text = dgvdsnhapkho.Rows[index].Cells[3].Value.ToString();
            txtngaynhap.Text = dgvdsnhapkho.Rows[index].Cells[4].Value.ToString();
            txttonkho.Text = dgvdsnhapkho.Rows[index].Cells[5].Value.ToString();
            txtmanv.Text = dgvdsnhapkho.Rows[index].Cells[6].Value.ToString();
        }

        private void btnthoat5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem5_Click(object sender, EventArgs e)
        {
            try
            {
                them = true;
                this.txtmaspnhap.ResetText();
                this.txttenspnhap.ResetText();
                this.txtsl.ResetText();
                this.txtgia.ResetText();
                this.txtngaynhap.ResetText();
                this.txttonkho.ResetText();
                this.txtmanv.ResetText();
                this.btnluu5.Enabled = true;
                this.btnhuybo5.Enabled = true;
                this.groupBox5.Enabled = true;
                this.btnthem5.Enabled = false;
                this.btnsua5.Enabled = false;
                this.btnxoa5.Enabled = false;
                this.btnthoat5.Enabled = false;
                this.txtmaspnhap.Focus();

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

        private void btnreload5_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btnsua5_Click(object sender, EventArgs e)
        {
            them = false;
            this.groupBox5.Enabled = true;
            int r = dgvdsnhapkho.CurrentCell.RowIndex;
            this.txtmaspnhap.Text = dgvdsnhapkho.Rows[r].Cells[0].Value.ToString();
            this.txttenspnhap.Text = dgvdsnhapkho.Rows[r].Cells[1].Value.ToString();
            this.txtsl.Text = dgvdsnhapkho.Rows[r].Cells[2].Value.ToString();
            this.txtgia.Text = dgvdsnhapkho.Rows[r].Cells[3].Value.ToString();
            this.txtngaynhap.Text = dgvdsnhapkho.Rows[r].Cells[4].Value.ToString();
            this.txttonkho.Text = dgvdsnhapkho.Rows[r].Cells[5].Value.ToString();
            this.txtmanv.Text = dgvdsnhapkho.Rows[r].Cells[6].Value.ToString();
            this.btnluu5.Enabled = true;
            this.btnhuybo5.Enabled = true;
            this.groupBox5.Enabled = true;
            this.btnthem5.Enabled = false;
            this.btnsua5.Enabled = false;
            this.btnxoa5.Enabled = false;
            this.btnthoat5.Enabled = false;
            this.txtmaspnhap.Focus();
        }

        private void btnxoa5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete nhapkho where ma='" + txtmaspnhap.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ketnoi();
            MessageBox.Show("đã xóa xong");
            conn.Close();
        }

        private void btnhuybo5_Click(object sender, EventArgs e)
        {
            this.txtmaspnhap.ResetText();
            this.txttenspnhap.ResetText();
            this.txtsl.ResetText();
            this.txtgia.ResetText();
            this.txtngaynhap.ResetText();
            this.txttonkho.ResetText();
            this.txtmanv.ResetText();
            this.btnthem5.Enabled = true;
            this.btnsua5.Enabled = true;
            this.btnxoa5.Enabled = true;
            this.btnthoat5.Enabled = true;
            this.btnluu5.Enabled = false;
            this.btnhuybo5.Enabled = false;
            this.groupBox5.Enabled = false;
        }

        private void btnluu5_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("insert into nhapkho values ('" + txtmaspnhap.Text + "',N'" + txttenspnhap.Text + "','" + txtsl.Text + "',N'" + txtgia.Text + "','" + txtngaynhap.Text + "','" + txttonkho.Text + "','" + txtmanv.Text + "')");
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
                    cmd.CommandText = ("update nhapkho set ten=N'" + txttenspnhap.Text + "',soluong='" + txtsl.Text + "',gianhap=N'" + txtgia.Text + "',ngaynhap=N'" + txtngaynhap.Text + "',tonkho=N'" + txttonkho.Text + "',manv=N'" + txtmanv.Text + "' where ma='" + txtmaspnhap.Text + "'");
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
