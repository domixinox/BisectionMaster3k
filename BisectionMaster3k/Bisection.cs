//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/**
 * Klasa Bisekcji - Cele:
 * # znajdz 1 m. zerowe
 */

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  public static class Bisection
  {
    private static List<double> dRangeCenters = new List<double>();
    public static List<double> DRangeCenters
    {
      get { return dRangeCenters; }
    }

    private static int iMyIterations;
    public static int IMyIterations
    {
      get { return iMyIterations; }
    }

    //*****************************************************************************
    // Bisection Method
    // [LEFT INCLUSIVE, RIGHT INCLUSIVE]
    public static double fBisection(double xleft = 0, double xright = 10,
      double fPrec = 0.01, int iterations = 100, bool isReset = true)
    {
      if (isReset)
      {
        dRangeCenters.Clear();
        vResetIterations();

      }

      iMyIterations++;

      try
      {

        //
        // Bracketing Condition
        //

        if (! isOppositeSignedValues(xleft, xright))
        {
          // Already Resolved
          if (! Exceptions.isProgramRun)
          {
            throw new Exception("");

          }

          throw new Exception(Exceptions.EBracketing);

        }

        //
        // Iterations
        //

        if (iterations <= 0)
        {
          throw new Exception(Exceptions.EIterations);

        }

      }
      catch (Exception e)
      {
        switch (e.Message)
        {
          // Already Resolved
          case "":
            return 0;

          // Bracketing Failure
          case Exceptions.EBracketing:
            Exceptions.vActBracketingError();
            return Convert.ToDouble(Exceptions.EBracketing);

          // Iterations Failure
          case Exceptions.EIterations:
            Exceptions.vActIterationsError();
            return Convert.ToDouble(Exceptions.EIterations);

        }

      }

      //
      // Find Midpoint
      //

      double xmid = xleft / 2.0 + xright / 2.0;

      //
      // Is Midpoint < Precision required ?
      //

      // BASE CASE: Tolerance
      if (isRangleTolerable(xleft, xright, fPrec))
      {
        return xmid;

      }

      dRangeCenters.Add(xmid);

      //
      // Prepare New Recursion
      //

      // Determine Signs
      double newxleft;
      double newxright;
      if (isOppositeSignedValues(xleft, xmid))
      {
        // Signs must differ
        newxleft = xleft;
        newxright = xmid;

      }
      else
      {
        // Signs must differ
        newxleft = xmid;
        newxright = xright;

      }

      return fBisection(newxleft, newxright, fPrec, iterations - 1, false);

    }

    //*****************************************************************************
    private static void vResetIterations()
    {
      iMyIterations = 0;

    }

    //*****************************************************************************
    private static bool isOppositeSignedValues(double x1, double x2)
    {
      // ... or is signed value and zero
      double fx1 = Polynomial.Instance.f(x1);
      double fx2 = Polynomial.Instance.f(x2);
      return fx1 * fx2 <= 0;

    }

    //*****************************************************************************
    private static bool isRangleTolerable(double xleft, double xright, double fPrec)
    {
      return Math.Abs(xleft - xright) <= fPrec;

    }
  }
}
