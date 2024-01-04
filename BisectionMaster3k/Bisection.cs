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
    //*****************************************************************************
    private static bool isOppositeSignedValues(double x1, double x2)
    {
      return Polynomial.Instance.f(x1) * Polynomial.Instance.f(x2) < 0;

    }

    //*****************************************************************************
    private static bool isRangleTolerable(double xleft, double xright, double fPrec)
    {
      return Math.Abs(xleft - xright) <= fPrec;

    }

    //*****************************************************************************
    // Bisection Method
    // [LEFT INCLUSIVE, RIGHT INCLUSIVE]
    public static double fBisection(double xleft = 0, double xright = 10,
      double fPrec = 0.01, double iterations = 100)
    {
      try
      {

        //
        // Bracketing Condition
        //

        if (! isOppositeSignedValues(xleft, xright))
        {
          throw new Exception(Exceptions.EBracketing);

        }

        //
        // Iterations
        //

        if (iterations < 0)
        {
          throw new Exception(Exceptions.EIterations);

        }

      }
      catch (Exception e)
      {
        switch (e.Message)
        {
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

      return fBisection(newxleft, newxright, fPrec, iterations-1);

    }
  }
}
