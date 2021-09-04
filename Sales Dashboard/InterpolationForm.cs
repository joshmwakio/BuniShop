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
    public partial class InterpolationForm : Form
    {
        public InterpolationForm()
        {
            InitializeComponent();
          
        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                //sets the default cubic interploation mode
                bunifuLineChart1.CubicInterpolationMode = BunifuLineChart.CubicInterpolationModes.Default;
            }
            else
            {
                //sets a monotone cubic interpolation mode
                bunifuLineChart1.CubicInterpolationMode = BunifuLineChart.CubicInterpolationModes.Monotone;
            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuLineChart1.CubicInterpolationMode = BunifuLineChart.CubicInterpolationModes.Monotone;
            }
        }

        private void bunifuToolTip1_Popup(object sender, Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs e)
        {
          
           // MessageBox.Show("m");
            
        }

        private void bunifuRadioButton1_MouseHover(object sender, EventArgs e)
        {
      
            bunifuToolTip1.ToolTipPosition = new Point(Cursor.Position.X, 500);
            
        }
    }
}
