//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



using System.Runtime.CompilerServices;
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
    // INTERRUPT PROGRAM FLOW
    public static bool isProgramRun = true;

    // Bracketing
    public const string EBracketing = "1";

    // Iterations out of range
    public const string EIterations = "2";
    public static string EIterationsMsg =
      "Osiągnięto limit iteracji." +
      "\r\nNie można wyznaczyć m. zerowego." +
      "\r\nProszę spróbować zmiększyć limit.";

    // Collections Count not matching
    public const string ECollectionsCount = "3";

    // Powers negative
    public const string EPowersNegative = "4";
    public static string EPowersNegativeMsg = "Nie wolno ujemnych poteg";

    public enum Functions { Polynomial };

    // Parent reference, Main Form reference
    private static BisectionMaster3k parent;

    //*****************************************************************************
    public static void init(BisectionMaster3k parent)
    {
      Exceptions.parent = parent;

    }

    //*****************************************************************************
    public static void vActPowersNegative()
    {
      isProgramRun = false;
      parent.InputPolynomialErrorMsg(EPowersNegativeMsg);

    }

    //*****************************************************************************
    public static void vActCollectionsCountf(Functions function)
    {
      isProgramRun = false;
      // MessageBox

    }

    //*****************************************************************************
    public static void vActBracketingError()
    {
      isProgramRun = false;
      // MessageBox

    }

    //*****************************************************************************
    public static void vActIterationsError()
    {
      isProgramRun = false;
      // MessageBox

    }

  }
}
