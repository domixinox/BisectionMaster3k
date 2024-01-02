//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// VALIDATOR != PARSER
// PARSER != VALIDATOR

/**
 * Klasa Walidacji - Cele:
 * # Upewnij sie ze pola nie sa puste
 */

using System.Text.RegularExpressions;

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  static class Validator
  {
    static public string fIndepVar = "x";
    static public string fAllowedChars = "1234567890-+*/^" + fIndepVar;

    //*****************************************************************************
    static public bool isDeltaFormatOK(string sdelta)
    {
      Regex myRegex = new Regex("0{0,1}\\.0*1", RegexOptions.IgnoreCase);
      return myRegex.IsMatch(sdelta);

    }

    //*****************************************************************************
    static public bool isRangeOK(string left, string right)
    {
      double dleft = Convert.ToDouble(left);
      double dright = Convert.ToDouble(right);
      return dleft < dright;

    }

    //*****************************************************************************
    static public bool isEmpty(string s)
    {
      return s.Length == 0 ? true : false;

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
