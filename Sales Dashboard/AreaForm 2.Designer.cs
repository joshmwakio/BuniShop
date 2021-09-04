
namespace Sales_Dashboard
{
    partial class AreaForm_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaForm_2));
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuLineChart2 = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.bunifuLineChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            this.bunifuBubbleChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuBubbleChart(this.components);
            this.SuspendLayout();
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.AnimationDuration = 1000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas1.BackColor = System.Drawing.Color.White;
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.bunifuChartCanvas1.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep"};
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Roboto", 8.75F);
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuChartCanvas1.LegendFullWidth = true;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.LegendRevese = false;
            this.bunifuChartCanvas1.LegendRTL = false;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(54, 22);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = true;
            this.bunifuChartCanvas1.ShowYAxis = true;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(724, 360);
            this.bunifuChartCanvas1.TabIndex = 18;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 10;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesGridLines = true;
            this.bunifuChartCanvas1.XAxesLabel = "Months of the year";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.Silver;
            this.bunifuChartCanvas1.YAxesGridLines = true;
            this.bunifuChartCanvas1.YAxesLabel = "Number of supplies (in thousands)";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            // 
            // bunifuLineChart2
            // 
            this.bunifuLineChart2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(10)))), ((int)(((byte)(178)))), ((int)(((byte)(250)))));
            this.bunifuLineChart2.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.bunifuLineChart2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(10)))), ((int)(((byte)(178)))), ((int)(((byte)(250)))));
            this.bunifuLineChart2.BorderDash = null;
            this.bunifuLineChart2.BorderDashOffset = 0D;
            this.bunifuLineChart2.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.bunifuLineChart2.BorderWidth = 3;
            this.bunifuLineChart2.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.bunifuLineChart2.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuLineChart2.Data")));
            this.bunifuLineChart2.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Start;
            this.bunifuLineChart2.Label = "Moderna Covid-19 Vaccine";
            this.bunifuLineChart2.LineTension = 3D;
            this.bunifuLineChart2.Order = 0;
            this.bunifuLineChart2.PointBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart2.PointBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart2.PointBorderWidth = 1;
            this.bunifuLineChart2.PointHitRadius = 1;
            this.bunifuLineChart2.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart2.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart2.PointHoverBorderWidth = 4;
            this.bunifuLineChart2.PointHoverRadius = 1;
            this.bunifuLineChart2.PointRadius = 3;
            this.bunifuLineChart2.PointRotation = 0;
            this.bunifuLineChart2.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.bunifuLineChart2.ShowLine = true;
            this.bunifuLineChart2.SpanGaps = false;
            this.bunifuLineChart2.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.bunifuLineChart2.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuLineChart1
            // 
            this.bunifuLineChart1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(242)))), ((int)(((byte)(182)))));
            this.bunifuLineChart1.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.bunifuLineChart1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(242)))), ((int)(((byte)(182)))));
            this.bunifuLineChart1.BorderDash = null;
            this.bunifuLineChart1.BorderDashOffset = 0D;
            this.bunifuLineChart1.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.bunifuLineChart1.BorderWidth = 3;
            this.bunifuLineChart1.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.bunifuLineChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuLineChart1.Data")));
            this.bunifuLineChart1.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Start;
            this.bunifuLineChart1.Label = "Pfizer Vaccine";
            this.bunifuLineChart1.LineTension = 3D;
            this.bunifuLineChart1.Order = 0;
            this.bunifuLineChart1.PointBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderWidth = 1;
            this.bunifuLineChart1.PointHitRadius = 1;
            this.bunifuLineChart1.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderWidth = 4;
            this.bunifuLineChart1.PointHoverRadius = 1;
            this.bunifuLineChart1.PointRadius = 3;
            this.bunifuLineChart1.PointRotation = 0;
            this.bunifuLineChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.bunifuLineChart1.ShowLine = true;
            this.bunifuLineChart1.SpanGaps = false;
            this.bunifuLineChart1.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.bunifuLineChart1.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuBubbleChart1
            // 
            this.bunifuBubbleChart1.BackgroundColor = System.Drawing.Color.Empty;
            this.bunifuBubbleChart1.BorderColor = System.Drawing.Color.Empty;
            this.bunifuBubbleChart1.BorderWidth = 0;
            this.bunifuBubbleChart1.Data = null;
            this.bunifuBubbleChart1.HitRadius = 1;
            this.bunifuBubbleChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuBubbleChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuBubbleChart1.HoverBorderWidth = 0;
            this.bunifuBubbleChart1.HoverRadius = 4;
            this.bunifuBubbleChart1.Label = "Label here";
            this.bunifuBubbleChart1.Order = 0;
            this.bunifuBubbleChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuBubbleChart.PointStyles.Circle;
            this.bunifuBubbleChart1.Radius = 3;
            this.bunifuBubbleChart1.Rotation = 0;
            this.bunifuBubbleChart1.TargetCanvas = null;
            // 
            // AreaForm_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 405);
            this.Controls.Add(this.bunifuChartCanvas1);
            this.Name = "AreaForm_2";
            this.Text = "AreaForm_2";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart bunifuLineChart2;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart bunifuLineChart1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBubbleChart bunifuBubbleChart1;
    }
}