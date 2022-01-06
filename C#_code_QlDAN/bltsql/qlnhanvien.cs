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
    public partial class qlnhanvien : Form
    {
        public qlnhanvien()
        {
            InitializeComponent();
        }
      
            string strConnectionString = @"Data Source=TUNGNT\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter danhanvien = null;
            DataTable dtnhanvien = null;
            bool them;
        

        void ketnoi()
        {
                conn = new SqlConnection(strConnectionString);
                danhanvien = new SqlDataAdapter("select * from nhanvien", conn);
                dtnhanvien = new DataTable();
                dtnhanvien.Clear();
                danhanvien.Fill(dtnhanvien);
                dgvdsnhanvien.DataSource = dtnhanvien;
                this.txtmanv.ResetText();
                this.txtHoTen.ResetText();
                this.txtngaysinh.ResetText();
                this.txtdiachi.ResetText();
                this.txtgioitinh.ResetText();
                this.txtsdt.ResetText();
                this.btnluu1.Enabled = false;
                this.btnhuybo1.Enabled = false;
                this.panel1.Enabled = false;
                this.btnthem1.Enabled = true;
                this.btnsua1.Enabled = true;
                this.btnxoa1.Enabled = true;
                this.btnthoat1.Enabled = true;
            
            
        }
        private void qlnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtnhanvien.Dispose();
            dtnhanvien = null;
            conn = null;
        }
        public static string quyen;
        private void qlnhanvien_Load(object sender, EventArgs e)
        {
            ketnoi();
            
        }
        int index;

        private void dgvdsnhanvien_Click(object sender, EventArgs e)
        {
            index = dgvdsnhanvien.CurrentRow.Index;
            txtmanv.Text = dgvdsnhanvien.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dgvdsnhanvien.Rows[index].Cells[1].Value.ToString();
            txtngaysinh.Text = dgvdsnhanvien.Rows[index].Cells[2].Value.ToString();
            txtdiachi.Text = dgvdsnhanvien.Rows[index].Cells[3].Value.ToString();
            txtgioitinh.Text = dgvdsnhanvien.Rows[index].Cells[4].Value.ToString();
            txtsdt.Text = dgvdsnhanvien.Rows[index].Cells[5].Value.ToString();

        }
  

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnthem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                them = true;
                this.txtmanv.ResetText();
                this.txtHoTen.ResetText();
                this.txtngaysinh.ResetText();
                this.txtdiachi.ResetText();
                this.txtgioitinh.ResetText();
                this.txtsdt.ResetText();
                this.btnluu1.Enabled = true;
                this.btnhuybo1.Enabled = true;
                this.panel1.Enabled = true;
                this.btnthem1.Enabled = false;
                this.btnsua1.Enabled = false;
                this.btnxoa1.Enabled = false;
                this.btnthoat1.Enabled = false;
                this.txtmanv.Focus();

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

        private void btnreload1_Click(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btnsua1_Click(object sender, EventArgs e)
        {
            them = false;
            this.panel1.Enabled = true;
            int r = dgvdsnhanvien.CurrentCell.RowIndex;
            this.txtmanv.Text = dgvdsnhanvien.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text = dgvdsnhanvien.Rows[r].Cells[1].Value.ToString();
            this.txtngaysinh.Text = dgvdsnhanvien.Rows[r].Cells[2].Value.ToString();
            this.txtdiachi.Text = dgvdsnhanvien.Rows[r].Cells[3].Value.ToString();
            this.txtgioitinh.Text = dgvdsnhanvien.Rows[r].Cells[4].Value.ToString();
            this.txtsdt.Text = dgvdsnhanvien.Rows[r].Cells[5].Value.ToString();
            this.btnluu1.Enabled = true;
            this.btnhuybo1.Enabled = true;
            this.panel1.Enabled = true;
            this.btnthem1.Enabled = false;
            this.btnsua1.Enabled = false;
            this.btnxoa1.Enabled = false;
            this.btnthoat1.Enabled = false;
            this.txtmanv.Focus();
        }
        string xoanhanvien;
        string xoahoadon;
        string xoanhapkho;
        private void btnxoa1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = xoahoadon = "delete hoadonra where manv='" + txtmanv.Text + "'";
                cmd.CommandText = xoanhapkho = "delete nhapkho where manv='" + txtmanv.Text + "'";
                cmd.CommandText = xoanhanvien = "delete nhanvien where manv='" + txtmanv.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                ketnoi();
                MessageBox.Show("đã xóa xong");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("không cho phép xóa do có liên kết với quản lí hóa đơn và nhập kho,xóa hóa đơn và nhập kho của những nhân viên đã nghỉ!!");
            }
        }

        private void btnhuybo1_Click(object sender, EventArgs e)
        {
            this.txtmanv.ResetText();
            this.txtHoTen.ResetText();
            this.txtngaysinh.ResetText();
            this.txtdiachi.ResetText();
            this.txtgioitinh.ResetText();
            this.txtsdt.ResetText();
            this.btnthem1.Enabled = true;
            this.btnsua1.Enabled = true;
            this.btnxoa1.Enabled = true;
            this.btnthoat1.Enabled = true;
            this.btnluu1.Enabled = false;
            this.btnhuybo1.Enabled = false;
            this.panel1.Enabled = false;
        }

        private void btnluu1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("insert into nhanvien values ('" + txtmanv.Text + "',N'" + txtHoTen.Text + "','" + txtngaysinh.Text + "',N'" + txtdiachi.Text + "',N'" + txtgioitinh.Text + "','" + txtsdt.Text + "')");
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
            if(!them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update nhanvien set hoten=N'" + txtHoTen.Text + "',ngaysinh='" + txtngaysinh.Text + "',diachi=N'" + txtdiachi.Text + "',gioitinh=N'" + txtgioitinh.Text + "',sodienthoai=N'" + txtsdt.Text + "' where manv='" + txtmanv.Text + "'");
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