namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  static class Bisection
  {
    private const string EBracketing = "1";

    //*****************************************************************************
    // Bisection Method
    // [LEFT INCLUSIVE, RIGHT INCLUSIVE]
    public static double fBisection(double xleft=0, double xright=10,
      double fPrec=0.01, double iterations=100)
    {
      //
      // Bracketing Condition
      //

      try
      {
        if (Polynomial.Instance.f(xleft) * Polynomial.Instance.f(xright) > 0)
        {
          throw new Exception(EBracketing);
  
        }

        

      }
      catch (Exception e)
      {
        switch (e.Message)
        {
          case EBracketing:
            // Exception Class
            break;

        }

      }

      //
      // Find Midpoint
      //

      double xmid = xleft / 2 + xright / 2;

      //
      // Is it it ?
      //

      // return;

      //
      // Prepare New Recursion
      //

      // Determine Signs
      double newxleft;
      double newxright;
      if (Polynomial.Instance.f(xleft) < 0 && Polynomial.Instance.f(xmid) > 0)
      {
        // signs must differ
        newxleft = xleft;
        newxright = xmid;

      }
      else
      {
        newxleft = xmid;
        newxright = xright;

      }

      // Base Case Tolerance
      return isRangleTolerable(newxleft, newxright, fPrec) ? xmid :
        fBisection(newxleft, newxright, fPrec);

    }

    //*****************************************************************************
    private static bool isRangleTolerable(double xleft, double xright, double fPrec)
    {
      return Math.Abs(xleft - xright) <= fPrec;

    }

  }
}
