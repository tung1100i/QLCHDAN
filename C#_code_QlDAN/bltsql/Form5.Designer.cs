namespace bltsql
{
    partial class Form5
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
            this.btnform5 = new System.Windows.Forms.Button();
            this.btnthoatform5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnform5
            // 
            this.btnform5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnform5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnform5.Location = new System.Drawing.Point(536, 402);
            this.btnform5.Name = "btnform5";
            this.btnform5.Size = new System.Drawing.Size(76, 32);
            this.btnform5.TabIndex = 11;
            this.btnform5.Text = "Xem";
            this.btnform5.UseVisualStyleBackColor = true;
            this.btnform5.Click += new System.EventHandler(this.btnform5_Click);
            // 
            // btnthoatform5
            // 
            this.btnthoatform5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatform5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthoatform5.Location = new System.Drawing.Point(647, 402);
            this.btnthoatform5.Name = "btnthoatform5";
            this.btnthoatform5.Size = new System.Drawing.Size(75, 32);
            this.btnthoatform5.TabIndex = 10;
            this.btnthoatform5.Text = "Thoát";
            this.btnthoatform5.UseVisualStyleBackColor = true;
            this.btnthoatform5.Click += new System.EventHandler(this.btnthoatform5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 279);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDM.Location = new System.Drawing.Point(273, 17);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(244, 32);
            this.lblDM.TabIndex = 8;
            this.lblDM.Text = "Danh mục hóa đơn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnform5);
            this.Controls.Add(this.btnthoatform5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDM);
            this.Name = "Form5";
            this.Text = "Danh mục hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnform5;
        private System.Windows.Forms.Button btnthoatform5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDM;
    }
}