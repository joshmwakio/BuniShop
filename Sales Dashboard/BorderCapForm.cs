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
    public partial class BorderCapForm : Form
    {
        public BorderCapForm()
        {
            InitializeComponent();
        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.BorderCapStyle = BunifuLineChart.LineCaps.Butt;
                bunifuChartCanvas1.Update();
            }
         
        }

        private void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.BorderCapStyle = BunifuLineChart.LineCaps.Round;
                bunifuChartCanvas1.Update();
            }
        }
    }
}
