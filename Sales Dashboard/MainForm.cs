using Bunifu.Charts.WinForms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = bunifuButton1;
            bunifuPages1.SelectTab(0);
            await Task.Delay(1800);
            loader1.SendToBack();
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[] {
               new DataColumn(" "),
               new DataColumn("id"),
               new DataColumn("Name"),
               new DataColumn("Region"),
               new DataColumn("Product"),
               new DataColumn("Amount"),
               new DataColumn("Status")
            });

            dataTable.Rows.Add(new String[] {"","1.", "Brenda Jones", "SeyChelles", "Amazon Firestick", "$34.99","Paid" });
            dataTable.Rows.Add(new String[] {"","2.", "Mark Felix", "United States", "Roku Streaming Stick", "$34.99", "Paid" });
            dataTable.Rows.Add(new String[] {"","3.", "Naomy Jane", "SeyChelles", "Acer Aspire 5 Slim ", "$34.99", "Paid" });
            dataTable.Rows.Add(new String[] {"","4.", "Timothy Kelvin", "Japan", "Utopia Bedding ", "$34.99", "Paid" });
            dataTable.Rows.Add(new String[] {"","5.", "John Georges", "Egypt", "Black Disposable Face masks", "$34.99", "Paid" });
            
            bunifuDataGridView1.DataSource = dataTable;
            bunifuDataGridView1.Columns[0].Width = 22;
            bunifuDataGridView1.Columns[1].Width = 22;
            bunifuDataGridView1.Columns[4].Width = 72;
        }

        private void bunifuShadowPanel3_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel32_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {

                bunifuPages1.SelectTab(0);
                await Task.Delay(500);
                loader1.SendToBack();
                LoadNewData(bunifuLineChart2, bunifuChartCanvas2);
                loader2.BringToFront();
                loader3.BringToFront();
                loader4.BringToFront();
            }
            
           // MessageBox.Show("ck");
        }

        private async void bunifuRadioButton2_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {

                bunifuPages1.SelectTab(1);
                await Task.Delay(500);
                loader2.SendToBack();
               
                LoadNewData(bunifuLineChart1, bunifuChartCanvas1);
                loader1.BringToFront();
                loader3.BringToFront();
                loader4.BringToFront();
            }
            
        }

        private async void bunifuRadioButton3_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuPages1.SelectTab(2);
                await Task.Delay(500);
                loader3.SendToBack();
                LoadNewData(bunifuLineChart4, bunifuChartCanvas3);
                loader1.BringToFront();
                loader2.BringToFront();
                loader4.BringToFront();
            }
        }

        private async void bunifuRadioButton4_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                bunifuPages1.SelectTab(3);
                await Task.Delay(500);
                loader4.SendToBack();
                LoadNewData(bunifuLineChart3, bunifuChartCanvas4);
                loader1.BringToFront();
                loader2.BringToFront();
                loader3.BringToFront();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab(1);
        }
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {

            List<double> dataList = new List<double>()
           {

               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
         
           };
         
           for(int i=0; i<11; i++)
            {
                bunifuLineChart2.Data[i] = 0;
            }
            bunifuLineChart2.Data = dataList;

            bunifuChartCanvas2.Update();
          
        }
        private void LoadNewData(BunifuLineChart bunifuLine, BunifuChartCanvas canvas)
        {
            List<double> dataList = new List<double>()
           {

               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),
               random.Next(20,70),

           };

            for (int i = 0; i < 11; i++)
            {
                bunifuLine.Data[i] = 0;
            }
            bunifuLine.Data = dataList;

            canvas.Update();
        }

        private void bunifuChartCanvas2_Load(object sender, EventArgs e)
        {

        }
    }
}
