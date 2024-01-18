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
        string[]? PMzlabels;

        // Funkcja wielomianu
        //double[]? funX;
        //double[]? funY;
        // Nazwa wyswietlana w legendzie
        //string? fun;

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

            // Zeby na roznych kompach tak samo bylo - w³aœciwoœæ
            this.Size = new Size(1145, 900);
            AttachThings();
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
            checkMzlabel.Visible = false;
            checkLabels.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("it", "Iteracja");
            dataGridView1.Columns.Add("x", "Wartość x");
            dataGridView1.Columns.Add("fx", "Wartość f(x)");
        }

        private void ObliczMiejsceZerowe_Click(object sender, EventArgs e)
        {
            //
            // Reset danych
            //
            dataGridView1.Rows.Clear();

            CheckMz.Visible = false;
            CheckMzLine.Visible = false;
            CheckPotential.Visible = false;
            tabPageWyniki.Enabled = false;
            tabPageGraph.Enabled = false;
            checkMzlabel.Visible = false;
            checkLabels.Visible = false;
            //********************************************************
            x1 = Convert.ToDouble(numericX1.Text);
            x2 = Convert.ToDouble(numericX2.Text);
            int iterations = Convert.ToInt32(numericterations.Text);
            double delta = Convert.ToDouble(numericDelta.Text);
            precZero = ZerosPrecision(delta) + 1;
            double x = 0;
            double y = 0;

            // Miejsca zerowe
            MzX = null;
            MzY = null;

            // Potencjalne Miejsce zerowe
            PzX = null;
            PzY = null;

            //// Funkcja wielomianu
            //funX = null;
            //funY = null;
            //// Nazwa wyswietlana w legendzie
            //fun = null;
            PMzlabels = null;
            // Funkcja wielomianu wrzucana odrazu
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

            y = Parser.ParsePolynomialToDouble(inputPolynomial.Text);
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

            // Kacper: Testing
            /*
            string sInfo = "";
            for (int i = 0; i < Bisection.DRangeCenters.Count; i++)
            {
                sInfo += "\r\nx" + (i + 1).ToString() + " = " + Bisection.DRangeCenters[i].ToString();

            }

            MessageBox.Show(sInfo, "Potencjalne M. Zerowe");
            */

            tabPageWyniki.Enabled = true;
            tabControl1.SelectedTab = tabPageWyniki;

            // Wyniki - wypis
            wynikiMZerowe.Text = UserInterface.vFormatNumberPrecision(x, precZero);
            wynikiLiczbaIteracji.Text = Bisection.IMyIterations.ToString();
            wynikiMZerowe.BackColor = Color.PaleGreen;

            y = Polynomial.Instance.f(x);
            wynikiWartoscFunkcji.Text = UserInterface.vFormatNumberPrecision(y, precZero);

            //
            // Wykres Data - Data to rewrite with actual data 
            //
            // Miejsce zerowe
            if (!Double.IsNaN(x) && Double.IsFinite(x))
            {
                MzX = new double[] { Convert.ToDouble(UserInterface.vFormatNumberPrecision(x, precZero)) };
                MzY = new double[] { Convert.ToDouble(UserInterface.vFormatNumberPrecision(y, precZero)) };

                CheckMz.Visible = true;
                CheckMzLine.Visible = true;
                checkMzlabel.Visible = true;


            }

            // Potencjalne Miejsce zerowe 
            PzX = Bisection.DRangeCenters.ToArray();
            PzY = new double[PzX.Length];
            PMzlabels = new string[PzX.Length];
            for (int i = 0; i < PzX.Length; i++)
            {

                PzY[i] = Polynomial.Instance.f(PzX[i]);
                PMzlabels[i] = " x"+(i).ToString()+$" ({Convert.ToDouble(UserInterface.vFormatNumberPrecision(PzX[i], precZero))};{Convert.ToDouble(UserInterface.vFormatNumberPrecision(PzY[i], precZero))})"; //(i + 1).ToString();
                dataGridView1.Rows.Add(Convert.ToDouble((i + 1)), Convert.ToDouble(UserInterface.vFormatNumberPrecision(PzX[i], precZero)), Convert.ToDouble(UserInterface.vFormatNumberPrecision(PzY[i], precZero)));
            }
            dataGridView1.Rows.Add(Convert.ToDouble(PzX.Length + 1), Convert.ToDouble(UserInterface.vFormatNumberPrecision(x, precZero)), Convert.ToDouble(UserInterface.vFormatNumberPrecision(y, precZero)));
            dataGridView1.Rows[PzX.Length].DefaultCellStyle.BackColor = Color.PaleGreen;

            CheckPotential.Visible = true;
            checkLabels.Visible = true;
            // Funkcja wielomianu wrzucana odrazu 
            func1 = new Func<double, double?>((x) => Polynomial.Instance.f(x));
            // Nazwa wyswietlana w legendzie 
            fun1 = inputPolynomial.Text;


            //// Funkcja wielomianu //edit 1st
            //List<double> tmpX = new List<double>();
            //for (double i = x1; i <= x2; i=i+0.5)
            //{
            //    tmpX.Add(i);
            //}
            //funX = tmpX.ToArray();
            //funY = new double[funX.Length];
            //for (int i = 0; i < funX.Length; i++)
            //{
            //    funY[i] = Polynomial.Instance.f(funX[i]);
            //}

            //// Nazwa wyswietlana w legendzie wielomianu
            //fun = inputPolynomial.Text;

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

                if (/*funX != null && funY != null && fun != null &&*/ fun1 != null && func1 != null)
                {
                    // Dodaj dane wykresu funkcji wielomianu
                    //plot1.AddLinePlot(funX, funY, fun);
                    // Poka¿ wykres funkcji wielomianu
                    if (CheckFunction.Checked == true)
                    {
                        //plot1.ShowLinePlot();
                        //Poka¿ wykres funkcji wielomianu na podstawie delegata (label -> nazwa w legendzie)
                        plot1.ShowFuncLinePlot(label: fun1, funkcja: func1);
                    }
                    else
                    {
                        //plot1.ShowLinePlot(false);
                        //Poka¿ wykres funkcji wielomianu na podstawie delegata (label -> nazwa w legendzie)
                        plot1.ShowFuncLinePlot(false, label: fun1, funkcja: func1);
                    }
                }

                if (PzX != null && PzY != null)
                {
                    // Dodaj dane wykresu potencjalnych miejsc zerowych wyliczanych bisekcj¹
                    plot1.AddPotentialMz(PzX, PzY, PMzlabels, precZero);
                    // Poka¿ wykres potencjalnych miejsc zerowych
                    if (CheckPotential.Checked == true)
                    {
                        checkLabels.Enabled = true;
                        plot1.ShowPotentialPlot();
                        if (checkLabels.Checked == true)
                        {
                            plot1.ShowPotentialLabels();
                        }
                    }
                    else
                    {
                        checkLabels.Enabled = false;
                        checkLabels.Checked = false;
                        plot1.ShowPotentialPlot(false);
                    }

                }

                if (MzX != null && MzY != null)
                {
                    if (MzX.Length == 1 && MzY.Length == 1)
                    {
                        // Dodaj dane wykresu miejsc zerowych
                        plot1.AddMz(MzX, MzY, PzX.Length);
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
                            checkMzlabel.Enabled = true;
                            if (checkMzlabel.Checked == true)
                            {
                                plot1.ShowMzLabel();
                            }

                        }
                        else
                        {
                            checkMzlabel.Enabled = false;
                            checkMzlabel.Checked = false;
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
                plot1.FitData();
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
                else if (znak == ',' || znak == '.')
                {
                    poPrzecinku = true;
                }
            }

            return liczbaZer;
        }
        private void AttachThings()
        {
            this.label31.Size = new Size(1123, 11);
            this.label23.Size = new Size(1123, 11);
            this.label25.Size = new Size(1123, 11);
            this.label3.Size = new Size(1123, 11);
            this.label36.Size = new Size(1123, 11);
            this.label39.Size = new Size(1123, 11);
            this.label15.Size = new Size(1123, 11);
            this.label16.Size = new Size(1123, 11);
            this.label17.Size = new Size(1123, 11);
            this.ObliczMiejsceZerowe.Size = new Size(273, 51);
            this.ObliczMiejsceZerowe.Location = new Point(822, 12);
            this.BtnSwitchWykres.Location = new Point(926, 12);
            this.BtnSwitchWykres.Size = new Size(170, 51);
            this.BtnSave.Location = new Point(865, 5);
            this.BtnSave.Size = new Size(231, 51);
            this.BtnReset.Size = new Size(202, 51);
            this.BtnReset.Location = new Point(5, 5);
            this.label21.Location = new Point(317, 5);
            this.label21.Size = new Size(452, 54);
            this.wynikiMZerowe.Location = new Point(153, 55);
            this.wynikiMZerowe.Size = new Size(942, 34);
            this.wynikiLiczbaIteracji.Location = new Point(291, 55);
            this.wynikiLiczbaIteracji.Size = new Size(804, 34);
            this.wynikiWartoscFunkcji.Location = new Point(427, 109);
            this.wynikiWartoscFunkcji.Size = new Size(667, 34);
            this.inputPolynomial.Location = new Point(65, 55);
            this.inputPolynomial.Size = new Size(515, 30);
            this.inputPolynomialErrorMsg.Location = new Point(586, 55);
            this.inputPolynomialErrorMsg.Size = new Size(508, 85);
            this.numericterations.Location = new Point(87, 59);
            this.numericterations.Size = new Size(493, 30);
            this.inputIterationsErrorMsg.Location = new Point(586, 55);
            this.inputIterationsErrorMsg.Size = new Size(508, 85);
            this.numericDelta.Location = new Point(144, 59);
            this.numericDelta.Size = new Size(437, 30);
            this.inputDeltaErrorMsg.Location = new Point(586, 55);
            this.inputDeltaErrorMsg.Size = new Size(508, 85);
            this.numericX1.Location = new Point(64, 55);
            this.numericX1.Size = new Size(239, 30);
            this.numericX2.Location = new Point(325, 55);
            this.numericX2.Size = new Size(239, 30);
            this.inputRangeErrorMsg.Location = new Point(586, 55);
            this.inputRangeErrorMsg.Size = new Size(508, 85);

            this.checkLabels.Location = new Point(657, 48);
            this.checkLabels.Size = new Size(153, 21);
            this.checkMzlabel.Location = new Point(873, 48);
            this.checkMzlabel.Size = new Size(144, 21);

            this.CheckLegend.Location = new Point(15, 15);
            this.CheckLegend.Size = new Size(115, 40);
            this.CheckMzLine.Location = new Point(130, 15);
            this.CheckMzLine.Size = new Size(155, 40);
            this.CheckSpan.Location = new Point(285, 15);
            this.CheckSpan.Size = new Size(112, 40);
            this.CheckRange.Location = new Point(397, 15);
            this.CheckRange.Size = new Size(122, 40);
            this.CheckFunction.Location = new Point(519, 15);
            this.CheckFunction.Size = new Size(123, 40);
            this.CheckPotential.Location = new Point(642, 15);
            this.CheckPotential.Size = new Size(216, 40);
            this.CheckMz.Location = new Point(858, 15);
            this.CheckMz.Size = new Size(183, 40);

            this.label33.Location = new Point(10, 59);
            this.label33.Size = new Size(55, 23);
            this.label30.Location = new Point(15, 59);
            this.label30.Size = new Size(48, 23);
            this.label2.Location = new Point(309, 61);
            this.label2.Size = new Size(15, 23);
            this.label1.Location = new Point(565, 59);
            this.label1.Size = new Size(16, 23);
            this.label29.Location = new Point(5, 59);
            this.label29.Size = new Size(86, 23);
            this.label26.Location = new Point(5, 59);
            this.label26.Size = new Size(144, 23);
        }
        private void checkLabels_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }

        private void checkMzlabel_CheckedChanged(object sender, EventArgs e)
        {
            GeneratePlot();
        }
    }
}
