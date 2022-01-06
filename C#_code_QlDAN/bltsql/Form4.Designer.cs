namespace bltsql
{
    partial class Form4
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
            this.btnform4 = new System.Windows.Forms.Button();
            this.btnthoatform4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnform4
            // 
            this.btnform4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnform4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnform4.Location = new System.Drawing.Point(536, 402);
            this.btnform4.Name = "btnform4";
            this.btnform4.Size = new System.Drawing.Size(76, 32);
            this.btnform4.TabIndex = 7;
            this.btnform4.Text = "Xem";
            this.btnform4.UseVisualStyleBackColor = true;
            this.btnform4.Click += new System.EventHandler(this.btnform4_Click);
            // 
            // btnthoatform4
            // 
            this.btnthoatform4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatform4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthoatform4.Location = new System.Drawing.Point(647, 402);
            this.btnthoatform4.Name = "btnthoatform4";
            this.btnthoatform4.Size = new System.Drawing.Size(75, 32);
            this.btnthoatform4.TabIndex = 6;
            this.btnthoatform4.Text = "Thoát";
            this.btnthoatform4.UseVisualStyleBackColor = true;
            this.btnthoatform4.Click += new System.EventHandler(this.btnthoatform4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 279);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDM.Location = new System.Drawing.Point(273, 17);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(285, 32);
            this.lblDM.TabIndex = 4;
            this.lblDM.Text = "Danh mục khách hàng";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnform4);
            this.Controls.Add(this.btnthoatform4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDM);
            this.Name = "Form4";
            this.Text = "danh mục khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnform4;
        private System.Windows.Forms.Button btnthoatform4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDM;
    }
}