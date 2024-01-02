using ScottPlot;
using ScottPlot.Drawing.Colormaps;
using ScottPlot.MarkerShapes;
using ScottPlot.Renderable;
using System.Windows.Forms;
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
            //this.Size = new Size(1145, 900);

            //
            // Windows Forms App lubi wyrzucac przypisane Metody do Delegatow
            // Proponuje subskrybowac recznie
            //
            KGraph plot1 = new KGraph(formsPlot1);
            // Dla pewnosci unsubscribe
            ObliczMiejsceZerowe.Click -= ObliczMiejsceZerowe_Click;
            ObliczMiejsceZerowe.Click += ObliczMiejsceZerowe_Click;

            CheckMz.Visible = false;
            CheckMzLine.Visible = false;
            CheckPotential.Visible = false;
            tabPageGraph.Enabled = false;
        }

        private void ObliczMiejsceZerowe_Click(object sender, EventArgs e)
        {
            //
            // Reset danych
            //
            CheckMz.Visible = false;
            CheckMzLine.Visible = false;
            CheckPotential.Visible = false;
            tabPageGraph.Enabled = false;
            //********************************************************
            x1 = 0;
            x2 = 0;
            double delta = 0;
            double x = 0;
            double y = 0;

            // Miejsca zerowe
            MzX = null;
            MzY = null;

            // Potencjalne Miejsce zerowe
            PzX = null;
            PzY = null;

            // Funkcja wielomianu
            funX = null;
            funY = null;
            // Nazwa wyswietlana w legendzie
            fun = null;

            // Funkcja wielomianu wrzucana odrazu
            // Functions are defined as delegates with an input and output
            func1 = null;
            // Nazwa wyswietlana w legendzie
            fun1 = null;
            //********************************************************

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

            //jest opcja ze mozemy wyswietlac wykres funkcji nawet jezeli nie ma miejsca zerowego do or no?

            delta = 0.0001;

            x = Bisection.fBisection(x1, x2, delta); //Czy w tym miejscu jak nie bd miejsca zerowego to sie wykrzaczy i nie bd dalej lecial program? bo jezeli nie bd lecial to musze przestawiaæ zeby wykres odpowiednio generowa³o (po if x funkcje od wielomianu przed x)
            MessageBox.Show(x.ToString());

            y = 0; //edit

            //
            // Wykres Data - rewrite/edit to variables
            //

            //// Data to rewrite with actual data 
            // Miejsce zerowe
            if (!Double.IsNaN(x) && Double.IsFinite(x))
            {
                MzX = new double[] { x };
                MzY = new double[] { y };

                CheckMz.Visible = true;
                CheckMzLine.Visible = true;

            }

            // option to disply this?
            // Potencjalne Miejsce zerowe //edit
            PzX = new double[] { 2, 1, 2 };
            PzY = new double[] { 1, 2, 3 };
            CheckPotential.Visible = true;

            // 2 options to choose method for wielomian
            //=======================================================================
            // Funkcja wielomianu //edit 1st
            funX = new double[] { x, 2, 5 };
            funY = new double[] { 3, 0, 5 };
            // Nazwa wyswietlana w legendzie //edit
            fun = "x^2+x+3";

            // Funkcja wielomianu wrzucana odrazu //edit 2nd
            // Functions are defined as delegates with an input and output
            func1 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 2));
            // Nazwa wyswietlana w legendzie //edit
            fun1 = "sin(x)*sin(x/2)";
            //=======================================================================

            // If dane exist enable customization
            tabPageGraph.Enabled = true;
            Reset();
            // Generate plot
            GeneratePlot();


        }
        public void GeneratePlot()
        {
            //
            //TO DO:
            //

            try
            {
                // Inicjuj plot
                KGraph plot1 = new KGraph(formsPlot1);
                // Wyczyœæ plot z wykresów
                plot1.Clear();
                // Ustaw zakres x1 do x2
                plot1.AddRange(x1, x2);

                // Poka¿ siatkê zakresu X
                if (CheckSpan.Checked == true)
                {
                    plot1.ShowSpan();
                }
                else
                {
                    plot1.ShowSpan(false);
                }

                // Poka¿ Linie zakresu X
                if (CheckRange.Checked == true)
                {
                    plot1.ShowRange();
                }
                else
                {
                    plot1.ShowRange(false);
                }

                if (funX != null && funY != null && fun != null /*&& fun1 != null && func1 != null*/)
                {
                    // Dodaj dane wykresu funkcji wielomianu
                    plot1.AddLinePlot(funX, funY, fun);
                    // Poka¿ wykres funkcji wielomianu
                    if (CheckFunction.Checked == true)
                    {
                        plot1.ShowLinePlot();
                        //Poka¿ wykres funkcji wielomianu na podstawie delegata (label -> nazwa w legendzie)
                        plot1.ShowFuncLinePlot(label: fun1, funkcja: func1);
                    }
                    else
                    {
                        plot1.ShowLinePlot(false);
                        //Poka¿ wykres funkcji wielomianu na podstawie delegata (label -> nazwa w legendzie)
                        plot1.ShowFuncLinePlot(false, label: fun1, funkcja: func1);
                    }
                }

                if (PzX != null && PzY != null)
                {
                    // Dodaj dane wykresu potencjalnych miejsc zerowych wyliczanych bisekcj¹
                    plot1.AddPotentialMz(PzX, PzY);
                    // Poka¿ wykres potencjalnych miejsc zerowych
                    if (CheckPotential.Checked == true)
                    {
                        plot1.ShowPotentialPlot();
                    }
                    else
                    {
                        plot1.ShowPotentialPlot(false);
                    }


                }

                if (MzX != null && MzY != null)
                {
                    if (MzX.Length == 1 && MzY.Length == 1)
                    {
                        // Dodaj dane wykresu miejsc zerowych
                        plot1.AddMz(MzX, MzY);
                        // Poka¿ linie przerywana X dla miejsca zerowego (singlePoint: false -> poka¿e wszystkie linie dla zapisane miejsca w tablicy)
                        if (CheckMzLine.Checked == true)
                        {
                            plot1.ShowMzLine();
                        }
                        else
                        {
                            plot1.ShowMzLine(false);
                        }

                        // Poka¿ miejsca zerowe (singlePoint: false -> poka¿e wszystkie zapisane miejsca w tablicy i zmieni nazwe w legendzie)
                        if (CheckMz.Checked == true)
                        {
                            plot1.ShowMzPlot();
                        }
                        else
                        {
                            plot1.ShowMzPlot(false);
                        }


                    }//W przypadku tego programu wypisywanie wiecej ni¿ 1 miejsca zerowego jest nie potrzebne

                }
                if (BtnSave_Click == null)
                {
                    MessageBox.Show("xd");
                }

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
        private void Reset()
        {
            CheckRange.Checked = true;
            CheckSpan.Checked = true;
            CheckMz.Checked = true;
            CheckMzLine.Checked = true;
            CheckPotential.Checked = true;
            CheckFunction.Checked = true;
            CheckLegend.Checked = true;
        }
        private void CheckLegend_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
            GeneratePlot();
        }

        private void CheckMzLine_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void CheckSpan_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void CheckRange_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void CheckFunction_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void CheckPotential_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void CheckMz_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Obraz bez t³a|*.png|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "Wykres-bisekcja";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Zapisz wykres";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                string extesion = Path.GetExtension(fileName);
                switch (extesion)
                {
                    case ".png":
                        formsPlot1.Plot.SaveFig(fileName);
                        break;
                    default:
                        MessageBox.Show("Z³y format pliku!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}