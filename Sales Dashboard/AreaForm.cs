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
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
        }

        private void AreaForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.Fill = BunifuLineChart.FillOptions.Blank;
            }
        }

        private void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.Fill = BunifuLineChart.FillOptions.Start; 
            }
        }

        private void bunifuRadioButton5_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart2.Fill = BunifuLineChart.FillOptions.End; 
            }
        }

        private void bunifuRadioButton6_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {

            if (e.Checked)
            {
                bunifuLineChart2.Fill = BunifuLineChart.FillOptions.Origin; 
            }
        }
    }
}
