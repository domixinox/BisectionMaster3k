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
            this.Size = new Size(1000, 1000);

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
            Polynomial poly1 = Polynomial.Instance;
            MessageBox.Show(poly1.dDegree().ToString());

        }
    }
}