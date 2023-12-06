//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// TYLKO TAKIE FUNKCJE

/*
P(x) = a * x^n + b * x^(n-1) + .. + c * x + d
n >= 0
n moze byc ulamkiem
Patrz (A) i (B) ponizej
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

    

    // (B) Potegi Kolejnych Wyrazen
    public static List<double> powers;
      // Ax^5 + C + Bx^3
      // powers = 5, 3, 0
      // Od lewej do prawej



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
    public double dDegree()
    {
      if (coefficients.Count == 0)
      {
        throw new Exception("Property coefficients has 0 elements");

      }

      double max = coefficients[0];

      foreach (var i in coefficients)
      {
        if (i > max)
        {
          max = i;

        }

      }

      return max;

    }

  }
}
