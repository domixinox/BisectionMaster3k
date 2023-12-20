using System.Collections.Generic;
using System.Xml.Linq;

namespace BisectionMaster3k.Datatypes
{
  //-----------------------------------------------------------------------------
  public class Powers<T> : List<T>
  {
    private List<T> values = new List<T>();

    //*****************************************************************************
    // Shadow List<type>.Add()
    public void Add(T element)
    {
      try
      {
        // Powers negative
        if (Convert.ToDouble(element) < 0.0)
        {
          throw new Exception(Exceptions.EPowersNegativeMsg);

        }

      }
      catch (Exception e)
      {
        switch (e.Message)
        {
          // Powers negative
          case Exceptions.EPowersNegative:
            Exceptions.vActPowersNegative();
            break;

        }

      }

      values.Add(element);

    }

  }
}
