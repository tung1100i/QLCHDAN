namespace bltsql
{
    partial class qlnhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qlnhanvien));
            this.btnthoat1 = new System.Windows.Forms.Button();
            this.btnxoa1 = new System.Windows.Forms.Button();
            this.btnsua1 = new System.Windows.Forms.Button();
            this.btnthem1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdsnhanvien = new System.Windows.Forms.DataGridView();
            this.btnluu1 = new System.Windows.Forms.Button();
            this.btnhuybo1 = new System.Windows.Forms.Button();
            this.btnreload1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtgioitinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsnhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat1
            // 
            this.btnthoat1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat1.ForeColor = System.Drawing.Color.Black;
            this.btnthoat1.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat1.Image")));
            this.btnthoat1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat1.Location = new System.Drawing.Point(877, 294);
            this.btnthoat1.Name = "btnthoat1";
            this.btnthoat1.Size = new System.Drawing.Size(123, 49);
            this.btnthoat1.TabIndex = 26;
            this.btnthoat1.Text = "Thoát ";
            this.btnthoat1.UseVisualStyleBackColor = true;
            this.btnthoat1.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnxoa1
            // 
            this.btnxoa1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnxoa1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa1.ForeColor = System.Drawing.Color.Black;
            this.btnxoa1.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa1.Image")));
            this.btnxoa1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa1.Location = new System.Drawing.Point(877, 233);
            this.btnxoa1.Name = "btnxoa1";
            this.btnxoa1.Size = new System.Drawing.Size(123, 47);
            this.btnxoa1.TabIndex = 25;
            this.btnxoa1.Text = "Xóa";
            this.btnxoa1.UseVisualStyleBackColor = true;
            this.btnxoa1.Click += new System.EventHandler(this.btnxoa1_Click);
            // 
            // btnsua1
            // 
            this.btnsua1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua1.ForeColor = System.Drawing.Color.Black;
            this.btnsua1.Image = ((System.Drawing.Image)(resources.GetObject("btnsua1.Image")));
            this.btnsua1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua1.Location = new System.Drawing.Point(877, 168);
            this.btnsua1.Name = "btnsua1";
            this.btnsua1.Size = new System.Drawing.Size(123, 48);
            this.btnsua1.TabIndex = 24;
            this.btnsua1.Text = "Sửa";
            this.btnsua1.UseVisualStyleBackColor = true;
            this.btnsua1.Click += new System.EventHandler(this.btnsua1_Click);
            // 
            // btnthem1
            // 
            this.btnthem1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem1.ForeColor = System.Drawing.Color.Black;
            this.btnthem1.Image = ((System.Drawing.Image)(resources.GetObject("btnthem1.Image")));
            this.btnthem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem1.Location = new System.Drawing.Point(877, 97);
            this.btnthem1.Name = "btnthem1";
            this.btnthem1.Size = new System.Drawing.Size(123, 51);
            this.btnthem1.TabIndex = 23;
            this.btnthem1.Text = "Nhập";
            this.btnthem1.UseVisualStyleBackColor = true;
            this.btnthem1.Click += new System.EventHandler(this.btnthem1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdsnhanvien);
            this.groupBox2.Controls.Add(this.btnluu1);
            this.groupBox2.Controls.Add(this.btnhuybo1);
            this.groupBox2.Controls.Add(this.btnreload1);
            this.groupBox2.Location = new System.Drawing.Point(398, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(474, 411);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvdsnhanvien
            // 
            this.dgvdsnhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdsnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsnhanvien.Location = new System.Drawing.Point(14, 20);
            this.dgvdsnhanvien.Name = "dgvdsnhanvien";
            this.dgvdsnhanvien.Size = new System.Drawing.Size(459, 324);
            this.dgvdsnhanvien.TabIndex = 0;
            this.dgvdsnhanvien.Click += new System.EventHandler(this.dgvdsnhanvien_Click);
            // 
            // btnluu1
            // 
            this.btnluu1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu1.Image = global::bltsql.Properties.Resources.Save_icon;
            this.btnluu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu1.Location = new System.Drawing.Point(33, 350);
            this.btnluu1.Name = "btnluu1";
            this.btnluu1.Size = new System.Drawing.Size(120, 52);
            this.btnluu1.TabIndex = 27;
            this.btnluu1.Text = "  Lưu";
            this.btnluu1.UseVisualStyleBackColor = true;
            this.btnluu1.Click += new System.EventHandler(this.btnluu1_Click);
            // 
            // btnhuybo1
            // 
            this.btnhuybo1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuybo1.Image = global::bltsql.Properties.Resources.Close_2_icon;
            this.btnhuybo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuybo1.Location = new System.Drawing.Point(354, 350);
            this.btnhuybo1.Name = "btnhuybo1";
            this.btnhuybo1.Size = new System.Drawing.Size(120, 52);
            this.btnhuybo1.TabIndex = 29;
            this.btnhuybo1.Text = "   Hủy bỏ";
            this.btnhuybo1.UseVisualStyleBackColor = true;
            this.btnhuybo1.Click += new System.EventHandler(this.btnhuybo1_Click);
            // 
            // btnreload1
            // 
            this.btnreload1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload1.Image = global::bltsql.Properties.Resources.Button_Refresh_icon;
            this.btnreload1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreload1.Location = new System.Drawing.Point(190, 350);
            this.btnreload1.Name = "btnreload1";
            this.btnreload1.Size = new System.Drawing.Size(120, 52);
            this.btnreload1.TabIndex = 28;
            this.btnreload1.Text = "     Reload";
            this.btnreload1.UseVisualStyleBackColor = true;
            this.btnreload1.Click += new System.EventHandler(this.btnreload1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(341, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.txtgioitinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtngaysinh);
            this.panel1.Controls.Add(this.txtsdt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.txtmanv);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 340);
            this.panel1.TabIndex = 30;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.FormattingEnabled = true;
            this.txtgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtgioitinh.Location = new System.Drawing.Point(125, 248);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(200, 24);
            this.txtgioitinh.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Giới tính";
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.CustomFormat = "MM/dd/yyyy";
            this.txtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaysinh.Location = new System.Drawing.Point(125, 155);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(200, 22);
            this.txtngaysinh.TabIndex = 42;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(125, 294);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(200, 22);
            this.txtsdt.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ngày sinh";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(125, 207);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 22);
            this.txtdiachi.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Phone";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(125, 105);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 34;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(125, 58);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(200, 22);
            this.txtmanv.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã nhân viên";
            // 
            // qlnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnthoat1);
            this.Controls.Add(this.btnxoa1);
            this.Controls.Add(this.btnsua1);
            this.Controls.Add(this.btnthem1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "qlnhanvien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.qlnhanvien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsnhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat1;
        private System.Windows.Forms.Button btnxoa1;
        private System.Windows.Forms.Button btnsua1;
        private System.Windows.Forms.Button btnthem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdsnhanvien;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnluu1;
        private System.Windows.Forms.Button btnreload1;
        private System.Windows.Forms.Button btnhuybo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
        private System.Windows.Forms.ComboBox txtgioitinh;
        private System.Windows.Forms.Label label6;
    }
}