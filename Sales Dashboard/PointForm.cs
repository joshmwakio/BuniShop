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
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
            bunifuDropdown1.SelectedIndex = 0;
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuLineChart1.PointBorderColor = Color.White;
            }
            else if (bunifuDropdown1.SelectedIndex == 1)
            {
                bunifuLineChart1.PointBorderColor = Color.Lime;
            }
            else
            {
                bunifuLineChart1.PointBorderColor = Color.Yellow;
            }
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLineChart1.PointBorderWidth = bunifuHSlider1.Value;
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }

        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLineChart1.PointRadius = bunifuHSlider2.Value;
        }
    }
}
