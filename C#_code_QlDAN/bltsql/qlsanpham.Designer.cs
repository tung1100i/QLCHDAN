namespace bltsql
{
    partial class qlsanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qlsanpham));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat4 = new System.Windows.Forms.Button();
            this.btnxoa4 = new System.Windows.Forms.Button();
            this.btnsua4 = new System.Windows.Forms.Button();
            this.btnthem4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnluu4 = new System.Windows.Forms.Button();
            this.btnhuybo4 = new System.Windows.Forms.Button();
            this.btnreload4 = new System.Windows.Forms.Button();
            this.dgvdssanpham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtgia);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txttensp);
            this.groupBox4.Controls.Add(this.txtmasp);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(22, 36);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(356, 196);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(132, 146);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(200, 22);
            this.txtgia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giá bán";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(132, 89);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(200, 22);
            this.txttensp.TabIndex = 2;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(132, 42);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(200, 22);
            this.txtmasp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã sản phẩm";
            // 
            // btnthoat4
            // 
            this.btnthoat4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat4.ForeColor = System.Drawing.Color.Black;
            this.btnthoat4.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat4.Image")));
            this.btnthoat4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat4.Location = new System.Drawing.Point(909, 295);
            this.btnthoat4.Name = "btnthoat4";
            this.btnthoat4.Size = new System.Drawing.Size(117, 45);
            this.btnthoat4.TabIndex = 47;
            this.btnthoat4.Text = "Thoát ";
            this.btnthoat4.UseVisualStyleBackColor = true;
            this.btnthoat4.Click += new System.EventHandler(this.btnthoat4_Click);
            // 
            // btnxoa4
            // 
            this.btnxoa4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnxoa4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa4.ForeColor = System.Drawing.Color.Black;
            this.btnxoa4.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa4.Image")));
            this.btnxoa4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa4.Location = new System.Drawing.Point(909, 237);
            this.btnxoa4.Name = "btnxoa4";
            this.btnxoa4.Size = new System.Drawing.Size(117, 44);
            this.btnxoa4.TabIndex = 46;
            this.btnxoa4.Text = "Xóa";
            this.btnxoa4.UseVisualStyleBackColor = true;
            this.btnxoa4.Click += new System.EventHandler(this.btnxoa4_Click);
            // 
            // btnsua4
            // 
            this.btnsua4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua4.ForeColor = System.Drawing.Color.Black;
            this.btnsua4.Image = ((System.Drawing.Image)(resources.GetObject("btnsua4.Image")));
            this.btnsua4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua4.Location = new System.Drawing.Point(909, 170);
            this.btnsua4.Name = "btnsua4";
            this.btnsua4.Size = new System.Drawing.Size(117, 45);
            this.btnsua4.TabIndex = 45;
            this.btnsua4.Text = "Sửa";
            this.btnsua4.UseVisualStyleBackColor = true;
            this.btnsua4.Click += new System.EventHandler(this.btnsua4_Click);
            // 
            // btnthem4
            // 
            this.btnthem4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem4.ForeColor = System.Drawing.Color.Black;
            this.btnthem4.Image = ((System.Drawing.Image)(resources.GetObject("btnthem4.Image")));
            this.btnthem4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem4.Location = new System.Drawing.Point(909, 103);
            this.btnthem4.Name = "btnthem4";
            this.btnthem4.Size = new System.Drawing.Size(117, 44);
            this.btnthem4.TabIndex = 44;
            this.btnthem4.Text = "  Nhập";
            this.btnthem4.UseVisualStyleBackColor = true;
            this.btnthem4.Click += new System.EventHandler(this.btnthem4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnluu4);
            this.groupBox2.Controls.Add(this.btnhuybo4);
            this.groupBox2.Controls.Add(this.btnreload4);
            this.groupBox2.Controls.Add(this.dgvdssanpham);
            this.groupBox2.Location = new System.Drawing.Point(420, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(474, 411);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // btnluu4
            // 
            this.btnluu4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu4.Image = global::bltsql.Properties.Resources.Save_icon;
            this.btnluu4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu4.Location = new System.Drawing.Point(24, 350);
            this.btnluu4.Name = "btnluu4";
            this.btnluu4.Size = new System.Drawing.Size(120, 52);
            this.btnluu4.TabIndex = 30;
            this.btnluu4.Text = "  Lưu";
            this.btnluu4.UseVisualStyleBackColor = true;
            this.btnluu4.Click += new System.EventHandler(this.btnluu4_Click);
            // 
            // btnhuybo4
            // 
            this.btnhuybo4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuybo4.Image = global::bltsql.Properties.Resources.Close_2_icon;
            this.btnhuybo4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuybo4.Location = new System.Drawing.Point(345, 350);
            this.btnhuybo4.Name = "btnhuybo4";
            this.btnhuybo4.Size = new System.Drawing.Size(120, 52);
            this.btnhuybo4.TabIndex = 32;
            this.btnhuybo4.Text = "     Hủy bỏ";
            this.btnhuybo4.UseVisualStyleBackColor = true;
            this.btnhuybo4.Click += new System.EventHandler(this.btnhuybo4_Click);
            // 
            // btnreload4
            // 
            this.btnreload4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload4.Image = global::bltsql.Properties.Resources.Button_Refresh_icon;
            this.btnreload4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreload4.Location = new System.Drawing.Point(181, 350);
            this.btnreload4.Name = "btnreload4";
            this.btnreload4.Size = new System.Drawing.Size(120, 52);
            this.btnreload4.TabIndex = 31;
            this.btnreload4.Text = "      Reload";
            this.btnreload4.UseVisualStyleBackColor = true;
            this.btnreload4.Click += new System.EventHandler(this.btnreload4_Click);
            // 
            // dgvdssanpham
            // 
            this.dgvdssanpham.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdssanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdssanpham.Location = new System.Drawing.Point(10, 20);
            this.dgvdssanpham.Name = "dgvdssanpham";
            this.dgvdssanpham.Size = new System.Drawing.Size(459, 324);
            this.dgvdssanpham.TabIndex = 0;
            this.dgvdssanpham.Click += new System.EventHandler(this.dgvdssanpham_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(344, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "thuc-an-nhanh.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bltsql.Properties.Resources.thuc_an_nhanh;
            this.pictureBox1.Location = new System.Drawing.Point(22, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // qlsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnthoat4);
            this.Controls.Add(this.btnxoa4);
            this.Controls.Add(this.btnsua4);
            this.Controls.Add(this.btnthem4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "qlsanpham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.qlsanpham_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat4;
        private System.Windows.Forms.Button btnxoa4;
        private System.Windows.Forms.Button btnsua4;
        private System.Windows.Forms.Button btnthem4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdssanpham;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnluu4;
        private System.Windows.Forms.Button btnhuybo4;
        private System.Windows.Forms.Button btnreload4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}