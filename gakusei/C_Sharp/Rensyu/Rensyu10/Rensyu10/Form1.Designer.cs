namespace Rensyu10
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
            this.lstJpn = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKekka = new System.Windows.Forms.TextBox();
            this.btnyaku = new System.Windows.Forms.Button();
            this.lstEng = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstJpn
            // 
            this.lstJpn.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstJpn.FormattingEnabled = true;
            this.lstJpn.ItemHeight = 24;
            this.lstJpn.Location = new System.Drawing.Point(12, 72);
            this.lstJpn.Name = "lstJpn";
            this.lstJpn.Size = new System.Drawing.Size(155, 268);
            this.lstJpn.TabIndex = 0;
            this.lstJpn.SelectedIndexChanged += new System.EventHandler(this.lstJpn_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "翻訳補助";
            // 
            // txtKekka
            // 
            this.txtKekka.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKekka.Location = new System.Drawing.Point(195, 72);
            this.txtKekka.Multiline = true;
            this.txtKekka.Name = "txtKekka";
            this.txtKekka.Size = new System.Drawing.Size(161, 34);
            this.txtKekka.TabIndex = 2;
            // 
            // btnyaku
            // 
            this.btnyaku.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnyaku.Location = new System.Drawing.Point(196, 121);
            this.btnyaku.Name = "btnyaku";
            this.btnyaku.Size = new System.Drawing.Size(159, 40);
            this.btnyaku.TabIndex = 3;
            this.btnyaku.Text = "翻訳";
            this.btnyaku.UseVisualStyleBackColor = true;
            this.btnyaku.Click += new System.EventHandler(this.btnyaku_Click);
            // 
            // lstEng
            // 
            this.lstEng.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstEng.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstEng.FormattingEnabled = true;
            this.lstEng.ItemHeight = 24;
            this.lstEng.Location = new System.Drawing.Point(173, 72);
            this.lstEng.Name = "lstEng";
            this.lstEng.Size = new System.Drawing.Size(16, 268);
            this.lstEng.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 364);
            this.Controls.Add(this.lstEng);
            this.Controls.Add(this.btnyaku);
            this.Controls.Add(this.txtKekka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstJpn);
            this.Name = "Form1";
            this.Text = "日本語→英語";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstJpn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKekka;
        private System.Windows.Forms.Button btnyaku;
        private System.Windows.Forms.ListBox lstEng;
    }
}

