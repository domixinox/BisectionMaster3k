//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/**
 * Klasa Wyjatkow - Cele:
 * # Zatrzymanie Programu w przypadku bledu
 * # Wydrukowanie bledu do interfejsu uzytkownika
 */

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  static class Exceptions
  {
    // Bracketing
    public const string EBracketing = "1";

    // Iterations out of range
    public const string EIterations = "2";

    // Collections Count not matching
    public const string ECollectionsCount = "3";

    // Powers negative
    public const string EPowersNegative = "4";
    public static string EPowersNegativeMsg = "Nie wolno ujemnych poteg";

    public enum Functions
    {
      Polynomial

    };

    //*****************************************************************************
    public static void vActPowersNegative()
    {
      // MessageBox

    }

    //*****************************************************************************
    public static void vActCollectionsCountf(Functions function)
    {
      // MessageBox

    }

    //*****************************************************************************
    public static void vActBracketingError()
    {
      // MessageBox

    }

    //*****************************************************************************
    public static void vActIterationsError()
    {
      // MessageBox

    }

  }
}
