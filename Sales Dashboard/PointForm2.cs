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
    public partial class PointForm2 : Form
    {
        public PointForm2()
        {
            InitializeComponent();
            bunifuDropdown1.SelectedIndex = 0;
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuLineChart1.PointStyle = BunifuLineChart.PointStyles.Circle;
            }
            else if (bunifuDropdown1.SelectedIndex == 1)
            {
                bunifuLineChart1.PointStyle = BunifuLineChart.PointStyles.CrossRot;
            }
            else if (bunifuDropdown1.SelectedIndex == 2)
            {
                bunifuLineChart1.PointStyle = BunifuLineChart.PointStyles.RectRounded;
            }
            else
            {
                bunifuLineChart1.PointStyle = BunifuLineChart.PointStyles.Triangle;
            }
        }

        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLineChart1.PointRadius = bunifuHSlider1.Value;
            bunifuChartCanvas1.Update();
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLineChart1.PointRotation = bunifuHSlider2.Value;
            bunifuChartCanvas1.Update();
        }
    }
}
