//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/**
* Klasa Wyjatkow - Cele:
* # Zatrzymanie Programu w przypadku bledu
* # Wydrukowanie bledu do interfejsu uzytkownika
*/

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  public static class Exceptions
  {
    // Parent reference, Main Form reference
    private static BisectionMaster3k parent;

    // Operatre on different Objects
    public delegate void ExceptionsCallback(string errorMsg);

    // Cosmetics
    public static Color ErrorColor = Color.Red;
    public static Color SuccessColor = Color.ForestGreen;

    // INTERRUPT PROGRAM FLOW
    public static bool isProgramRun = true;

    // Scalability (future development): Different Function Types
    public enum Functions { Polynomial };

    //
    // Error Types
    //

    // Bracketing
    public const string EBracketing = "1";
    public static string EBracketingMsg =
      "Wartości skrajne nie posiadają przeciwnych znaków" +
      "\r\nMetoda bisekcji nie zadziała" +
      "\r\nProszę spróbować zmienić Przedział.";

    // Iterations out of range
    public const string EIterations = "2";
    public static string EIterationsMsg =
      "Osiągnięto limit iteracji." +
      "\r\nNie można wyznaczyć m. zerowego." +
      "\r\nProszę spróbować zmiększyć limit.";

    // Collections Count not matching
      // Think CoefficientsN != PowersN
      // Parse should take care but just in case ...
    public const string ECollectionsCount = "3";
    public static string ECollectionsCountMsg = 
      "Współczynniki i potęgi muszą być zapisane jawnie"
      + "\r\nProszę spróbować formy:"
      + "\r\n0x^0 + 10x^1 + 20x^2 + ..";

    // Powers negative
    public const string EPowersNegative = "4";
    public static string EPowersNegativeMsg =
      "Wielomian nie dopuszcza ujemnych potęg w wyrażeniach."
      + "\r\nMożna jednak używać ułamków.";

    // Bad Delta
    public const string EBadDelta = "5";
    public static string EBadDeltaMsg =
      "Precyzja nie posiada odpowiedniego formatu" +
      "\r\nProszę podać tak:" +
      "\r\n0.001";

    // Empty String
    public const string EEmptyString = "6";
    public static string EEmptyStringMsg = "Proszę coś wpisać";

    // Function Mathematically Incorrect
    public const string EBadMaths = "7";

    public enum EBadMathsIndex
    {
      SquareRootingNegative = 0,
      DividingByZero = 1

    };

    public static string[] EBadMathsMsg =
    {
      "Funkcja i Przedział zakładają pierwiastkowanie liczby ujemnej"
        + "\r\nProszę zmienić, np. przedział x>=0",
      "Nie dzielimy przez zero"

    };

    // ^^^
    // Error Types
    // ^^^

    //*****************************************************************************
    public static void init(BisectionMaster3k parent)
    {
      Exceptions.parent = parent;

    }

    //*****************************************************************************
    public static void vActBadMaths(ExceptionsCallback callback,
      // Easy to pass Array Index ...
      EBadMathsIndex errorMsgIndex)
    {
      isProgramRun = false;

      // ... As and Enum Argument :)
      callback(EBadMathsMsg[(int)errorMsgIndex]);

    }

    //*****************************************************************************
    public static void vActEmptyString(ExceptionsCallback callback)
    {
      isProgramRun = false;
      callback(EEmptyStringMsg);

    }

    //*****************************************************************************
    public static void vActBadDeltaFormat()
    {
      isProgramRun = false;
      parent.InputDeltaErrorMsg(EBadDeltaMsg);

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
      parent.InputPolynomialErrorMsg(ECollectionsCountMsg);

    }

    //*****************************************************************************
    public static void vActBracketingError()
    {
      isProgramRun = false;
      parent.InputRangeErrorMsg(EBracketingMsg);

    }

    //*****************************************************************************
    public static void vActIterationsError()
    {
      isProgramRun = false;
      parent.InputIterationsErrorMsg(EIterationsMsg);

    }

  }
}
