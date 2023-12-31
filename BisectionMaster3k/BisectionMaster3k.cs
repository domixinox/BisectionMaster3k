using ScottPlot;
using ScottPlot.Drawing.Colormaps;
using ScottPlot.MarkerShapes;
using ScottPlot.Renderable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BisectionMaster3k
{
    public partial class BisectionMaster3k : Form
    {
        // Uzycie klasy wedlug filozofii 'singleton'
        // pozwala na:
        // (+) prace jak na klasie statycznej
        // (+) wykorzystanie Indeksatora jakbym potrzebowal
        Polynomial poly = Polynomial.Instance;

        public BisectionMaster3k()
        {
            InitializeComponent();

            // Rozmiar Okna Glownego
            // Zeby na roznych kompach tak samo bylo - denerwowalo mnie bo musialem resize windowa robic zeby w przycisk klikac
            //this.Size = new Size(1000, 1000);

            //
            // Windows Forms App lubi wyrzucac przypisane Metody do Delegatow
            // Proponuje subskrybowac recznie
            //

            // Dla pewnosci unsubscribe
            ObliczMiejsceZerowe.Click -= ObliczMiejsceZerowe_Click;
            ObliczMiejsceZerowe.Click += ObliczMiejsceZerowe_Click;
        }

        private void ObliczMiejsceZerowe_Click(object sender, EventArgs e)
        {
            //
            // Obiekt Wielomiany
            //

            Polynomial poly1 = Polynomial.Instance;

            //
            // Walidator
            //

            //
            // Parser
            //

            //
            // Bisekcja
            //

            double x1 = Convert.ToDouble(inputRangeX1.Text);
            double x2 = Convert.ToDouble(inputRangeX2.Text);
            double delta = 0.0001;

            double x = Bisection.fBisection(x1, x2, delta);

            MessageBox.Show(x.ToString());

            //
            // Wykres
            //

            if (!Double.IsNaN(x) && Double.IsFinite(x))
            {
                //
                //TO DO:
                //Przeniesienie do funkcji/klasy tworzenie wykresu
                //reset wykresu po ponownym wciœnieciu oblicz
                //zapis do pliku - przycisk
                //ew off/On dane na wykresie i kolory - przyciski
                //

                //
                // Data
                //

                //granice (x1,x2)
                //Miejsce zerowe
                double[] MzX = new double[] { x };
                double[] MzY = new double[] { 0 };
                string[] Mzlabels = new string[] { $"({x}; 0)" };
                //zmienna wykres
                var plot = formsPlot1.Plot;
                //wielomian
                double[] funX = new double[] { x, 2, 5 };
                double[] funY = new double[] { 3, 0, 5 };
                string fun = "";
                //ewentualnie w formie delegata zamiast pkt dla wielomianu
                //var func1 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 2));

                //zas³ania labele do granic
                //plot.Title("Wykres - Bisekcja funkcji", bold: true, Color.Black, size: 24);

                //
                // Limits for X Axis 
                //
                //SET (x1,x2)
                plot.SetAxisLimitsX(Math.Abs(x1 * 2) * (-1), x2 * 2);
                plot.XAxis.SetBoundary(Math.Abs(x1 * 2) * (-1), x2 * 2);
                
                //
                // Axises Grid Ticks
                //
                //FIXED Values
                plot.YAxis.Label("Oœ Y", Color.Black, size: 24, bold: true);
                plot.XAxis.Label("Oœ X", Color.Black, size: 24, bold: true);
                plot.XAxis.MajorGrid(color: Color.FromArgb(100, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Dash);
                plot.XAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Solid);
                plot.YAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Gray), lineWidth: 1, lineStyle: LineStyle.Solid);
                plot.XAxis.AxisTicks.MajorTickColor = Color.Magenta;
                plot.XAxis.AxisTicks.MinorTickColor = Color.LightSkyBlue;
                plot.XAxis.AxisTicks.MajorTickLength = 10;
                plot.XAxis.AxisTicks.MinorTickLength = 5;
                plot.YAxis.AxisTicks.MajorTickLength = 10;
                plot.YAxis.AxisTicks.MinorTickLength = 5;
                plot.XAxis.TickLabelStyle(rotation: 45);
                plot.XAxis.AxisTicks.MajorLineWidth = 3;
                plot.XAxis.AxisTicks.MinorLineWidth = 2;
                plot.YAxis.AxisTicks.MajorLineWidth = 3;
                plot.YAxis.AxisTicks.MinorLineWidth = 2;
                plot.YAxis.AxisLine.Width = 2;
                plot.XAxis.AxisLine.Width = 2;
                plot.XAxis.TickDensity(2);

                //
                // Zoom 
                //
                //FIXED Values
                plot.YAxis.SetZoomInLimit(0.01);
                plot.YAxis.SetZoomOutLimit(1000);
                plot.XAxis.SetZoomInLimit(0.01);
                plot.XAxis.SetZoomOutLimit(1000);

                //
                // 0 Axises
                //
                //FIXED Values
                plot.AddVerticalLine(x: 0, color: Color.Black, width: 1, style: LineStyle.Solid);
                plot.AddHorizontalLine(y: 0, color: Color.Black, width: 1, style: LineStyle.Solid);

                //
                // Add range indicators
                //
                Func<double, string> FormatLabel = x => $"X={x}";
                //SET (x1)
                // Start of range
                var vline1 = plot.AddVerticalLine(x: x1, color: Color.Green, width: 2, style: LineStyle.Solid);
                vline1.PositionLabelOppositeAxis = true;
                vline1.PositionLabelAxis = plot.XAxis2;
                vline1.PositionLabel = true;
                vline1.PositionLabelBackground = Color.FromArgb(50, vline1.Color);
                vline1.PositionLabelFont.Color = Color.Black;
                vline1.PositionFormatter = FormatLabel;
                //SET (x2)
                // End of range
                var vline2 = plot.AddVerticalLine(x: x2, color: Color.Green, width: 2, style: LineStyle.Solid);
                vline2.PositionLabelOppositeAxis = true;
                vline2.PositionLabelAxis = plot.XAxis2;
                vline2.PositionLabel = true;
                vline2.PositionLabelBackground = Color.FromArgb(50, vline2.Color);
                vline2.PositionLabelFont.Color = Color.Black;
                vline2.PositionFormatter = FormatLabel;
                //SET (x1,x2)
                // Span
                var vSpan = plot.AddHorizontalSpan(x1, x2);
                vSpan.BorderLineWidth = 1;
                vSpan.BorderColor = Color.Gray;
                vSpan.BorderLineStyle = LineStyle.Solid;
                vSpan.Color = Color.FromArgb(50, Color.PaleGreen);
                vSpan.Label = $"Przedzia³ X \u2208 <{x1};{x2}>";

                //
                // Legend
                //
                //FIXED Values
                var legend = plot.Legend(enable: true);
                legend.Orientation = ScottPlot.Orientation.Vertical;
                legend.Location = Alignment.LowerRight;

                //
                // Plot for Zero Point as Function 
                //
                //SET (MxX,MzY,MzLabels)
                var zero = plot.AddScatterPoints(MzX, MzY, Color.Red, 12, MarkerShape.filledDiamond, label: $"Miejsce zerowe X = {MzX[0]}");
                zero.DataPointLabels = Mzlabels;
                zero.DataPointLabelFont.Size = 15;
                zero.DataPointLabelFont.Alignment = Alignment.UpperLeft;
                //vertical line for Mz
                var vlinez = plot.AddVerticalLine(x: MzX[0], color: Color.Red, width: 1, style: LineStyle.Dash);



                //
                // Function plot only lines
                //
                
                //with points and lines
                //plot.AddScatter(dataX, dataY, color: Color.Black, 1, 10, MarkerShape.filledCircle, label: $"Funkcja {funkcja}");
                plot.AddScatterLines(funX, funY, Color.Blue, 3, LineStyle.Solid, label: $"Funkcja {fun}");

                //// Functions are defined as delegates with an input and output
                //var func1 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 2));
                //var func2 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 3));
                //var func3 = new Func<double, double?>((x) => Math.Cos(x) * Math.Sin(x / 5));

                //// Add functions to the plot
                //plot.AddFunction(func1, lineWidth: 2);
                //plot.AddFunction(func2, lineWidth: 2, lineStyle: LineStyle.Dot);
                //plot.AddFunction(func3, lineWidth: 2, lineStyle: LineStyle.Dash);

                

                //plot.SaveFig("bubble_quickstart.png");
                formsPlot1.Refresh();
            }

        }
    }
}