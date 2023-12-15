//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// TYLKO TAKIE FUNKCJE

/**
 * P(x) = ax^(n) + bx^(n-1) + .. + cx + d
 * ! n = liczba naturalna, liczba ulamkowa
 * Patrz (A) i (B) ponizej
 */

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  public class Polynomial
  {
    // (A) Wspolczynniki Kolejnych Wyrazen
    private List<double> coefficients;
      // Ax^5 + C + Bx^3
      // coefficients = A, B, C
      // Od lewej do prawej

    public List<double> Coefficients
    {
      get { return coefficients; }

    }

    // (B) Potegi Kolejnych Wyrazen
    public static List<double> powers;
      // Ax^5 + C + Bx^3
      // powers = 5, 3, 0
      // Od lewej do prawej
      
    public List<double> Powers
    {
      get { return powers; }

    }

    // Singleton private constructor
    private Polynomial()
    {
      coefficients = new List<double>();
      powers = new List<double>();

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
    // CONDITIONS:
    // powers.Count == coefficients.Count
    public double f(double x, int expr = 0)
    {
      // BASE CASE: max expr
      return expr < powers.Count ? coefficients[expr] * Math.Pow(x, powers[expr])
        + f(x, expr+1) : 0;

    }

    //*****************************************************************************
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
