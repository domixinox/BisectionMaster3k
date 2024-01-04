//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

 /**
  * Klasa Wielomiany - Cele:
  * # przechowuj kolejne potegi
  * # przechowuj kolejne wspolczynniki
  * # licz f(x)
  * # podaj stopien f(x)
  */
 
using BisectionMaster3k.Datatypes;

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  public class Polynomial
  {
    //
    // Wspolczynniki
    //

    // (A) Wspolczynniki Kolejnych Wyrazen
    private Coefficients<double> coefficients;

    public Coefficients<double> Coefficients
    {
      get { return coefficients; }

    }

    //
    // Potegi
    //

    // (B) Potegi Kolejnych Wyrazen
    public Powers<double> powers;
      
    public Powers<double> Powers
    {
      get { return powers; }

    }

    //
    // Singleton Type Class
    //

    // Singleton private constructor
    private Polynomial()
    {
      coefficients = new Coefficients<double>();
      powers = new Powers<double>();

    }

    // Singleton field
    private static Polynomial instance;

    // Singleton Access Point
    public static Polynomial Instance
    {
      get
      {
        if (instance == null)
        {
          // Single Time Initialization
          // Look: private constructor
          instance = new Polynomial();

        }

        return instance;

      }

    }

    //*****************************************************************************
    // COMPUTE F(x)
    public double f(double x, int expr = 0)
    {
      // CONDITION
      if (powers.Count != coefficients.Count)
      {
        Exceptions.vActCollectionsCountf(Exceptions.Functions.Polynomial);
        return Convert.ToDouble(Exceptions.ECollectionsCount);

      }

      // BASE CASE: max expr
      return expr < powers.Count ? coefficients[expr] * Math.Pow(x, powers[expr])
        + f(x, expr+1) : 0;

    }

    //*****************************************************************************
    // COMPUTE DEGREE of F(x)
    // Funkcja nieuzywana, tak o dodatkowo
    public double dDegree()
    {
      // Prevent IndexOutOfRangeException
      if (powers.Count == 0)
      {
        return 0;

      }

      // Find max power
      double max = powers[0];
      foreach (var i in powers)
      {
        if (i > max)
        {
          max = i;

        }

      }

      // Return max power
      return max;

    }

  }
}
