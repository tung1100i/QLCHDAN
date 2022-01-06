using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bltsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        private void danhMụcNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlnhanvien frm = new qlnhanvien();
            frm.ShowDialog();
            
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlkhachhang frm = new qlkhachhang();
            frm.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlhoadon frm = new qlhoadon();
            frm.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlsanpham frm = new qlsanpham();
            frm.ShowDialog();
        }

        private void quảnLýNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlnhapkho frm = new qlnhapkho();
            frm.ShowDialog();
        }
        public static string quyen;

        private void Form1_Load(object sender, EventArgs e)
        {
            if(quyen =="nv")
            {
                xemDanhMụcToolStripMenuItem.Enabled = false;
                quảnLýNhânViênToolStripMenuItem.Enabled = false;
                quảnLýDanhMụcTheoNhómToolStripMenuItem.Enabled = false;
                đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("chắc không?", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("chắc không?", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            doimatkhau dmk = new doimatkhau();
            dmk.ShowDialog();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view1 frm = new view1();
            frm.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Admin có quyền truy cập vào tất cả các chức năng của phần mềm quản lý cửa hàng ăn nhanh.\n" +
                "2. Nhân viên chỉ có quyền thêm sửa xóa ở các bảng quản lý khách hàng, hóa đơn, sản phẩm và nhập kho.\n" +
                "3. Nếu muốn xóa 1 nhân viên nào đó bạn phải xóa hóa đơn và nhập kho mà mã nhân viên đó tham chiếu đến, tương tự cũng như với bảng quản lý khách hàng.\n "+
                "4. Mục thống kê có tác dụng in và tìm kiếm và 1 số chức năng cập nhật tự động.\n");
        }

        private void hàm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ham1 frm = new Ham1();
            frm.ShowDialog();
        }

        private void hàm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ham2 frm = new Ham2();
            frm.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thutuc1 frm = new thutuc1();
            frm.ShowDialog();
        }

        private void okToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thutuc2 frm = new thutuc2();
            frm.ShowDialog();
        }
    }
}
