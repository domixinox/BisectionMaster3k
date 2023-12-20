//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// VALIDATOR != PARSER
// PARSER != VALIDATOR

/**
 * Klasa Walidacji - Cele:
 * # Upewnij sie ze pola nie sa puste
 */

namespace BisectionMaster3k
{
  //-----------------------------------------------------------------------------
  static class Validator
  {
    static public string fIndepVar = "x";
    static public string fAllowedChars = "1234567890-+*/^" + fIndepVar;

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
