//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// VALIDATOR != PARSER
// PARSER != VALIDATOR

/**
 * Klasa Walidacji - Cele:
 * # Upewnij sie ze pola nie sa puste
 */

using ScottPlot.Drawing.Colormaps;
using System.Text.RegularExpressions;

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  public static class Validator
  {

    public static string fIndepVar = "x";
    public static string fAllowedChars = "1234567890-+*/^" + fIndepVar;

    //*****************************************************************************
    static public bool isDeltaFormatOK(string sdelta)
    {
      Regex myRegex = new Regex("0{0,1}\\.0*1", RegexOptions.IgnoreCase);

      bool isOK = myRegex.IsMatch(sdelta);

      // Obsluga bledu
      if (! isOK)
      {
        Exceptions.vActBadDeltaFormat();

      }

      // Zwracanko tak dodatkowo
      return isOK;

    }

    //*****************************************************************************
    static public bool isRangeOK(string left, string right)
    {
      double dleft = Convert.ToDouble(left);
      double dright = Convert.ToDouble(right);

      bool isOK = dleft < dright;

      // Obsluga bledu
      if (!isOK)
      {
        Exceptions.vActBracketingError();

      }

      return isOK;

    }

    //*****************************************************************************
    public static bool isEmpty(string s, Exceptions.ExceptionsCallback callback)
    {
      bool isOK = s.Length != 0 ? true : false;

      // Obsluga bledu
      if (!isOK)
      {
        Exceptions.vActEmptyString(callback);

      }

      return isOK;

    }

    //*****************************************************************************
    static public bool isFAllowedChars(string fSignature)
    {
      // Pobierane z: TextBox
      // Sprawdz KAZDY Znak inputu uzytkownika
      for (int i = 0; i < fSignature.Length; i++)
      {
        bool isOK = true;

        // Sprawdz wzgledem Znakow Dozwolonych
        for (int j = 0; j < fAllowedChars.Length; j++)
        {
          if (fSignature[i] != fAllowedChars[j])
          {
            // Oj! Niedozwolony Znak
            isOK = false;
            break;

          }

        }

        if (isOK)
        {
          continue;

        }

        // Niedozwolony Znak
        return false;

      }

      // Ok! Wszystkie Znaki dozwolone
      return true;

    }
  }
}
