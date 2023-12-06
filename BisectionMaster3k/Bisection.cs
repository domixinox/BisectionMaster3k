namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  static class Bisection
  {
    //*****************************************************************************
    // [LEFT INCLUSIVE, RIGHT INCLUSIVE]
    public static double fBisection(double xleft=0, double xright=10, double fPrec=0.01, double iterations=100)
    {
      // Search for Midpoint
      double xmid = xleft / 2 + xright / 2;

      // Determine Signs
      double newxleft;
      double newxright;
      if (xleft < 0 && xmid < 0)
      {
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
