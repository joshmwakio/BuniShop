using Bunifu.Charts.WinForms.ChartTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Dashboard
{
    public partial class zIndexForm : Form
    {
        public zIndexForm()
        {
            InitializeComponent();
        
        }
        private async void redoAnimation(BunifuLineChart bunifuLine)
        {
            bunifuLine.TargetCanvas = null;
            bunifuChartCanvas1.Update();
            await Task.Delay(500);
            //target canvas
            bunifuLine.TargetCanvas = bunifuChartCanvas1;
        }

        private void setBorderWidth(BunifuLineChart bunifuLineChart, int width)
        {
            bunifuLineChart.BorderWidth = width;
        }
        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
         
            if (e.Checked){
                redoAnimation(bunifuLineChart1);
                bunifuLineChart1.Order = 0;
                bunifuLineChart2.Order = 1;
                bunifuLineChart3.Order = 2;
                setBorderWidth(bunifuLineChart1, 6);
                setBorderWidth(bunifuLineChart2, 3);
                setBorderWidth(bunifuLineChart3, 3);
            }
        }
 
        private void bunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
          
            if (e.Checked)
            {
                redoAnimation(bunifuLineChart2);
                bunifuLineChart2.Order = -1;
                bunifuLineChart1.Order = 0;
                bunifuLineChart3.Order = 2;
                setBorderWidth(bunifuLineChart2, 6);
                setBorderWidth(bunifuLineChart1, 3);
                setBorderWidth(bunifuLineChart3, 3);
            }
        }

        private void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                redoAnimation(bunifuLineChart3);
                bunifuLineChart3.Order = -2;
                bunifuLineChart1.Order = 0;
                bunifuLineChart2.Order = 2;
                bunifuLineChart3.BorderWidth = 5;
                setBorderWidth(bunifuLineChart3, 6);
                setBorderWidth(bunifuLineChart2, 3);
                setBorderWidth(bunifuLineChart1, 3);
            }
        }
        int order = 0;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            //redoAnimation();
        }
    }
}
