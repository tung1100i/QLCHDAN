namespace bltsql
{
    partial class Ham1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.txttonkho = new System.Windows.Forms.TextBox();
            this.btntk2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntk1 = new System.Windows.Forms.Button();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btntk1);
            this.groupBox1.Controls.Add(this.txttonkho);
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàm đưa ra lượng tồn kho của các sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtngaysinh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btntk2);
            this.groupBox2.Controls.Add(this.dgv2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(493, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 551);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hàm trả về danh sách nhân viên sinh sau ngày nào đó";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(8, 37);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(431, 317);
            this.dgv1.TabIndex = 0;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(6, 37);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(431, 317);
            this.dgv2.TabIndex = 1;
            // 
            // txttonkho
            // 
            this.txttonkho.Location = new System.Drawing.Point(49, 419);
            this.txttonkho.Name = "txttonkho";
            this.txttonkho.Size = new System.Drawing.Size(337, 22);
            this.txttonkho.TabIndex = 1;
            // 
            // btntk2
            // 
            this.btntk2.Image = global::bltsql.Properties.Resources.Search_icon;
            this.btntk2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntk2.Location = new System.Drawing.Point(158, 474);
            this.btntk2.Name = "btntk2";
            this.btntk2.Size = new System.Drawing.Size(126, 42);
            this.btntk2.TabIndex = 3;
            this.btntk2.Text = "       Tìm kiếm";
            this.btntk2.UseVisualStyleBackColor = true;
            this.btntk2.Click += new System.EventHandler(this.btntk2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(117, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập tên sản phẩm có trong kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(171, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập ngày sinh";
            // 
            // btntk1
            // 
            this.btntk1.Image = global::bltsql.Properties.Resources.Search_icon;
            this.btntk1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntk1.Location = new System.Drawing.Point(151, 474);
            this.btntk1.Name = "btntk1";
            this.btntk1.Size = new System.Drawing.Size(125, 42);
            this.btntk1.TabIndex = 2;
            this.btntk1.Text = "       Tìm kiếm";
            this.btntk1.UseVisualStyleBackColor = true;
            this.btntk1.Click += new System.EventHandler(this.btntk1_Click);
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.CustomFormat = "MM/dd/yyyy";
            this.txtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaysinh.Location = new System.Drawing.Point(72, 418);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(295, 22);
            this.txtngaysinh.TabIndex = 5;
            // 
            // Ham1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(938, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ham1";
            this.Text = "Hàm 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntk1;
        private System.Windows.Forms.TextBox txttonkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntk2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
    }
}