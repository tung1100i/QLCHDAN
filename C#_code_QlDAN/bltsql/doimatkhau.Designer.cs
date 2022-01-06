namespace bltsql
{
    partial class doimatkhau
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
            this.tendn = new System.Windows.Forms.Label();
            this.mkcu = new System.Windows.Forms.Label();
            this.mkmoi = new System.Windows.Forms.Label();
            this.nlmk = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndoimk = new System.Windows.Forms.Button();
            this.txttdn = new System.Windows.Forms.TextBox();
            this.txtmkc = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.txtnlmk = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tendn
            // 
            this.tendn.AutoSize = true;
            this.tendn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendn.Location = new System.Drawing.Point(191, 43);
            this.tendn.Name = "tendn";
            this.tendn.Size = new System.Drawing.Size(104, 17);
            this.tendn.TabIndex = 0;
            this.tendn.Text = "Tên đăng nhập";
            // 
            // mkcu
            // 
            this.mkcu.AutoSize = true;
            this.mkcu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkcu.Location = new System.Drawing.Point(191, 97);
            this.mkcu.Name = "mkcu";
            this.mkcu.Size = new System.Drawing.Size(90, 17);
            this.mkcu.TabIndex = 1;
            this.mkcu.Text = "Mật khẩu cũ";
            // 
            // mkmoi
            // 
            this.mkmoi.AutoSize = true;
            this.mkmoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkmoi.Location = new System.Drawing.Point(191, 150);
            this.mkmoi.Name = "mkmoi";
            this.mkmoi.Size = new System.Drawing.Size(99, 17);
            this.mkmoi.TabIndex = 2;
            this.mkmoi.Text = "Mật khẩu mới";
            // 
            // nlmk
            // 
            this.nlmk.AutoSize = true;
            this.nlmk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nlmk.Location = new System.Drawing.Point(191, 198);
            this.nlmk.Name = "nlmk";
            this.nlmk.Size = new System.Drawing.Size(125, 17);
            this.nlmk.TabIndex = 3;
            this.nlmk.Text = "Nhập lại mật khẩu";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.Location = new System.Drawing.Point(375, 241);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 37);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndoimk
            // 
            this.btndoimk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimk.ForeColor = System.Drawing.Color.Red;
            this.btndoimk.Location = new System.Drawing.Point(217, 241);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(108, 37);
            this.btndoimk.TabIndex = 5;
            this.btndoimk.Text = "Đồng ý";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // txttdn
            // 
            this.txttdn.Location = new System.Drawing.Point(330, 43);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(160, 22);
            this.txttdn.TabIndex = 6;
            // 
            // txtmkc
            // 
            this.txtmkc.Location = new System.Drawing.Point(330, 92);
            this.txtmkc.Name = "txtmkc";
            this.txtmkc.PasswordChar = '*';
            this.txtmkc.Size = new System.Drawing.Size(160, 22);
            this.txtmkc.TabIndex = 7;
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(330, 145);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.PasswordChar = '*';
            this.txtmkm.Size = new System.Drawing.Size(160, 22);
            this.txtmkm.TabIndex = 8;
            // 
            // txtnlmk
            // 
            this.txtnlmk.Location = new System.Drawing.Point(330, 193);
            this.txtnlmk.Name = "txtnlmk";
            this.txtnlmk.PasswordChar = '*';
            this.txtnlmk.Size = new System.Drawing.Size(160, 22);
            this.txtnlmk.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bltsql.Properties.Resources._1Lich_su_hinh_thanh_va_phat_trien_cua_khoa_cua;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(546, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtnlmk);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.txtmkc);
            this.Controls.Add(this.txttdn);
            this.Controls.Add(this.btndoimk);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.nlmk);
            this.Controls.Add(this.mkmoi);
            this.Controls.Add(this.mkcu);
            this.Controls.Add(this.tendn);
            this.Name = "doimatkhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.doimatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tendn;
        private System.Windows.Forms.Label mkcu;
        private System.Windows.Forms.Label mkmoi;
        private System.Windows.Forms.Label nlmk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.TextBox txttdn;
        private System.Windows.Forms.TextBox txtmkc;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.TextBox txtnlmk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}