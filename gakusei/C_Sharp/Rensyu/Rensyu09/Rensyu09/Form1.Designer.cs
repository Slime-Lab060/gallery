namespace Rensyu09
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optJpn = new System.Windows.Forms.RadioButton();
            this.optFra = new System.Windows.Forms.RadioButton();
            this.optIta = new System.Windows.Forms.RadioButton();
            this.optUsa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optRen = new System.Windows.Forms.RadioButton();
            this.optGm = new System.Windows.Forms.RadioButton();
            this.optToy = new System.Windows.Forms.RadioButton();
            this.optFer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optIta);
            this.groupBox1.Controls.Add(this.optUsa);
            this.groupBox1.Controls.Add(this.optFra);
            this.groupBox1.Controls.Add(this.optJpn);
            this.groupBox1.Location = new System.Drawing.Point(27, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "国名";
            // 
            // optJpn
            // 
            this.optJpn.AutoSize = true;
            this.optJpn.Location = new System.Drawing.Point(6, 34);
            this.optJpn.Name = "optJpn";
            this.optJpn.Size = new System.Drawing.Size(61, 16);
            this.optJpn.TabIndex = 0;
            this.optJpn.TabStop = true;
            this.optJpn.Text = "JAPAN";
            this.optJpn.UseVisualStyleBackColor = true;
            // 
            // optFra
            // 
            this.optFra.AutoSize = true;
            this.optFra.Location = new System.Drawing.Point(6, 69);
            this.optFra.Name = "optFra";
            this.optFra.Size = new System.Drawing.Size(69, 16);
            this.optFra.TabIndex = 1;
            this.optFra.TabStop = true;
            this.optFra.Text = "FRANCE";
            this.optFra.UseVisualStyleBackColor = true;
            // 
            // optIta
            // 
            this.optIta.AutoSize = true;
            this.optIta.Location = new System.Drawing.Point(6, 138);
            this.optIta.Name = "optIta";
            this.optIta.Size = new System.Drawing.Size(54, 16);
            this.optIta.TabIndex = 3;
            this.optIta.TabStop = true;
            this.optIta.Text = "ITALY";
            this.optIta.UseVisualStyleBackColor = true;
            // 
            // optUsa
            // 
            this.optUsa.AutoSize = true;
            this.optUsa.Location = new System.Drawing.Point(6, 103);
            this.optUsa.Name = "optUsa";
            this.optUsa.Size = new System.Drawing.Size(111, 16);
            this.optUsa.TabIndex = 2;
            this.optUsa.TabStop = true;
            this.optUsa.Text = "UNITED STATES";
            this.optUsa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optRen);
            this.groupBox2.Controls.Add(this.optGm);
            this.groupBox2.Controls.Add(this.optToy);
            this.groupBox2.Controls.Add(this.optFer);
            this.groupBox2.Location = new System.Drawing.Point(203, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 170);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自動車メーカ";
            // 
            // optRen
            // 
            this.optRen.AutoSize = true;
            this.optRen.Location = new System.Drawing.Point(6, 138);
            this.optRen.Name = "optRen";
            this.optRen.Size = new System.Drawing.Size(75, 16);
            this.optRen.TabIndex = 3;
            this.optRen.TabStop = true;
            this.optRen.Text = "RENAULT";
            this.optRen.UseVisualStyleBackColor = true;
            // 
            // optGm
            // 
            this.optGm.AutoSize = true;
            this.optGm.Location = new System.Drawing.Point(6, 103);
            this.optGm.Name = "optGm";
            this.optGm.Size = new System.Drawing.Size(40, 16);
            this.optGm.TabIndex = 2;
            this.optGm.TabStop = true;
            this.optGm.Text = "GM";
            this.optGm.UseVisualStyleBackColor = true;
            // 
            // optToy
            // 
            this.optToy.AutoSize = true;
            this.optToy.Location = new System.Drawing.Point(6, 69);
            this.optToy.Name = "optToy";
            this.optToy.Size = new System.Drawing.Size(68, 16);
            this.optToy.TabIndex = 1;
            this.optToy.TabStop = true;
            this.optToy.Text = "TOYOTA";
            this.optToy.UseVisualStyleBackColor = true;
            // 
            // optFer
            // 
            this.optFer.AutoSize = true;
            this.optFer.Location = new System.Drawing.Point(6, 34);
            this.optFer.Name = "optFer";
            this.optFer.Size = new System.Drawing.Size(72, 16);
            this.optFer.TabIndex = 0;
            this.optFer.TabStop = true;
            this.optFer.Text = "FERRARI";
            this.optFer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "判定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "神経衰弱";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optIta;
        private System.Windows.Forms.RadioButton optUsa;
        private System.Windows.Forms.RadioButton optFra;
        private System.Windows.Forms.RadioButton optJpn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optRen;
        private System.Windows.Forms.RadioButton optGm;
        private System.Windows.Forms.RadioButton optToy;
        private System.Windows.Forms.RadioButton optFer;
        private System.Windows.Forms.Button button1;
    }
}

