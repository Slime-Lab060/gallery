namespace Monitor
{
    partial class Form1
    {
        public string CategoryName { get; set; }
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cpubar = new CircularProgressBar.CircularProgressBar();
            this.rambar = new CircularProgressBar.CircularProgressBar();
            this.cpu = new System.Diagnostics.PerformanceCounter();
            this.ram = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.interVal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cpubar
            // 
            this.cpubar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpubar.AnimationSpeed = 500;
            this.cpubar.BackColor = System.Drawing.Color.Transparent;
            this.cpubar.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.cpubar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cpubar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.cpubar.InnerMargin = 2;
            this.cpubar.InnerWidth = -1;
            this.cpubar.Location = new System.Drawing.Point(245, 230);
            this.cpubar.MarqueeAnimationSpeed = 2000;
            this.cpubar.Name = "cpubar";
            this.cpubar.OuterColor = System.Drawing.Color.Gray;
            this.cpubar.OuterMargin = -10;
            this.cpubar.OuterWidth = 5;
            this.cpubar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cpubar.ProgressWidth = 15;
            this.cpubar.SecondaryFont = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cpubar.Size = new System.Drawing.Size(150, 150);
            this.cpubar.StartAngle = 200;
            this.cpubar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpubar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpubar.SubscriptText = "";
            this.cpubar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpubar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpubar.SuperscriptText = "";
            this.cpubar.TabIndex = 0;
            this.cpubar.Text = "0";
            this.cpubar.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpubar.Value = 10;
            // 
            // rambar
            // 
            this.rambar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.rambar.AnimationSpeed = 500;
            this.rambar.BackColor = System.Drawing.Color.Transparent;
            this.rambar.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.rambar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rambar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.rambar.InnerMargin = 2;
            this.rambar.InnerWidth = -1;
            this.rambar.Location = new System.Drawing.Point(457, 230);
            this.rambar.MarqueeAnimationSpeed = 2000;
            this.rambar.Name = "rambar";
            this.rambar.OuterColor = System.Drawing.Color.Gray;
            this.rambar.OuterMargin = -10;
            this.rambar.OuterWidth = 5;
            this.rambar.ProgressColor = System.Drawing.Color.MediumAquamarine;
            this.rambar.ProgressWidth = 15;
            this.rambar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rambar.SecondaryFont = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rambar.Size = new System.Drawing.Size(150, 150);
            this.rambar.StartAngle = 200;
            this.rambar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rambar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.rambar.SubscriptText = "";
            this.rambar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.rambar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.rambar.SuperscriptText = "";
            this.rambar.TabIndex = 1;
            this.rambar.Text = "0";
            this.rambar.TextMargin = new System.Windows.Forms.Padding(0);
            this.rambar.Value = 10;
            // 
            // cpu
            // 
            this.cpu.CategoryName = "Processor";
            this.cpu.CounterName = "% Processor Time";
            this.cpu.InstanceName = "_Total";
            // 
            // ram
            // 
            this.ram.CategoryName = "Memory";
            this.ram.CounterName = "% Committed Bytes In Use";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(283, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(491, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM";
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart1.BorderSkin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 20;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX2.MaximumAutoSize = 100F;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY2.MaximumAutoSize = 100F;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Location = new System.Drawing.Point(6, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelBorderWidth = 5;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Name = "CPU";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(816, 210);
            this.chart1.TabIndex = 4;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(636, 386);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Minimum = 50;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(181, 33);
            this.hScrollBar1.SmallChange = 2;
            this.hScrollBar1.TabIndex = 5;
            this.hScrollBar1.Value = 50;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // interVal
            // 
            this.interVal.AutoSize = true;
            this.interVal.Font = new System.Drawing.Font("メイリオ", 16F);
            this.interVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.interVal.Location = new System.Drawing.Point(718, 349);
            this.interVal.Name = "interVal";
            this.interVal.Size = new System.Drawing.Size(57, 33);
            this.interVal.TabIndex = 6;
            this.interVal.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(631, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interval:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(769, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interVal);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rambar);
            this.Controls.Add(this.cpubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU&RAMの使用率モニター";
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpubar;
        private CircularProgressBar.CircularProgressBar rambar;
        private System.Diagnostics.PerformanceCounter cpu;
        private System.Diagnostics.PerformanceCounter ram;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label interVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

