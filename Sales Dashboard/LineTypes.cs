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
    public partial class LineTypes : Form
    {
        public LineTypes()
        {
            InitializeComponent();
        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.SteppedLine = BunifuLineChart.SteppedLineStyles.False;
            }
           
        }

        private void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.SteppedLine = BunifuLineChart.SteppedLineStyles.True; 
            }
        }

        private void bunifuRadioButton4_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.SteppedLine = BunifuLineChart.SteppedLineStyles.Before; 
            }
        }

        private void bunifuRadioButton5_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.SteppedLine = BunifuLineChart.SteppedLineStyles.Middle; 
            }
        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton6_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.SteppedLine = BunifuLineChart.SteppedLineStyles.After; 
            }
        }

        private void LineTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
