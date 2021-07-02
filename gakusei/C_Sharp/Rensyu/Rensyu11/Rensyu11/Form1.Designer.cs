namespace Rensyu11
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
            this.cmbMaker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKisyu = new System.Windows.Forms.ComboBox();
            this.btnKok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaker = new System.Windows.Forms.Label();
            this.lblKisyu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMaker
            // 
            this.cmbMaker.FormattingEnabled = true;
            this.cmbMaker.Items.AddRange(new object[] {
            "ＳＯＮＹ",
            "ＮＥＣ",
            "ＦＵＪＩＴＳＵ",
            "ＴＯＳＨＩＢＡ",
            "ＩＢＭ"});
            this.cmbMaker.Location = new System.Drawing.Point(25, 62);
            this.cmbMaker.Name = "cmbMaker";
            this.cmbMaker.Size = new System.Drawing.Size(77, 20);
            this.cmbMaker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "メーカー名";
            // 
            // btnMok
            // 
            this.btnMok.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMok.Location = new System.Drawing.Point(108, 34);
            this.btnMok.Name = "btnMok";
            this.btnMok.Size = new System.Drawing.Size(100, 48);
            this.btnMok.TabIndex = 2;
            this.btnMok.Text = "メーカー決定";
            this.btnMok.UseVisualStyleBackColor = true;
            this.btnMok.Click += new System.EventHandler(this.btnMok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(220, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "機種名";
            // 
            // cmbKisyu
            // 
            this.cmbKisyu.FormattingEnabled = true;
            this.cmbKisyu.Location = new System.Drawing.Point(224, 62);
            this.cmbKisyu.Name = "cmbKisyu";
            this.cmbKisyu.Size = new System.Drawing.Size(136, 20);
            this.cmbKisyu.TabIndex = 3;
            // 
            // btnKok
            // 
            this.btnKok.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKok.Location = new System.Drawing.Point(366, 34);
            this.btnKok.Name = "btnKok";
            this.btnKok.Size = new System.Drawing.Size(100, 48);
            this.btnKok.TabIndex = 5;
            this.btnKok.Text = "機種設定";
            this.btnKok.UseVisualStyleBackColor = true;
            this.btnKok.Click += new System.EventHandler(this.btnKok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKisyu);
            this.groupBox1.Controls.Add(this.lblMaker);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(25, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 96);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "決定(メーカー・機種)";
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Location = new System.Drawing.Point(18, 46);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(55, 19);
            this.lblMaker.TabIndex = 0;
            this.lblMaker.Text = "label3";
            // 
            // lblKisyu
            // 
            this.lblKisyu.AutoSize = true;
            this.lblKisyu.Location = new System.Drawing.Point(206, 46);
            this.lblKisyu.Name = "lblKisyu";
            this.lblKisyu.Size = new System.Drawing.Size(55, 19);
            this.lblKisyu.TabIndex = 1;
            this.lblKisyu.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 239);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKisyu);
            this.Controls.Add(this.btnMok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaker);
            this.Name = "Form1";
            this.Text = "メーカー・機種選択";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKisyu;
        private System.Windows.Forms.Button btnKok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKisyu;
        private System.Windows.Forms.Label lblMaker;
    }
}

