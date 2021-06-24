namespace Rensyu08
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKin = new System.Windows.Forms.TextBox();
            this.btnKei = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.chk10000 = new System.Windows.Forms.CheckBox();
            this.chk5000 = new System.Windows.Forms.CheckBox();
            this.chk1000 = new System.Windows.Forms.CheckBox();
            this.chk2000 = new System.Windows.Forms.CheckBox();
            this.chk500 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk50 = new System.Windows.Forms.CheckBox();
            this.chk100 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "金額";
            // 
            // txtKin
            // 
            this.txtKin.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKin.Location = new System.Drawing.Point(109, 33);
            this.txtKin.Multiline = true;
            this.txtKin.Name = "txtKin";
            this.txtKin.Size = new System.Drawing.Size(132, 39);
            this.txtKin.TabIndex = 1;
            this.txtKin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKei
            // 
            this.btnKei.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKei.Location = new System.Drawing.Point(247, 33);
            this.btnKei.Name = "btnKei";
            this.btnKei.Size = new System.Drawing.Size(117, 39);
            this.btnKei.TabIndex = 2;
            this.btnKei.Text = "金種計算";
            this.btnKei.UseVisualStyleBackColor = true;
            this.btnKei.Click += new System.EventHandler(this.btnKei_Click);
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClr.Location = new System.Drawing.Point(370, 33);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(92, 42);
            this.btnClr.TabIndex = 3;
            this.btnClr.Text = "クリア";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // chk10000
            // 
            this.chk10000.AutoSize = true;
            this.chk10000.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk10000.Location = new System.Drawing.Point(30, 95);
            this.chk10000.Name = "chk10000";
            this.chk10000.Size = new System.Drawing.Size(75, 18);
            this.chk10000.TabIndex = 4;
            this.chk10000.Text = "10000円";
            this.chk10000.UseVisualStyleBackColor = true;
            // 
            // chk5000
            // 
            this.chk5000.AutoSize = true;
            this.chk5000.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk5000.Location = new System.Drawing.Point(111, 95);
            this.chk5000.Name = "chk5000";
            this.chk5000.Size = new System.Drawing.Size(68, 18);
            this.chk5000.TabIndex = 5;
            this.chk5000.Text = "5000円";
            this.chk5000.UseVisualStyleBackColor = true;
            // 
            // chk1000
            // 
            this.chk1000.AutoSize = true;
            this.chk1000.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk1000.Location = new System.Drawing.Point(280, 95);
            this.chk1000.Name = "chk1000";
            this.chk1000.Size = new System.Drawing.Size(68, 18);
            this.chk1000.TabIndex = 7;
            this.chk1000.Text = "1000円";
            this.chk1000.UseVisualStyleBackColor = true;
            // 
            // chk2000
            // 
            this.chk2000.AutoSize = true;
            this.chk2000.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk2000.Location = new System.Drawing.Point(195, 95);
            this.chk2000.Name = "chk2000";
            this.chk2000.Size = new System.Drawing.Size(68, 18);
            this.chk2000.TabIndex = 6;
            this.chk2000.Text = "2000円";
            this.chk2000.UseVisualStyleBackColor = true;
            // 
            // chk500
            // 
            this.chk500.AutoSize = true;
            this.chk500.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk500.Location = new System.Drawing.Point(363, 95);
            this.chk500.Name = "chk500";
            this.chk500.Size = new System.Drawing.Size(61, 18);
            this.chk500.TabIndex = 8;
            this.chk500.Text = "500円";
            this.chk500.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk1.Location = new System.Drawing.Point(363, 119);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(47, 18);
            this.chk1.TabIndex = 13;
            this.chk1.Text = "1円";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk5.Location = new System.Drawing.Point(280, 119);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(47, 18);
            this.chk5.TabIndex = 12;
            this.chk5.Text = "5円";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk10.Location = new System.Drawing.Point(195, 119);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(54, 18);
            this.chk10.TabIndex = 11;
            this.chk10.Text = "10円";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk50
            // 
            this.chk50.AutoSize = true;
            this.chk50.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk50.Location = new System.Drawing.Point(111, 119);
            this.chk50.Name = "chk50";
            this.chk50.Size = new System.Drawing.Size(54, 18);
            this.chk50.TabIndex = 10;
            this.chk50.Text = "50円";
            this.chk50.UseVisualStyleBackColor = true;
            // 
            // chk100
            // 
            this.chk100.AutoSize = true;
            this.chk100.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk100.Location = new System.Drawing.Point(30, 119);
            this.chk100.Name = "chk100";
            this.chk100.Size = new System.Drawing.Size(61, 18);
            this.chk100.TabIndex = 9;
            this.chk100.Text = "100円";
            this.chk100.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 157);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.chk10);
            this.Controls.Add(this.chk50);
            this.Controls.Add(this.chk100);
            this.Controls.Add(this.chk500);
            this.Controls.Add(this.chk1000);
            this.Controls.Add(this.chk2000);
            this.Controls.Add(this.chk5000);
            this.Controls.Add(this.chk10000);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnKei);
            this.Controls.Add(this.txtKin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "金融計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKin;
        private System.Windows.Forms.Button btnKei;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.CheckBox chk10000;
        private System.Windows.Forms.CheckBox chk5000;
        private System.Windows.Forms.CheckBox chk1000;
        private System.Windows.Forms.CheckBox chk2000;
        private System.Windows.Forms.CheckBox chk500;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk50;
        private System.Windows.Forms.CheckBox chk100;
    }
}

