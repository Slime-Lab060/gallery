namespace Rensyu07
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSu1 = new System.Windows.Forms.TextBox();
            this.txtSu2 = new System.Windows.Forms.TextBox();
            this.txtSu3 = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSu1
            // 
            this.txtSu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSu1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSu1.Location = new System.Drawing.Point(25, 32);
            this.txtSu1.Multiline = true;
            this.txtSu1.Name = "txtSu1";
            this.txtSu1.Size = new System.Drawing.Size(70, 39);
            this.txtSu1.TabIndex = 0;
            this.txtSu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSu1.TextChanged += new System.EventHandler(this.txtSu1_TextChanged);
            // 
            // txtSu2
            // 
            this.txtSu2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSu2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSu2.Location = new System.Drawing.Point(111, 32);
            this.txtSu2.Multiline = true;
            this.txtSu2.Name = "txtSu2";
            this.txtSu2.Size = new System.Drawing.Size(70, 39);
            this.txtSu2.TabIndex = 1;
            this.txtSu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSu2.TextChanged += new System.EventHandler(this.txtSu2_TextChanged);
            // 
            // txtSu3
            // 
            this.txtSu3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSu3.Location = new System.Drawing.Point(197, 32);
            this.txtSu3.Multiline = true;
            this.txtSu3.Name = "txtSu3";
            this.txtSu3.Size = new System.Drawing.Size(70, 39);
            this.txtSu3.TabIndex = 2;
            this.txtSu3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSu3.TextChanged += new System.EventHandler(this.txtSu3_TextChanged);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMax.Location = new System.Drawing.Point(44, 89);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(92, 48);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "最大値";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(160, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 48);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMax
            // 
            this.txtMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMax.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMax.Location = new System.Drawing.Point(111, 189);
            this.txtMax.Multiline = true;
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(70, 39);
            this.txtMax.TabIndex = 6;
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(107, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "最大値";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.txtSu3);
            this.Controls.Add(this.txtSu2);
            this.Controls.Add(this.txtSu1);
            this.Name = "Form1";
            this.Text = "最大値表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSu1;
        private System.Windows.Forms.TextBox txtSu2;
        private System.Windows.Forms.TextBox txtSu3;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label1;
    }
}

