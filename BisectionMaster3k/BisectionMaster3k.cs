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

        double x1;
        double x2;

        // Miejsca zerowe
        double[]? MzX;
        double[]? MzY;

        // Potencjalne Miejsce zerowe
        double[]? PzX;
        double[]? PzY;

        // Funkcja wielomianu
        double[]? funX;
        double[]? funY;
        // Nazwa wyswietlana w legendzie
        string? fun;

        // Funkcja wielomianu wrzucana odrazu
        // Functions are defined as delegates with an input and output
        Func<double, double?>? func1;
        // Nazwa wyswietlana w legendzie
        string? fun1;


        public BisectionMaster3k()
        {
            InitializeComponent();

            // Rozmiar Okna Glownego
            // Zeby na roznych kompach tak samo bylo - w³aœciwoœæ -> FormBorderStyle - FixedSingle
            //this.Size = new Size(1000, 1000);

            //
            // Windows Forms App lubi wyrzucac przypisane Metody do Delegatow
            // Proponuje subskrybowac recznie
            //
            KGraph plot1 = new KGraph(formsPlot1);
            // Dla pewnosci unsubscribe
            ObliczMiejsceZerowe.Click -= ObliczMiejsceZerowe_Click;
            ObliczMiejsceZerowe.Click += ObliczMiejsceZerowe_Click;
            
            tabPageGraph.Enabled = false;
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

            x1 = Convert.ToDouble(inputRangeX1.Text);
            x2 = Convert.ToDouble(inputRangeX2.Text);
            double delta = 0.0001;

            double x = Bisection.fBisection(x1, x2, delta);
            MessageBox.Show(x.ToString());

            double y = 0; //edit

            //
            // Wykres Data - rewrite/edit to variables
            //

            //// Data to rewrite with actual data 
            // Miejsce zerowe
            if (!Double.IsNaN(x) && Double.IsFinite(x))
            {
                MzX = new double[] { x };
                MzY = new double[] { y };
            }

            // option to disply this?

            // Potencjalne Miejsce zerowe //edit
            PzX = new double[] { 2, 1, 2 };
            PzY = new double[] { 1, 2, 3 };

            // 2 options to choose method for wielomian
            //=======================================================================
            // Funkcja wielomianu //edit
            funX = new double[] { x, 2, 5 };
            funY = new double[] { 3, 0, 5 };
            // Nazwa wyswietlana w legendzie //edit
            fun = "x^2+x+3";

            // Funkcja wielomianu wrzucana odrazu //edit
            // Functions are defined as delegates with an input and output
            func1 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 2));
            // Nazwa wyswietlana w legendzie //edit
            fun1 = "sin(x)*sin(x/2)";
            //=======================================================================

            // If dane exist enable customization
            tabPageGraph.Enabled = true;

            // Generate plot
            GeneratePlot();


        }
        public void GeneratePlot()
        {
            //
            //TO DO:
            //
            //wincej on/off kolor? zapis

            try
            {
                // Inicjuj plot
                KGraph plot1 = new KGraph(formsPlot1);
                // Wyczyœæ plot z wykresów
                plot1.Clear();
                // Ustaw zakres x1 do x2
                plot1.AddRange(x1, x2);
                // Poka¿ siatkê zakresu X
                plot1.ShowSpan();
                // Poka¿ Linie zakresu X
                plot1.ShowRange();

                //Poka¿ wykres funkcji wielomianu na podstawie delegata (label -> nazwa w legendzie)
                plot1.ShowFuncLinePlot(label: fun1, funkcja: func1);

                // Dodaj dane wykresu funkcji wielomianu
                plot1.AddLinePlot(funX, funY, fun);
                // Poka¿ wykres funkcji wielomianu
                plot1.ShowLinePlot();

                // Dodaj dane wykresu potencjalnych miejsc zerowych wyliczanych bisekcj¹
                plot1.AddPotentialMz(PzX, PzY);
                // Poka¿ wykresu potencjalnych miejsc zerowych
                plot1.ShowPotentialPlot();
                if (MzX != null && MzY != null)
                {
                    // Dodaj dane wykresu miejsc zerowych
                    plot1.AddMz(MzX, MzY);
                    // Poka¿ linie przerywana X dla miejsca zerowego (singlePoint: false -> poka¿e wszystkie linie dla zapisane miejsca w tablicy)
                    plot1.ShowMzLine();
                    // Poka¿ miejsca zerowe (singlePoint: false -> poka¿e wszystkie zapisane miejsca w tablicy i zmieni nazwe w legendzie)
                    plot1.ShowMzPlot();
                }

                //plot1.Save("C:\\Users\\Dominik\\Desktop\\jd.png");

                // Poka¿ legendê wykresu
                if (CheckLegend.Checked == true)
                {
                    plot1.ShowLegend();
                }
                else
                {
                    plot1.ShowLegend(false);
                }
            }
            catch (Exception ex)
            {
                //error do handlingu jakby jakis blad wystapil help anyone?
                MessageBox.Show(text: ex.ToString());
                throw;
            }

        }
        private void CheckLegend_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CheckLegend.Checked = true;
            GeneratePlot();
        }
    }
}