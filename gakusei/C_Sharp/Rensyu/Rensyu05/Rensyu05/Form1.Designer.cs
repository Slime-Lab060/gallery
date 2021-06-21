namespace Rensyu05
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
            this.btnKei = new System.Windows.Forms.Button();
            this.txtAtai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKei
            // 
            this.btnKei.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKei.Location = new System.Drawing.Point(95, 78);
            this.btnKei.Name = "btnKei";
            this.btnKei.Size = new System.Drawing.Size(84, 50);
            this.btnKei.TabIndex = 0;
            this.btnKei.Text = "計算";
            this.btnKei.UseVisualStyleBackColor = true;
            this.btnKei.Click += new System.EventHandler(this.btnKei_Click);
            // 
            // txtAtai
            // 
            this.txtAtai.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAtai.Location = new System.Drawing.Point(12, 12);
            this.txtAtai.Multiline = true;
            this.txtAtai.Name = "txtAtai";
            this.txtAtai.Size = new System.Drawing.Size(86, 43);
            this.txtAtai.TabIndex = 1;
            this.txtAtai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "! =";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAns.Location = new System.Drawing.Point(173, 12);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 43);
            this.lblAns.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 146);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtai);
            this.Controls.Add(this.btnKei);
            this.Name = "Form1";
            this.Text = "階乗計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKei;
        private System.Windows.Forms.TextBox txtAtai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAns;
    }
}

