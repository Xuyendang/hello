namespace Hello
{
    partial class Form1
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
            this.lbB = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.lbC = new System.Windows.Forms.TextBox();
            this.btTru = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbB
            // 
            this.lbB.Location = new System.Drawing.Point(56, 32);
            this.lbB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(26, 13);
            this.lbB.TabIndex = 0;
            this.lbB.Text = "số B";
            // 
            // lbA
            // 
            this.lbA.Location = new System.Drawing.Point(56, 67);
            this.lbA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(26, 13);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "số A";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(102, 67);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(151, 20);
            this.txtB.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(102, 32);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(151, 20);
            this.txtA.TabIndex = 3;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(102, 141);
            this.btCong.Margin = new System.Windows.Forms.Padding(2);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(98, 34);
            this.btCong.TabIndex = 4;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // lbC
            // 
            this.lbC.Location = new System.Drawing.Point(355, 54);
            this.lbC.Margin = new System.Windows.Forms.Padding(2);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(151, 20);
            this.lbC.TabIndex = 5;
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(297, 141);
            this.btTru.Margin = new System.Windows.Forms.Padding(2);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(98, 34);
            this.btTru.TabIndex = 6;
            this.btTru.Text = "Tru";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(102, 218);
            this.btChia.Margin = new System.Windows.Forms.Padding(2);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(98, 34);
            this.btChia.TabIndex = 7;
            this.btChia.Text = "Chia";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(297, 218);
            this.btNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(98, 34);
            this.btNhan.TabIndex = 8;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.TextBox lbC;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btNhan;
    }
}

