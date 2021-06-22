namespace Rensyu06
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
            this.txtAtai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKaijo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAtai
            // 
            this.txtAtai.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAtai.Location = new System.Drawing.Point(11, 35);
            this.txtAtai.Multiline = true;
            this.txtAtai.Name = "txtAtai";
            this.txtAtai.Size = new System.Drawing.Size(93, 48);
            this.txtAtai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(110, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "の";
            // 
            // txtKaijo
            // 
            this.txtKaijo.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKaijo.Location = new System.Drawing.Point(170, 35);
            this.txtKaijo.Multiline = true;
            this.txtKaijo.Name = "txtKaijo";
            this.txtKaijo.Size = new System.Drawing.Size(93, 48);
            this.txtKaijo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "乗は";
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAns.Location = new System.Drawing.Point(118, 110);
            this.txtAns.Multiline = true;
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(145, 48);
            this.txtAns.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(269, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "です";
            // 
            // btnKei
            // 
            this.btnKei.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKei.Location = new System.Drawing.Point(244, 176);
            this.btnKei.Name = "btnKei";
            this.btnKei.Size = new System.Drawing.Size(114, 46);
            this.btnKei.TabIndex = 6;
            this.btnKei.Text = "計算";
            this.btnKei.UseVisualStyleBackColor = true;
            this.btnKei.Click += new System.EventHandler(this.btnKei_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 239);
            this.Controls.Add(this.btnKei);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKaijo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtai);
            this.Name = "Form1";
            this.Text = "指数計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKaijo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKei;
    }
}

