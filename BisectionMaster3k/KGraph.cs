using BisectionMaster3k.Frontend;
using ScottPlot;
using ScottPlot.Plottable;
using ScottPlot.Renderable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisectionMaster3k
{
    internal class KGraph
    {
        protected FormsPlot KControl;
        protected Plot KPlot;
        private string Stitle;
        private string SAxisX;
        private string SAxisY;
        private double Rx1=0;
        private double Rx2=0;
        private Legend? legend;
        private VLine? vline1;
        private VLine? vline2;
        private HSpan? vSpan;
        private VLine? vlinez;
        private ScatterPlot? zero;
        private ScatterPlot? pzero;
        private ScatterPlot? Pline;
        private FunctionPlot? PFline;
        private double[] MzX = new double[] { 0 };
        private double[] MzY = new double[] { 0 };
        private string[] Mzlabels = new string[] { $"({0}; {0})" };
        private double[] PMzX = new double[] { 0 };
        private double[] PMzY = new double[] { 0 };
        private string[] PMzlabels = new string[] { $"({0}; {0})" };
        private double[] funX = new double[] { 0 };
        private double[] funY = new double[] { 0 };
        private string? funS;
        private Func<double, string> FormatLabel = x => $"X={x}";

        public KGraph(FormsPlot control, string title = "Wykres - Bisekcja funkcji", string AxisX = "Oś X", string AxisY = "Oś Y")
        {
            this.KControl = control;
            this.KPlot = control.Plot;
            this.Stitle = title;
            this.SAxisY = AxisY;
            this.SAxisX = AxisX;
            
            
            //
            // Axises Grid Ticks
            //

            KPlot.Title(Stitle, bold: true, Color.Black, size: 32);
            KPlot.YAxis.Label(SAxisY, Color.Black, size: 24, bold: true);
            KPlot.XAxis.Label(SAxisX, Color.Black, size: 24, bold: true);
            KPlot.XAxis.MajorGrid(color: Color.FromArgb(100, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Dash);
            KPlot.XAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Solid);
            KPlot.YAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Solid);
            KPlot.XAxis.AxisTicks.MajorTickColor = Color.Magenta;
            KPlot.XAxis.AxisTicks.MinorTickColor = Color.LightSkyBlue;
            KPlot.XAxis.AxisTicks.MajorTickLength = 10;
            KPlot.XAxis.AxisTicks.MinorTickLength = 5;
            KPlot.YAxis.AxisTicks.MajorTickLength = 10;
            KPlot.YAxis.AxisTicks.MinorTickLength = 5;
            KPlot.XAxis.TickLabelStyle(rotation: 45);
            KPlot.XAxis.AxisTicks.MajorLineWidth = 3;
            KPlot.XAxis.AxisTicks.MinorLineWidth = 2;
            KPlot.YAxis.AxisTicks.MajorLineWidth = 3;
            KPlot.YAxis.AxisTicks.MinorLineWidth = 2;
            KPlot.YAxis.AxisLine.Width = 2;
            KPlot.XAxis.AxisLine.Width = 2;
            KPlot.YAxis.TickDensity(1);
            KPlot.XAxis.TickDensity(1);
            KPlot.Layout(top: 80);

            //
            // Zoom 
            //
            //FIXED Values
            //KPlot.YAxis.SetZoomInLimit(10);
            //KPlot.YAxis.SetZoomOutLimit(10000);
            //KPlot.XAxis.SetZoomInLimit(0.01);
            //KPlot.XAxis.SetZoomOutLimit(10000);

            //
            // 0 Axises
            //
            //FIXED Values
            KPlot.AddVerticalLine(x: 0, color: Color.Black, width: 1, style: LineStyle.Solid);
            KPlot.AddHorizontalLine(y: 0, color: Color.Black, width: 1, style: LineStyle.Solid);
            KControl.Refresh();
        }
        public void AddRange(double x1=0, double x2=0)
        {
            this.Rx1 = x1;
            this.Rx2 = x2;
            //double tmp = 0;
            //if(Rx1 == 0) { tmp = Rx2; }
            //
            // Limits for X Axis 
            //
            //potrzebne żeby wykres jakoś się prezentował
            //KPlot.SetAxisLimitsX(((Math.Abs(Rx1 * 2) + tmp) * (-1)), Rx2 * 2);
            //KPlot.XAxis.SetBoundary(Math.Abs(Rx1 * 2) * (-1), Rx2 * 2);
            KControl.Refresh();
        }
        public void FitData()
        {
            KPlot.AxisAutoX(); 
            KControl.Refresh();
        }
        public void ShowLegend(bool yes = true)
        {
            //
            // Legend
            //

            legend = KPlot.Legend(yes);
            KControl.Refresh();
        }
        
        public void ShowRange(bool yes = true)
        {
            
            //
            // Add range indicators
            //
            
            // Start of range
            vline1 = KPlot.AddVerticalLine(x: Rx1, color: Color.Green, width: 2, style: LineStyle.Solid);
            vline1.PositionLabelOppositeAxis = true;
            vline1.PositionLabelAxis = KPlot.XAxis2;
            vline1.PositionLabel = true;
            vline1.PositionLabelBackground = Color.FromArgb(50, vline1.Color);
            vline1.PositionLabelFont.Color = Color.Black;
            vline1.PositionFormatter = FormatLabel;
            vline1.IsVisible = yes;
            // End of range
            vline2 = KPlot.AddVerticalLine(x: Rx2, color: Color.Green, width: 2, style: LineStyle.Solid);
            vline2.PositionLabelOppositeAxis = true;
            vline2.PositionLabelAxis = KPlot.XAxis2;
            vline2.PositionLabel = true;
            vline2.PositionLabelBackground = Color.FromArgb(50, vline2.Color);
            vline2.PositionLabelFont.Color = Color.Black;
            vline2.PositionFormatter = FormatLabel;
            vline2.IsVisible = yes;
            KControl.Refresh();
        }
        
        public void ShowSpan(bool yes = true)
        {
            // Span
            vSpan = KPlot.AddHorizontalSpan(Rx1, Rx2);
            vSpan.BorderLineWidth = 1;
            vSpan.BorderColor = Color.Gray;
            vSpan.BorderLineStyle = LineStyle.Solid;
            vSpan.Color = Color.FromArgb(50, Color.PaleGreen);
            vSpan.Label = $"Przedział X \u2208 <{Rx1};{Rx2}>";
            vSpan.IsVisible = yes;
            KControl.Refresh();
        }
        public void ShowMzLine(bool yes = true,bool singlePoint= true) 
        {
            int times = 1;
            if (singlePoint == false)
            {
                times = MzX.Length;
            }    
            for (int i = 0; i < times; i++)
            {
                vlinez = KPlot.AddVerticalLine(x: MzX[i], color: Color.Red, width: 1, style: LineStyle.Dash);
                vlinez.IsVisible = yes;
            }
            KControl.Refresh();
        }
        public void AddMz(double[] MzX, double[] MzY, int prec)
        {
            this.MzX = MzX;
            this.MzY = MzY;
            this.Mzlabels = new string[MzX.Length];
            for(int i = 0; i < MzX.Length; i++) 
            {
                this.Mzlabels[i] = $"({MzX[i]}; {MzY[i]})";
            }
            
        }
        public void ShowMzPlot(bool yes=true, int prec=2, bool singlePoint=true)
        {
            string MzLabel = $"Miejsce zerowe X = {MzX[0]}";
            double[] TMzX = { MzX[0] };
            double[] TMzY = { MzY[0] };
            string[] TMzlabels = { Mzlabels[0] };
            if (singlePoint==false)
            {
                MzLabel = "Miejsca zerowe";
                TMzX = MzX;
                TMzY = MzY;
                TMzlabels = Mzlabels;
            }
            
            //
            // Plot for Zero Point as Function 
            //
            //SET (MxX,MzY,MzLabels)
            zero = KPlot.AddScatterPoints(TMzX, TMzY, Color.Red, 12, MarkerShape.filledDiamond, label: MzLabel);
            zero.DataPointLabels = TMzlabels;
            zero.DataPointLabelFont.Size = 15;
            zero.DataPointLabelFont.Alignment = Alignment.UpperLeft;
            zero.IsVisible = yes;
            KControl.Refresh();
        }
        public void AddPotentialMz(double[] PMzX, double[] PMzY, string[] PMzlabels, int prec)
        {
            this.PMzX = PMzX;
            this.PMzY = PMzY;
            this.PMzlabels = PMzlabels;
            //for (int i = 0; i < PMzX.Length; i++)
            //{
            //    this.PMzlabels[i] = $"({UserInterface.vFormatNumberPrecision(PMzX[i], prec)}; {UserInterface.vFormatNumberPrecision(PMzY[i], prec)})";
            //}
        }
        public void ShowPotentialPlot(bool yes=true)
        {
            string MzLabel = "Potencjalne miejsca zerowe";
            //
            // Plot for Potential Zero Points that were calculated
            //
            //SET (PMxX,PMzY,PMzLabels) AddScatter()
            pzero = KPlot.AddScatterPoints(PMzX, PMzY, color: Color.Orange, 8, /*8,*/ MarkerShape.filledCircle, label: MzLabel);
            pzero.DataPointLabels = PMzlabels;
            pzero.DataPointLabelFont.Size = 10;
            pzero.DataPointLabelFont.Alignment = Alignment.LowerLeft;
            pzero.IsVisible = yes;
            KControl.Refresh();
        }
        public void AddLinePlot(double[] funX, double[] funY,string funS="f(x)")
        {
            this.funX = funX;
            this.funY = funY;
            this.funS = funS;
            
        }
        public void ShowLinePlot(bool yes = true)
        {
            //
            // Function plot - only line
            //
            Pline = KPlot.AddScatterLines(funX, funY, Color.Blue, 2, LineStyle.Solid, label: $"Funkcja: {funS}");
            Pline.IsVisible = yes;
            KControl.Refresh();
        }
        public void ShowFuncLinePlot(bool yes = true, Func<double, double?> funkcja = null, string label="f(x)")
        {
            //
            // Function plot based on Func - only line
            //
            PFline = KPlot.AddFunction(funkcja, lineWidth: 2, color: Color.Blue);
            PFline.Label = "Funkcja: " + label;
            PFline.IsVisible = yes;
            KControl.Refresh();
        }
        public void Clear()
        {
            KPlot.Clear();
            //
            // Axises Grid Ticks
            //

            KPlot.Title(Stitle, bold: true, Color.Black, size: 26);
            KPlot.YAxis.Label(SAxisY, Color.Black, size: 24, bold: true);
            KPlot.XAxis.Label(SAxisX, Color.Black, size: 24, bold: true);
            KPlot.XAxis.MajorGrid(color: Color.FromArgb(100, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Dash);
            KPlot.XAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Solid);
            KPlot.YAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Solid);
            KPlot.XAxis.AxisTicks.MajorTickColor = Color.Magenta;
            KPlot.XAxis.AxisTicks.MinorTickColor = Color.LightSkyBlue;
            KPlot.XAxis.AxisTicks.MajorTickLength = 10;
            KPlot.XAxis.AxisTicks.MinorTickLength = 5;
            KPlot.YAxis.AxisTicks.MajorTickLength = 10;
            KPlot.YAxis.AxisTicks.MinorTickLength = 5;
            KPlot.XAxis.TickLabelStyle(rotation: 45);
            KPlot.XAxis.AxisTicks.MajorLineWidth = 3;
            KPlot.XAxis.AxisTicks.MinorLineWidth = 2;
            KPlot.YAxis.AxisTicks.MajorLineWidth = 3;
            KPlot.YAxis.AxisTicks.MinorLineWidth = 2;
            KPlot.YAxis.AxisLine.Width = 2;
            KPlot.XAxis.AxisLine.Width = 2;
            KPlot.YAxis.TickDensity(1);
            KPlot.XAxis.TickDensity(1);
            KPlot.Layout(top: 80);

            //
            // Zoom 
            //
            //FIXED Values
            KPlot.YAxis.SetZoomInLimit(10);
            KPlot.YAxis.SetZoomOutLimit(1000);
            KPlot.XAxis.SetZoomInLimit(0.01);
            KPlot.XAxis.SetZoomOutLimit(1000);

            //
            // 0 Axises
            //
            //FIXED Values
            KPlot.AddVerticalLine(x: 0, color: Color.Black, width: 1, style: LineStyle.Solid);
            KPlot.AddHorizontalLine(y: 0, color: Color.Black, width: 1, style: LineStyle.Solid);
            KControl.Refresh();
        }
        public void Save(string filename)
        {
            KPlot.SaveFig(filename);
            
        }
        
    }
}
