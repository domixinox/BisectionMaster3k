using System.Collections.Generic;

namespace BisectionMaster3k.Datatypes
{
  //-----------------------------------------------------------------------------
  public class Coefficients<T> : List<T>
  {
    private List<T> values = new List<T>();

    //*****************************************************************************
    // Shadow List<type>.Add()
    public void Add(T element)
    {
      values.Add(element);

    }

  }
}
