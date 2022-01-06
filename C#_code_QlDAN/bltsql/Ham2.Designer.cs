namespace bltsql
{
    partial class Ham2
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
            this.txtsp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntk1 = new System.Windows.Forms.Button();
            this.btntk2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsp2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntk1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsp);
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàm in ra dsnv đã bán sản phẩm nào đó";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntk2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtsp2);
            this.groupBox2.Controls.Add(this.dgv2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(485, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 541);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hàm đếm lượng hóa đơn khi bán sản phẩm nào đó";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(9, 54);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(441, 245);
            this.dgv1.TabIndex = 0;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(6, 54);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(441, 245);
            this.dgv2.TabIndex = 1;
            // 
            // txtsp
            // 
            this.txtsp.Location = new System.Drawing.Point(67, 370);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(298, 22);
            this.txtsp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên sản phẩm";
            // 
            // btntk1
            // 
            this.btntk1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntk1.Image = global::bltsql.Properties.Resources.Search_icon;
            this.btntk1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntk1.Location = new System.Drawing.Point(148, 429);
            this.btntk1.Name = "btntk1";
            this.btntk1.Size = new System.Drawing.Size(125, 42);
            this.btntk1.TabIndex = 3;
            this.btntk1.Text = "       Tìm kiếm";
            this.btntk1.UseVisualStyleBackColor = true;
            this.btntk1.Click += new System.EventHandler(this.btntk1_Click);
            // 
            // btntk2
            // 
            this.btntk2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntk2.Image = global::bltsql.Properties.Resources.Search_icon;
            this.btntk2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntk2.Location = new System.Drawing.Point(158, 429);
            this.btntk2.Name = "btntk2";
            this.btntk2.Size = new System.Drawing.Size(125, 42);
            this.btntk2.TabIndex = 6;
            this.btntk2.Text = "       Tìm kiếm";
            this.btntk2.UseVisualStyleBackColor = true;
            this.btntk2.Click += new System.EventHandler(this.btntk2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập tên sản phẩm";
            // 
            // txtsp2
            // 
            this.txtsp2.Location = new System.Drawing.Point(77, 370);
            this.txtsp2.Name = "txtsp2";
            this.txtsp2.Size = new System.Drawing.Size(298, 22);
            this.txtsp2.TabIndex = 4;
            // 
            // Ham2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(939, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ham2";
            this.Text = "Hàm 2";
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
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btntk1;
        private System.Windows.Forms.Button btntk2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsp2;
    }
}