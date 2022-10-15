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
            this.SuspendLayout();
            // 
            // lbB
            // 
            this.lbB.Location = new System.Drawing.Point(74, 39);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(34, 16);
            this.lbB.TabIndex = 0;
            this.lbB.Text = "số B";
            // 
            // lbA
            // 
            this.lbA.Location = new System.Drawing.Point(74, 83);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(34, 16);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "số A";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(135, 33);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(135, 83);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(200, 22);
            this.txtA.TabIndex = 3;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(136, 173);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(130, 42);
            this.btCong.TabIndex = 4;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // lbC
            // 
            this.lbC.Location = new System.Drawing.Point(473, 66);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(200, 22);
            this.lbC.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbB);
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
    }
}

