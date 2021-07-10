namespace Rensyu13
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.処理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データ入力開始ICtrlIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データ入力終了ECtrlEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ソートSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.昇順ACtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.降順DCtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMae6 = new System.Windows.Forms.TextBox();
            this.txtMae5 = new System.Windows.Forms.TextBox();
            this.txtMae4 = new System.Windows.Forms.TextBox();
            this.txtMae3 = new System.Windows.Forms.TextBox();
            this.txtMae2 = new System.Windows.Forms.TextBox();
            this.txtMae1 = new System.Windows.Forms.TextBox();
            this.txtMae0 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAto6 = new System.Windows.Forms.TextBox();
            this.txtAto5 = new System.Windows.Forms.TextBox();
            this.txtAto0 = new System.Windows.Forms.TextBox();
            this.txtAto4 = new System.Windows.Forms.TextBox();
            this.txtAto1 = new System.Windows.Forms.TextBox();
            this.txtAto3 = new System.Windows.Forms.TextBox();
            this.txtAto2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.処理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 処理ToolStripMenuItem
            // 
            this.処理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データ入力開始ICtrlIToolStripMenuItem,
            this.データ入力終了ECtrlEToolStripMenuItem,
            this.ソートSToolStripMenuItem});
            this.処理ToolStripMenuItem.Name = "処理ToolStripMenuItem";
            this.処理ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.処理ToolStripMenuItem.Text = "処理";
            // 
            // データ入力開始ICtrlIToolStripMenuItem
            // 
            this.データ入力開始ICtrlIToolStripMenuItem.Name = "データ入力開始ICtrlIToolStripMenuItem";
            this.データ入力開始ICtrlIToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.データ入力開始ICtrlIToolStripMenuItem.Text = "データ入力開始(I) Ctrl + I";
            this.データ入力開始ICtrlIToolStripMenuItem.Click += new System.EventHandler(this.データ入力開始ICtrlIToolStripMenuItem_Click);
            // 
            // データ入力終了ECtrlEToolStripMenuItem
            // 
            this.データ入力終了ECtrlEToolStripMenuItem.Enabled = false;
            this.データ入力終了ECtrlEToolStripMenuItem.Name = "データ入力終了ECtrlEToolStripMenuItem";
            this.データ入力終了ECtrlEToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.データ入力終了ECtrlEToolStripMenuItem.Text = "データ入力終了(E) Ctrl + E";
            this.データ入力終了ECtrlEToolStripMenuItem.Click += new System.EventHandler(this.データ入力終了ECtrlEToolStripMenuItem_Click);
            // 
            // ソートSToolStripMenuItem
            // 
            this.ソートSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.昇順ACtrlAToolStripMenuItem,
            this.降順DCtrlDToolStripMenuItem});
            this.ソートSToolStripMenuItem.Name = "ソートSToolStripMenuItem";
            this.ソートSToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ソートSToolStripMenuItem.Text = "ソート(S)";
            // 
            // 昇順ACtrlAToolStripMenuItem
            // 
            this.昇順ACtrlAToolStripMenuItem.Name = "昇順ACtrlAToolStripMenuItem";
            this.昇順ACtrlAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.昇順ACtrlAToolStripMenuItem.Text = "昇順(A) Ctrl + A";
            this.昇順ACtrlAToolStripMenuItem.Click += new System.EventHandler(this.昇順ACtrlAToolStripMenuItem_Click);
            // 
            // 降順DCtrlDToolStripMenuItem
            // 
            this.降順DCtrlDToolStripMenuItem.Name = "降順DCtrlDToolStripMenuItem";
            this.降順DCtrlDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.降順DCtrlDToolStripMenuItem.Text = "降順(D) Ctrl + D";
            this.降順DCtrlDToolStripMenuItem.Click += new System.EventHandler(this.降順DCtrlDToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMae6);
            this.groupBox1.Controls.Add(this.txtMae5);
            this.groupBox1.Controls.Add(this.txtMae4);
            this.groupBox1.Controls.Add(this.txtMae3);
            this.groupBox1.Controls.Add(this.txtMae2);
            this.groupBox1.Controls.Add(this.txtMae1);
            this.groupBox1.Controls.Add(this.txtMae0);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SORT前データ";
            // 
            // txtMae6
            // 
            this.txtMae6.Enabled = false;
            this.txtMae6.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtMae6.Location = new System.Drawing.Point(289, 30);
            this.txtMae6.Multiline = true;
            this.txtMae6.Name = "txtMae6";
            this.txtMae6.Size = new System.Drawing.Size(40, 40);
            this.txtMae6.TabIndex = 6;
            this.txtMae6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMae5
            // 
            this.txtMae5.Enabled = false;
            this.txtMae5.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtMae5.Location = new System.Drawing.Point(243, 30);
            this.txtMae5.Multiline = true;
            this.txtMae5.Name = "txtMae5";
            this.txtMae5.Size = new System.Drawing.Size(40, 40);
            this.txtMae5.TabIndex = 5;
            this.txtMae5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMae4
            // 
            this.txtMae4.Enabled = false;
            this.txtMae4.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtMae4.Location = new System.Drawing.Point(197, 30);
            this.txtMae4.Multiline = true;
            this.txtMae4.Name = "txtMae4";
            this.txtMae4.Size = new System.Drawing.Size(40, 40);
            this.txtMae4.TabIndex = 4;
            this.txtMae4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMae3
            // 
            this.txtMae3.Enabled = false;
            this.txtMae3.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtMae3.Location = new System.Drawing.Point(151, 30);
            this.txtMae3.Multiline = true;
            this.txtMae3.Name = "txtMae3";
            this.txtMae3.Size = new System.Drawing.Size(40, 40);
            this.txtMae3.TabIndex = 3;
            this.txtMae3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMae2
            // 
            this.txtMae2.Enabled = false;
            this.txtMae2.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtMae2.Location = new System.Drawing.Point(105, 30);
            this.txtMae2.Multiline = true;
            this.txtMae2.Name = "txtMae2";
            this.txtMae2.Size = new System.Drawing.Size(40, 40);
            this.txtMae2.TabIndex = 2;
            this.txtMae2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMae1
            // 
            this.txtMae1.Enabled = false;
            this.txtMae1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtMae1.Location = new System.Drawing.Point(59, 30);
            this.txtMae1.Multiline = true;
            this.txtMae1.Name = "txtMae1";
            this.txtMae1.Size = new System.Drawing.Size(40, 40);
            this.txtMae1.TabIndex = 1;
            this.txtMae1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMae0
            // 
            this.txtMae0.Enabled = false;
            this.txtMae0.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtMae0.Location = new System.Drawing.Point(13, 30);
            this.txtMae0.Multiline = true;
            this.txtMae0.Name = "txtMae0";
            this.txtMae0.Size = new System.Drawing.Size(40, 40);
            this.txtMae0.TabIndex = 0;
            this.txtMae0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAto6);
            this.groupBox2.Controls.Add(this.txtAto5);
            this.groupBox2.Controls.Add(this.txtAto0);
            this.groupBox2.Controls.Add(this.txtAto4);
            this.groupBox2.Controls.Add(this.txtAto1);
            this.groupBox2.Controls.Add(this.txtAto3);
            this.groupBox2.Controls.Add(this.txtAto2);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SORT後データ";
            // 
            // txtAto6
            // 
            this.txtAto6.Enabled = false;
            this.txtAto6.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtAto6.Location = new System.Drawing.Point(289, 30);
            this.txtAto6.Multiline = true;
            this.txtAto6.Name = "txtAto6";
            this.txtAto6.Size = new System.Drawing.Size(40, 40);
            this.txtAto6.TabIndex = 13;
            this.txtAto6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAto5
            // 
            this.txtAto5.Enabled = false;
            this.txtAto5.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtAto5.Location = new System.Drawing.Point(243, 30);
            this.txtAto5.Multiline = true;
            this.txtAto5.Name = "txtAto5";
            this.txtAto5.Size = new System.Drawing.Size(40, 40);
            this.txtAto5.TabIndex = 12;
            this.txtAto5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAto0
            // 
            this.txtAto0.Enabled = false;
            this.txtAto0.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtAto0.Location = new System.Drawing.Point(13, 30);
            this.txtAto0.Multiline = true;
            this.txtAto0.Name = "txtAto0";
            this.txtAto0.Size = new System.Drawing.Size(40, 40);
            this.txtAto0.TabIndex = 7;
            this.txtAto0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAto4
            // 
            this.txtAto4.Enabled = false;
            this.txtAto4.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtAto4.Location = new System.Drawing.Point(197, 30);
            this.txtAto4.Multiline = true;
            this.txtAto4.Name = "txtAto4";
            this.txtAto4.Size = new System.Drawing.Size(40, 40);
            this.txtAto4.TabIndex = 11;
            this.txtAto4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAto1
            // 
            this.txtAto1.Enabled = false;
            this.txtAto1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtAto1.Location = new System.Drawing.Point(59, 30);
            this.txtAto1.Multiline = true;
            this.txtAto1.Name = "txtAto1";
            this.txtAto1.Size = new System.Drawing.Size(40, 40);
            this.txtAto1.TabIndex = 8;
            this.txtAto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAto3
            // 
            this.txtAto3.Enabled = false;
            this.txtAto3.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtAto3.Location = new System.Drawing.Point(151, 30);
            this.txtAto3.Multiline = true;
            this.txtAto3.Name = "txtAto3";
            this.txtAto3.Size = new System.Drawing.Size(40, 40);
            this.txtAto3.TabIndex = 10;
            this.txtAto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAto2
            // 
            this.txtAto2.Enabled = false;
            this.txtAto2.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.txtAto2.Location = new System.Drawing.Point(105, 30);
            this.txtAto2.Multiline = true;
            this.txtAto2.Name = "txtAto2";
            this.txtAto2.Size = new System.Drawing.Size(40, 40);
            this.txtAto2.TabIndex = 9;
            this.txtAto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 207);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "ソート(隣接交法)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 処理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データ入力開始ICtrlIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データ入力終了ECtrlEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ソートSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 昇順ACtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 降順DCtrlDToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMae6;
        private System.Windows.Forms.TextBox txtMae5;
        private System.Windows.Forms.TextBox txtMae4;
        private System.Windows.Forms.TextBox txtMae3;
        private System.Windows.Forms.TextBox txtMae2;
        private System.Windows.Forms.TextBox txtMae1;
        private System.Windows.Forms.TextBox txtMae0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAto6;
        private System.Windows.Forms.TextBox txtAto5;
        private System.Windows.Forms.TextBox txtAto0;
        private System.Windows.Forms.TextBox txtAto4;
        private System.Windows.Forms.TextBox txtAto1;
        private System.Windows.Forms.TextBox txtAto3;
        private System.Windows.Forms.TextBox txtAto2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

