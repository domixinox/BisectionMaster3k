﻿//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// VALIDATOR != PARSER
// PARSER != VALIDATOR

/**
 * Klasa Walidacji - Cele:
 * # Zapewnij wypelnienie pol tekstowych
 * # Zapewnij poprawnosc pol tekstowych
 */

using System.Text.RegularExpressions;

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  public static class Validator
  {

    public static string fIndepVar = "x";
    public static string fAllowedChars = "1234567890-+*/^" + fIndepVar;

    //*****************************************************************************
    // Validate Mathematical Operations on Polynomial
    static public bool isMathematicalCorrect(Polynomial poly, double xleft,
      Exceptions.ExceptionsCallback callback)
    {
      if (xleft < 0)
      {
        // Negative Range
        for (int i = 0; i < poly.Powers.Count; i++)
        {
          // Is Any Power a Fraction
          if (poly.Powers[i] != (int)poly.Powers[i])
          {
            // Prevent Square Rooting negative x
            Exceptions.vActBadMaths(callback,
              Exceptions.EBadMathsIndex.SquareRootingNegative);
            return false;

          }

        }
      }

      //
      // ...
      //

      return true;
    }

    //*****************************************************************************
    static public bool isDeltaFormatOK(string sdelta)
    {
      Regex myRegex = new Regex("0{0,1}\\,0*1", RegexOptions.IgnoreCase);

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
        bool isOK = false;

        // Sprawdz wzgledem Znakow Dozwolonych
        // Jeden MUSI sie zgadzac
        for (int j = 0; j < fAllowedChars.Length; j++)
        {
          if (fSignature[i] == fAllowedChars[j])
          {
            // Oj! Niedozwolony Znak
            isOK = true;
            break;

          }

        }

        if (isOK)
        {
          // Check INPUT next char
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
