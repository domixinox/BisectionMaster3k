//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/**
* UserInterface - Cele:
* # formatuj dane przyjaźnie dla użytkownika
* 
* 
*/

using System.Text.RegularExpressions;

namespace BisectionMaster3k.Frontend
{
  //-----------------------------------------------------------------------------
  public static class UserInterface
  {
    //*****************************************************************************
    public static string vFormatNumberPrecision(double number, int precision)
    {
      // Fixed-point to precision
      string sFormattedNumber = number.ToString("F" + precision.ToString());

      // number: .dot or ,comma always exists
      // ∵ Precision is required < 0
      // in Frontend Form
      // precision = 4
      // 10. => 10.1234

      // Handle "-0.0000"
      Regex myRegex = new Regex("-.*[\\.,].*[123456789]", RegexOptions.IgnoreCase);
      if (! myRegex.IsMatch(sFormattedNumber))
      {
        // Remove '-'
        sFormattedNumber = sFormattedNumber.Substring(1);

      }

        return sFormattedNumber;

    }

  }
}
