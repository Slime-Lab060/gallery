using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Form1 : Form 
    {
        float fcpu;
        float dram;
        byte  cnt;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Maximum = 30;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            if (cnt++ <= 60)
                cnt++;

            fcpu = cpu.NextValue();
            dram = ram.NextValue();
            cpubar.Value = (int)fcpu;
            cpubar.Text = string.Format("{0:0.00}%",fcpu);

            rambar.Value = (int)dram;
            rambar.Text = string.Format("{0:0.00}%", dram);

            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(dram);

            if (cnt >= 60)
            {
                chart1.Series["CPU"].Points.RemoveAt(0);
                chart1.Series["RAM"].Points.RemoveAt(0);

            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer.Interval = hScrollBar1.Value;
            interVal.Text = hScrollBar1.Value.ToString();
        }
    }
}
