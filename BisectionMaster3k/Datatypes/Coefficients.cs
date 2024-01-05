//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/**
 * Klasa Coefficients - Cele:
 * # Lepsza kontrola nad dodawanymi elementami (w razie czego)
 */

using System.Collections.Generic;

namespace BisectionMaster3k.Datatypes
{
  //-----------------------------------------------------------------------------
  public class Coefficients<T> : List<T>
  {
    private List<T> values = new List<T>();
    
    // How Many Elements in private List
    public int Count
    {
      get { return values.Count; }

    }

    //*****************************************************************************
    // Indexer
    public T this[int index]
    {
      get
      {
        if (index < 0 || index >= values.Count)
        {
          throw new IndexOutOfRangeException("Index out of range.");

        }

        return values[index];

      }

      set
      {
        if (index < 0 || index >= values.Count)
        {
          throw new IndexOutOfRangeException("Index out of range.");

        }

        values[index] = value;

      }
    }

    //*****************************************************************************
    // Shadow List<type>.Add()
    public void Add(T element)
    {
      values.Add(element);

    }

  }
}
