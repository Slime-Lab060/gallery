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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblKigo = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.optTasu = new System.Windows.Forms.RadioButton();
            this.optKakeru = new System.Windows.Forms.RadioButton();
            this.optWaru = new System.Windows.Forms.RadioButton();
            this.optHiku = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNum1.Location = new System.Drawing.Point(26, 26);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(121, 41);
            this.txtNum1.TabIndex = 0;
            // 
            // lblKigo
            // 
            this.lblKigo.AutoSize = true;
            this.lblKigo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKigo.Location = new System.Drawing.Point(153, 29);
            this.lblKigo.Name = "lblKigo";
            this.lblKigo.Size = new System.Drawing.Size(47, 33);
            this.lblKigo.TabIndex = 1;
            this.lblKigo.Text = "＋";
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtNum2.Location = new System.Drawing.Point(200, 26);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(121, 41);
            this.txtNum2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(327, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAns.Location = new System.Drawing.Point(374, 26);
            this.txtAns.Multiline = true;
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(121, 41);
            this.txtAns.TabIndex = 4;
            // 
            // optTasu
            // 
            this.optTasu.AutoSize = true;
            this.optTasu.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.optTasu.Location = new System.Drawing.Point(138, 95);
            this.optTasu.Name = "optTasu";
            this.optTasu.Size = new System.Drawing.Size(93, 28);
            this.optTasu.TabIndex = 5;
            this.optTasu.TabStop = true;
            this.optTasu.Text = "足し算";
            this.optTasu.UseVisualStyleBackColor = true;
            this.optTasu.CheckedChanged += new System.EventHandler(this.optTasu_Checked);
            // 
            // optKakeru
            // 
            this.optKakeru.AutoSize = true;
            this.optKakeru.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.optKakeru.Location = new System.Drawing.Point(138, 129);
            this.optKakeru.Name = "optKakeru";
            this.optKakeru.Size = new System.Drawing.Size(96, 28);
            this.optKakeru.TabIndex = 6;
            this.optKakeru.TabStop = true;
            this.optKakeru.Text = "掛け算";
            this.optKakeru.UseVisualStyleBackColor = true;
            this.optKakeru.CheckedChanged += new System.EventHandler(this.optKakeru_Checked);
            // 
            // optWaru
            // 
            this.optWaru.AutoSize = true;
            this.optWaru.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.optWaru.Location = new System.Drawing.Point(284, 129);
            this.optWaru.Name = "optWaru";
            this.optWaru.Size = new System.Drawing.Size(91, 28);
            this.optWaru.TabIndex = 8;
            this.optWaru.TabStop = true;
            this.optWaru.Text = "割り算";
            this.optWaru.UseVisualStyleBackColor = true;
            this.optWaru.CheckedChanged += new System.EventHandler(this.optWaru_Checked);
            // 
            // optHiku
            // 
            this.optHiku.AutoSize = true;
            this.optHiku.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.optHiku.Location = new System.Drawing.Point(284, 95);
            this.optHiku.Name = "optHiku";
            this.optHiku.Size = new System.Drawing.Size(94, 28);
            this.optHiku.TabIndex = 7;
            this.optHiku.TabStop = true;
            this.optHiku.Text = "引き算";
            this.optHiku.UseVisualStyleBackColor = true;
            this.optHiku.CheckedChanged += new System.EventHandler(this.optHiku_Checked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 189);
            this.Controls.Add(this.optWaru);
            this.Controls.Add(this.optHiku);
            this.Controls.Add(this.optKakeru);
            this.Controls.Add(this.optTasu);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblKigo);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "四則演算 (オプションボタン)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblKigo;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.RadioButton optTasu;
        private System.Windows.Forms.RadioButton optKakeru;
        private System.Windows.Forms.RadioButton optWaru;
        private System.Windows.Forms.RadioButton optHiku;
    }
}

