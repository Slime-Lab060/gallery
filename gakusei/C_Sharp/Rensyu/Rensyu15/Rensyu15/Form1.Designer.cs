namespace Rensyu15
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.実行RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.四角形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三角形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.台形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ひし型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.円ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.g1 = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resulttext = new System.Windows.Forms.TextBox();
            this.テキストのクリアCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.g1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.実行RToolStripMenuItem,
            this.編集EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 実行RToolStripMenuItem
            // 
            this.実行RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.四角形ToolStripMenuItem,
            this.三角形ToolStripMenuItem,
            this.台形ToolStripMenuItem,
            this.ひし型ToolStripMenuItem,
            this.円ToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.実行RToolStripMenuItem.Name = "実行RToolStripMenuItem";
            this.実行RToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.実行RToolStripMenuItem.Text = "実行(R)";
            // 
            // 四角形ToolStripMenuItem
            // 
            this.四角形ToolStripMenuItem.Name = "四角形ToolStripMenuItem";
            this.四角形ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.四角形ToolStripMenuItem.Text = "四角形";
            this.四角形ToolStripMenuItem.Click += new System.EventHandler(this.四角形ToolStripMenuItem_Click);
            // 
            // 三角形ToolStripMenuItem
            // 
            this.三角形ToolStripMenuItem.Name = "三角形ToolStripMenuItem";
            this.三角形ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.三角形ToolStripMenuItem.Text = "三角形";
            this.三角形ToolStripMenuItem.Click += new System.EventHandler(this.三角形ToolStripMenuItem_Click);
            // 
            // 台形ToolStripMenuItem
            // 
            this.台形ToolStripMenuItem.Name = "台形ToolStripMenuItem";
            this.台形ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.台形ToolStripMenuItem.Text = "台形";
            this.台形ToolStripMenuItem.Click += new System.EventHandler(this.台形ToolStripMenuItem_Click);
            // 
            // ひし型ToolStripMenuItem
            // 
            this.ひし型ToolStripMenuItem.Name = "ひし型ToolStripMenuItem";
            this.ひし型ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ひし型ToolStripMenuItem.Text = "ひし型";
            this.ひし型ToolStripMenuItem.Click += new System.EventHandler(this.ひし型ToolStripMenuItem_Click);
            // 
            // 円ToolStripMenuItem
            // 
            this.円ToolStripMenuItem.Name = "円ToolStripMenuItem";
            this.円ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.円ToolStripMenuItem.Text = "円";
            this.円ToolStripMenuItem.Click += new System.EventHandler(this.円ToolStripMenuItem_Click);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了XToolStripMenuItem.Text = "終了(X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テキストのクリアCToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(E)";
            // 
            // g1
            // 
            this.g1.Controls.Add(this.lbl3);
            this.g1.Controls.Add(this.lbl2);
            this.g1.Controls.Add(this.lbl1);
            this.g1.Controls.Add(this.text3);
            this.g1.Controls.Add(this.text2);
            this.g1.Controls.Add(this.text1);
            this.g1.Location = new System.Drawing.Point(21, 47);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(142, 104);
            this.g1.TabIndex = 1;
            this.g1.TabStop = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 71);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 12);
            this.lbl3.TabIndex = 5;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 46);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 12);
            this.lbl2.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 12);
            this.lbl1.TabIndex = 3;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(69, 68);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(67, 19);
            this.text3.TabIndex = 2;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(69, 43);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(67, 19);
            this.text2.TabIndex = 1;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(69, 18);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(67, 19);
            this.text1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button1.Location = new System.Drawing.Point(192, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "実行(R)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resulttext
            // 
            this.resulttext.Enabled = false;
            this.resulttext.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.resulttext.Location = new System.Drawing.Point(192, 65);
            this.resulttext.Multiline = true;
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(123, 28);
            this.resulttext.TabIndex = 3;
            this.resulttext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // テキストのクリアCToolStripMenuItem
            // 
            this.テキストのクリアCToolStripMenuItem.Name = "テキストのクリアCToolStripMenuItem";
            this.テキストのクリアCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.テキストのクリアCToolStripMenuItem.Text = "テキストのクリア(C)";
            this.テキストのクリアCToolStripMenuItem.Click += new System.EventHandler(this.テキストのクリアCToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "面積";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resulttext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "面積計算";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.g1.ResumeLayout(false);
            this.g1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 実行RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 四角形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三角形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 台形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ひし型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 円ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.GroupBox g1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox resulttext;
        private System.Windows.Forms.ToolStripMenuItem テキストのクリアCToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

