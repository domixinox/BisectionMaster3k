using BisectionMaster3k.Frontend;
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
        int precZero = 2;

        public BisectionMaster3k()
        {
            InitializeComponent();

            //
            // Przepustka na komunikację typu:
            // klasa statyczne -> this, Main Form
            //

            Exceptions.init(this);

            // Rozmiar Okna Glownego
            // Zeby na roznych kompach tak samo bylo - w³aœciwoœæ -> FormBorderStyle - FixedSingle
            this.Size = new Size(1145, 900);

            //
            // Windows Forms App lubi wyrzucac przypisane Metody do Delegatow
            // Proponuje subskrybowac recznie
            //
            KGraph plot1 = new KGraph(formsPlot1);
            // Dla pewnosci unsubscribe
            ObliczMiejsceZerowe.Click -= ObliczMiejsceZerowe_Click;
            ObliczMiejsceZerowe.Click += ObliczMiejsceZerowe_Click;
            //// unsubscribe from the default right-click menu event
            formsPlot1.RightClicked -= formsPlot1.DefaultRightClickEvent;
            //// add a custom right-click action
            formsPlot1.RightClicked += CustomRightClickEvent;
            CheckMz.Visible = false;
            CheckMzLine.Visible = false;
            CheckPotential.Visible = false;
            tabPageGraph.Enabled = false;
            tabPageWyniki.Enabled = false;
        }

        private void ObliczMiejsceZerowe_Click(object sender, EventArgs e)
        {
            //
            // Reset danych
            //
            CheckMz.Visible = false;
            CheckMzLine.Visible = false;
            CheckPotential.Visible = false;
            tabPageWyniki.Enabled = false;
            tabPageGraph.Enabled = false;
            //********************************************************
            x1 = Convert.ToDouble(numericX1.Text);
            x2 = Convert.ToDouble(numericX2.Text);
            int iterations = Convert.ToInt32(numericterations.Text);
            double delta = Convert.ToDouble(numericDelta.Text);
            precZero = ZerosPrecision(delta) + 2;
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
            // Walidator
            //

            Exceptions.isProgramRun = true;

            inputDeltaErrorMsg.ForeColor = Exceptions.SuccessColor;
            inputDeltaErrorMsg.Text = "Wszystko dobrze";
            inputIterationsErrorMsg.ForeColor = Exceptions.SuccessColor;
            inputIterationsErrorMsg.Text = "Wszystko dobrze";
            inputPolynomialErrorMsg.ForeColor = Exceptions.SuccessColor;
            inputPolynomialErrorMsg.Text = "Wszystko dobrze";
            inputRangeErrorMsg.ForeColor = Exceptions.SuccessColor;
            inputRangeErrorMsg.Text = "Wszystko dobrze";

            // czy pola tekstowe nie są puste
            Validator.isEmpty(inputPolynomial.Text, InputPolynomialErrorMsg);
            Validator.isEmpty(numericX1.Text, InputRangeErrorMsg);
            Validator.isEmpty(numericX2.Text, InputRangeErrorMsg);
            Validator.isEmpty(numericterations.Text, InputIterationsErrorMsg);
            Validator.isEmpty(numericDelta.Text, InputDeltaErrorMsg);

            // czy zakres xlewo < xprawo
            Validator.isRangeOK(numericX1.Text, numericX2.Text);
            // czy sygnatura wielomianu ma Tylko dozwolone znaki
            Validator.isFAllowedChars(inputPolynomial.Text);
            // czy max błąd m. zerowego ma dobry format
            Validator.isDeltaFormatOK(numericDelta.Text);

            // Kacper: Teraz w klasie :Exceptions.cs: znajduje się pole
            // :public static bool isProgramRun:
            // Jeśli doszło do wyjątki:
            //    WYJĄTEK JUŻ WYŚWIETLA SIĘ NA EKRANIE USERA, koniec programu
            // Jeśli nie doszło do wyjątku:
            //    brak informacji o błędzie, kontunuacja programu
            if (!Exceptions.isProgramRun)
            {
                return;

            }

            // ^^^
            // Walidator
            //

            //
            // Parser
            //

            // ( Patrz: Parser.cs )

            Parser.ParsePolynomialToDouble(inputPolynomial.Text);
            //======================================================================================================
            // Problem#1Na większych wielomianach przedział nie działa(?)
            // Kacper: Testowałem Bisection:fBisection na wielowyrazowych wielomianach
            // Kacper: (Patrz: [NOTATKA1] | ten plik)
            // Kacper: Co konkretnie się wyświetla ?

            // Problem#2:Pierwszy wpisany wielomian nie resestuje i nadpisuę następne
            // Kacper: Parser powinien oczyszczać, nie klasa Polynomial
            // Kacper: Klasa Polynomial przechowuje
            // Kacper: Klasa Parser przypisuje ( ... i oczyszcza) :
            // Polynomial.Instance.Coefficients.Clear();
            // Polynomial.Instance.Powers.Clear();
            // Kacper: dodałem

            //PS: Nieraz nawet kiedy da się dowolny wielomian to przedział mu nie pasuję...
            // Kacper: Parser? Again, Bisection:fBisection było testowane
            // Kacper: (Patrz: [NOTATKA1] | ten plik)

            //func1 = new Func<double, double?>((x) => Polynomial.Instance.f(x));

            //=========================================================================================================



            // [NOTATKA1]
            // Kacper: Testing
            // Polynomial.Instance.Coefficients.Add(10);
            // Polynomial.Instance.Powers.Add(0.5);
            // Polynomial.Instance.Coefficients.Add(1);
            // Polynomial.Instance.Powers.Add(0.5);
            // Polynomial.Instance.Coefficients.Add(-10);
            // Polynomial.Instance.Powers.Add(0);

            // ^^^
            // Parser
            //

            //
            // Walidator After Parser
            //

            // Create new Delegate => choose error output ...
            Exceptions.ExceptionsCallback callbacks =
              new Exceptions.ExceptionsCallback(InputPolynomialErrorMsg);
            // ... subscribe next method = next error output
            callbacks += InputRangeErrorMsg;

            Validator.isMathematicalCorrect(Polynomial.Instance, x1, callbacks);


            if (!Exceptions.isProgramRun)
            {
                return;

            }

            // ^^^
            // Walidator After Parser
            //

            //
            // Bisekcja
            //

            // Overwrite diterations on return
            x = Bisection.fBisection(x1, x2, delta, iterations);

            if (!Exceptions.isProgramRun)
            {
                return;

            }

            // ^^^
            // Bisekcja
            //

            // Kacper: Testing
            // MessageBox.Show(x.ToString(), "double m. zerowe z Bisection::fBisection");

            tabPageWyniki.Enabled = true;
            tabControl1.SelectedTab = tabPageWyniki;

            // Wyniki - wypis
            wynikiMZerowe.Text = x.ToString();//UserInterface.vFormatNumberPrecision(x, 4);
            wynikiLiczbaIteracji.Text = Bisection.IMyIterations.ToString();

            y = Polynomial.Instance.f(x);
            wynikiWartoscFunkcji.Text = y.ToString();//UserInterface.vFormatNumberPrecision(y, 4); //Math.Round(y, precZero).ToString(); precZero = ZerosPrecision(delta) + 2 -> liczy liczbe zer po przecinku do wystapienia innej cyfry ; jezeli delta = 0.001 zwroci wynik np 9.9996

            //
            // Wykres Data - Data to rewrite with actual data 
            //
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
            PzX = new double[] { 2.123456789, 1, 2 };
            PzY = new double[] { 1.123456789, 2, 3 };
            CheckPotential.Visible = true;

            // 2 options to choose method for wielomian
            //=======================================================================
            // Funkcja wielomianu //edit 1st
            funX = new double[] { x, 2, 5 };
            funY = new double[] { 3, 0, 5 };
            // Nazwa wyswietlana w legendzie wielomianu
            fun = inputPolynomial.Text;

            // Funkcja wielomianu wrzucana odrazu //edit 2nd
            // Functions are defined as delegates with an input and output
            func1 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 2)); //<======= nazwa func1 jest wykorzystana na lini kody 177
                                                                                     // Nazwa wyswietlana w legendzie 
            fun1 = inputPolynomial.Text;
            //=======================================================================

            // If dane exist enable customization
            tabPageGraph.Enabled = true;
            Reset();
            // Generate plot
            GeneratePlot();


        }

        //*****************************************************************************
        public void InputRangeErrorMsg(string text)
        {
            inputRangeErrorMsg.ForeColor = Exceptions.ErrorColor;
            inputRangeErrorMsg.Text = text;

        }

        //*****************************************************************************
        public void InputPolynomialErrorMsg(string text)
        {
            inputPolynomialErrorMsg.ForeColor = Exceptions.ErrorColor;
            inputPolynomialErrorMsg.Text = text;

        }

        //*****************************************************************************
        public void InputIterationsErrorMsg(string text)
        {
            inputIterationsErrorMsg.ForeColor = Exceptions.ErrorColor;
            inputIterationsErrorMsg.Text = text;

        }

        //*****************************************************************************
        public void InputDeltaErrorMsg(string text)
        {
            inputDeltaErrorMsg.ForeColor = Exceptions.ErrorColor;
            inputDeltaErrorMsg.Text = text;

        }

        public void GeneratePlot()
        {

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
                    plot1.AddPotentialMz(PzX, PzY, precZero);
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
                        plot1.AddMz(MzX, MzY, precZero);
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
                            plot1.ShowMzPlot(prec: precZero);
                        }
                        else
                        {
                            plot1.ShowMzPlot(false);
                        }


                    }//W przypadku tego programu wypisywanie wiecej ni¿ 1 miejsca zerowego jest nie potrzebne

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
                MessageBox.Show("Błąd przy generowaniu wykresu." + ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {

                Filter = "PNG pliki (*.png)|*.png;*.png" +
                         "|JPG pliki (*.jpg, *.jpeg)|*.jpg;*.jpeg" +
                         "|BMP pliki (*.bmp)|*.bmp;*.bmp" +
                         "|Wszystkie pliki (*.*)|*.*",
                FilterIndex = 1,
                FileName = "Wykres-bisekcja.png",
                RestoreDirectory = true,
                Title = "Zapisz wykres"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                formsPlot1.Plot.SaveFig(saveFileDialog1.FileName);
            }
        }
        private void CustomRightClickEvent(object sender, EventArgs e)
        {
            ContextMenuStrip customMenu = new ContextMenuStrip();
            customMenu.Items.Add(new ToolStripMenuItem("Zapisz jako...", null, new EventHandler(RightClickMenu_SaveImage_Click)));
            customMenu.Items.Add(new ToolStripMenuItem("Zoom dla danych", null, new EventHandler(RightClickMenu_AutoAxis_Click)));
            customMenu.Items.Add(new ToolStripMenuItem("Otwórz w oknie", null, new EventHandler(RightClickMenu_OpenInNewWindow_Click)));
            customMenu.Items.Add(new ToolStripMenuItem("Pomoc (Eng.)", null, new EventHandler(RightClickMenu_Help_Click)));
            customMenu.Show(System.Windows.Forms.Cursor.Position);

        }
        private void RightClickMenu_Help_Click(object sender, EventArgs e) => new FormHelp().Show();
        private void RightClickMenu_AutoAxis_Click(object sender, EventArgs e) { formsPlot1.Plot.AxisAuto(); formsPlot1.Refresh(); }
        private void RightClickMenu_OpenInNewWindow_Click(object sender, EventArgs e) => new FormsPlotViewer(formsPlot1.Plot).Show();

        private void RightClickMenu_SaveImage_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "PNG pliki (*.png)|*.png;*.png" +
                         "|JPG pliki (*.jpg, *.jpeg)|*.jpg;*.jpeg" +
                         "|BMP pliki (*.bmp)|*.bmp;*.bmp" +
                         "|Wszystkie pliki (*.*)|*.*",
                FilterIndex = 1,
                FileName = "Wykres-bisekcja.png",
                RestoreDirectory = true,
                Title = "Zapisz wykres"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                formsPlot1.Plot.SaveFig(sfd.FileName);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnSwitchWykres_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageGraph;
        }
        private int ZerosPrecision(double liczba)
        {
            string liczbaStr = liczba.ToString();
            bool poPrzecinku = false;
            int liczbaZer = 0;

            foreach (char znak in liczbaStr)
            {
                if (poPrzecinku)
                {
                    if (znak == '0')
                    {
                        liczbaZer++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (znak == ',')
                {
                    poPrzecinku = true;
                }
            }

            return liczbaZer;
        }
    }
}
