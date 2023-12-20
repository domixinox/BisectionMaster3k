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
      // Zeby na roznych kompach tak samo bylo
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

      double x1     = Convert.ToDouble(inputRangeX1.Text);
      double x2     = Convert.ToDouble(inputRangeX2.Text);
      double delta  = 0.0001;

      double x = Bisection.fBisection(x1, x2, delta);

      MessageBox.Show(x.ToString());

    }
  }
}